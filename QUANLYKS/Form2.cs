using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
namespace QUANLYKS
{
    public partial class Form2 : Form
    {

        private SqlConnection con;
        private DataTable dt = new DataTable("tbKhachsan");
        private SqlDataAdapter da = new SqlDataAdapter();
        private Timer timer = new Timer();
        private DateTime lastActionTime;
        public Form2()
        {
            InitializeComponent();
            timer.Interval = 120000; // 2 giây
            timer.Tick += Timer_Tick;
            lastActionTime = DateTime.Now;

            // Gán các sự kiện cho form
            this.MouseDown += Form2_MouseDown;
            this.KeyPress += Form2_KeyPress;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            ketnoi(); // Mở kết nối đến cơ sở dữ liệu
            timer.Start();
            // Thực hiện truy vấn SQL để lấy dữ liệu từ bảng KHACHSAN
            string query = "SELECT * FROM KHACHSAN";
            da.SelectCommand = new SqlCommand(query, con);

            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            da.Fill(dt);

            // Hiển thị dữ liệu trên DataGridView
            dataGridView1.DataSource = dt;

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            disconnect(); // Đóng kết nối đến cơ sở dữ liệu
        }
        private void ketnoi()
        {
            String cn = @"Data Source=DESKTOP-JK7J6BR\SQLEXPRESS;Initial Catalog=QUAN_LYKS_LUXURYHOTEL;
            Integrated Security=True";
            try
            {
                con = new SqlConnection(cn);
                con.Open();
                MessageBox.Show("Kết nối thành công", "Ahihi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong the ket noi toi csdl", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void disconnect()   // gọi hàm này sau khi đã dùng xong csdl 
        {
            con.Close();
            con.Dispose();
            con = null;
        }

        private void btnTimkiemphong_Click(object sender, EventArgs e)
        {
            // Mở kết nối đến cơ sở dữ liệu
            ketnoi();
            if (cbDiadiem.SelectedItem == null && dtPkngayden.Value == null && dtPkngaydi.Value == null)
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ các trường.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Lấy giá trị được chọn từ ComboBox và DateTimePicker
            string location = null;
            if (cbDiadiem.SelectedItem != null)
            {
                location = cbDiadiem.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn địa điểm đến.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime fromDate = dtPkngayden.Value.Date;
            DateTime toDate = dtPkngaydi.Value.Date;
            DataTable dtTemp = dt.Clone();
            foreach (DataRow row in dt.Rows)
            {
                dtTemp.ImportRow(row);
            }
            // Xóa dữ liệu cũ trong DataTable
            dt.Clear();
            if (cbDiadiem.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn địa điểm đến.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt.Clear();
                dt.Merge(dtTemp);
            }
            if (dtPkngayden.Value == null)
            {
                MessageBox.Show("Vui lòng chọn thời gian check in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt.Clear();
                dt.Merge(dtTemp);
            }
            if (dtPkngaydi.Value == null)
            {
                MessageBox.Show("Vui lòng chọn thời gian check out.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt.Clear();
                dt.Merge(dtTemp);
            }
            // Thực hiện truy vấn stored procedure để lấy dữ liệu từ bảng PHONG
            SqlCommand cmd = new SqlCommand("SearchRooms", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm các tham số cho stored procedure
            cmd.Parameters.Add("@Location", SqlDbType.NVarChar, 50).Value = location;
            cmd.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate;
            cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate;


            if (fromDate >= toDate)
            {
                MessageBox.Show("Ngày đến phải trước ngày đi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt.Clear();
                dt.Merge(dtTemp);


            }
            // Thực thi stored procedure và lấy dữ liệu vào DataTable
            da.SelectCommand = cmd;
            da.Fill(dt);
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                bool isColumnEmpty = true;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(row.Cells[column.Name].Value)))
                    {
                        isColumnEmpty = false;
                        break;
                    }
                }
                column.Visible = !isColumnEmpty;
            }

            // Hiển thị dữ liệu trên DataGridView
            dataGridView1.DataSource = dt;
            // Reset lại timer
            timer.Stop();
            timer.Start();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Dừng đếm thời gian
            timer.Stop();

            // Kiểm tra xem đã quá 2 giây kể từ thời điểm hành động cuối cùng hay không
            TimeSpan elapsedTime = DateTime.Now - lastActionTime;
            if (elapsedTime.TotalSeconds >= 120)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
        private void AnyActionHandler(object sender, EventArgs e)
        {
            // Cập nhật thời gian khi có hành động từ người dùng
            lastActionTime = DateTime.Now;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
    }
}   


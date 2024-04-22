using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Timer = System.Windows.Forms.Timer;
namespace QUANLYKS
{
    public partial class Form3 : Form
    {
        private SqlConnection con;
        private DataTable dt = new DataTable("tbTTnhanphong");
        private SqlDataAdapter da = new SqlDataAdapter();
        private Timer timer = new Timer();
        private DateTime lastActionTime;
        public Form3()
        {
            InitializeComponent();
            timer.Interval = 12000; // 2 giây
            timer.Tick += Timer_Tick;
            lastActionTime = DateTime.Now;
            timer.Start(); // Khởi động Timer

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một phòng để hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maPhong = selectedRow.Cells["MÃ PHÒNG"].Value.ToString();

                if (CapNhatTrangThaiPhong(maPhong, 1))
                {
                    MessageBox.Show("Hủy phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở lại kết nối và tải lại dữ liệu
                    ketnoi();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể hủy phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để hủy phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void Form3_Load(object sender, EventArgs e)
        {
            ketnoi();
         
            LoadData();
        }
       
        private void LoadData()
        {
            // Xóa dữ liệu cũ trong DataTable
            dt.Clear();

            // Thực hiện truy vấn stored procedure để lấy dữ liệu từ bảng PHONG
            SqlCommand cmd = new SqlCommand("TT_Phong", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thực thi stored procedure và lấy dữ liệu vào DataTable
            da.SelectCommand = cmd;
            da.Fill(dt);

            // Hiển thị dữ liệu trên DataGridView
            dataGridView1.DataSource = dt;

            // Đóng kết nối
            disconnect();
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            disconnect(); // Đóng kết nối đến cơ sở dữ liệu
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaphong.Text.Trim();
            string loaiPhong = txtLoaiphong.Text.Trim();

            foreach (char c in loaiPhong)
            {
                if (!char.IsLetterOrDigit(c) && c != ' ') // Kiểm tra xem kí tự có phải là chữ hoặc số không và không phải dấu cách
                {
                    MessageBox.Show("Loại phòng không được chứa kí tự đặc biệt. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLoaiphong.Text = "";
                    return;
                }
            }
            // Kiểm tra xem mã phòng có chứa kí tự đặc biệt hay không
            foreach (char c in maPhong)
            {
                if (!char.IsLetterOrDigit(c) && c != ' ') // Kiểm tra xem kí tự có phải là chữ hoặc số không và không phải dấu cách
                {
                    MessageBox.Show("Mã phòng không được chứa kí tự đặc biệt. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaphong.Text = "";
                    return;
                }
            }




            // Lấy giá trị từ các điều khiển trên giao diện
            maPhong = txtMaphong.Text;
             loaiPhong = txtLoaiphong.Text;
            DateTime ngayDen = dtpkNgayden.Value;
            DateTime ngayDi = dtPkngaydi.Value;

            // Mở kết nối đến cơ sở dữ liệu
            ketnoi();

            try
            {
                // Tạo SqlCommand để gọi stored procedure TT_Phong_Search
                SqlCommand cmd = new SqlCommand("TT_Phong_Search", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số cho stored procedure
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                cmd.Parameters.AddWithValue("@LoaiPhong", loaiPhong);
                cmd.Parameters.AddWithValue("@NgayDen", ngayDen);
                cmd.Parameters.AddWithValue("@NgayDi", ngayDi);

                // Tạo đối tượng SqlDataAdapter và DataTable để lấy dữ liệu từ stored procedure
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                da.Fill(dt);

                // Hiển thị dữ liệu trên DataGridView
                dataGridView1.DataSource = dt;

                if (dataGridView1.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Khách hàng chưa đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ khi thực hiện truy vấn
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng kết nối đến cơ sở dữ liệu
                disconnect();
            }
            timer.Stop();
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Dừng đếm thời gian
            timer.Stop();

            // Kiểm tra xem đã quá 12 giây kể từ thời điểm hành động cuối cùng hay không
            TimeSpan elapsedTime = DateTime.Now - lastActionTime;
            if (elapsedTime.TotalSeconds >= 12)
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
        private void btnGiao_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maPhong = selectedRow.Cells["MÃ PHÒNG"].Value.ToString();

                if (CapNhatTrangThaiPhong(maPhong, 4))
                {
                    MessageBox.Show("Giao phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở lại kết nối và tải lại dữ liệu
                    ketnoi();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể giao phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để giao phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CapNhatTrangThaiPhong(string maPhong, int trangThaiMoi)
        {
            try
            {
                ketnoi(); // Mở kết nối đến cơ sở dữ liệu

                // Tạo câu lệnh SQL cập nhật trạng thái phòng
                string query = "UPDATE PHONG SET STA_TUS = @TrangThaiMoi WHERE MAPHONG = @MaPhong";

                // Tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand(query, con);

                // Thêm tham số cho câu lệnh SQL
                cmd.Parameters.AddWithValue("@TrangThaiMoi", trangThaiMoi);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                // Thực thi câu lệnh SQL
                int rowsAffected = cmd.ExecuteNonQuery();

                // Kiểm tra xem có hàng nào được ảnh hưởng hay không
                if (rowsAffected > 0)
                {
                    return true; // Cập nhật thành công
                }
                else
                {
                    return false; // Không có phòng nào được cập nhật
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Xảy ra lỗi
            }
            finally
            {
                disconnect(); // Đóng kết nối đến cơ sở dữ liệu
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           
            txtLoaiphong.Text = "";
            txtMaphong.Text = "";

            
            dtpkNgayden.Value = DateTime.Now;
            dtPkngaydi.Value = DateTime.Now;         
        }

    }
}

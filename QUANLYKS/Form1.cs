using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QUANLYKS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTracuu_Click(object sender, EventArgs e)
        {
           
           
            Form2 frm = new Form2();
            frm.Show();
        }

        private void btnTtuc_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        

    }
}

namespace QUANLYKS
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dtpkNgayden = new DateTimePicker();
            label2 = new Label();
            dtPkngaydi = new DateTimePicker();
            label3 = new Label();
            txtLoaiphong = new TextBox();
            btnTimkiem = new Button();
            btnThoat = new Button();
            dataGridView1 = new DataGridView();
            btnGiao = new Button();
            btnHuy = new Button();
            label4 = new Label();
            txtMaphong = new TextBox();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày";
            // 
            // dtpkNgayden
            // 
            dtpkNgayden.CalendarMonthBackground = Color.White;
            dtpkNgayden.Location = new Point(85, 12);
            dtpkNgayden.Name = "dtpkNgayden";
            dtpkNgayden.Size = new Size(200, 23);
            dtpkNgayden.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 18);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Đến ngày";
            // 
            // dtPkngaydi
            // 
            dtPkngaydi.Location = new Point(371, 11);
            dtPkngaydi.Name = "dtPkngaydi";
            dtPkngaydi.Size = new Size(200, 23);
            dtPkngaydi.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 58);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Loại phòng";
            // 
            // txtLoaiphong
            // 
            txtLoaiphong.Location = new Point(85, 55);
            txtLoaiphong.Name = "txtLoaiphong";
            txtLoaiphong.Size = new Size(100, 23);
            txtLoaiphong.TabIndex = 5;
            // 
            // btnTimkiem
            // 
            btnTimkiem.BackColor = Color.FromArgb(192, 255, 192);
            btnTimkiem.Location = new Point(591, 9);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(126, 32);
            btnTimkiem.TabIndex = 6;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = false;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(192, 255, 192);
            btnThoat.Location = new Point(616, 331);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(101, 58);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(705, 192);
            dataGridView1.TabIndex = 8;
            // 
            // btnGiao
            // 
            btnGiao.BackColor = Color.FromArgb(192, 255, 192);
            btnGiao.Location = new Point(12, 331);
            btnGiao.Name = "btnGiao";
            btnGiao.Size = new Size(101, 58);
            btnGiao.TabIndex = 9;
            btnGiao.Text = "Giao phòng";
            btnGiao.UseVisualStyleBackColor = false;
            btnGiao.Click += btnGiao_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(192, 255, 192);
            btnHuy.Location = new Point(425, 331);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(101, 58);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Huỷ phòng";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 63);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 11;
            label4.Text = "Mã phòng";
            // 
            // txtMaphong
            // 
            txtMaphong.Location = new Point(371, 55);
            txtMaphong.Name = "txtMaphong";
            txtMaphong.Size = new Size(100, 23);
            txtMaphong.TabIndex = 12;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(192, 255, 192);
            btnReset.Location = new Point(213, 331);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(101, 58);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(txtMaphong);
            Controls.Add(label4);
            Controls.Add(btnHuy);
            Controls.Add(btnGiao);
            Controls.Add(dataGridView1);
            Controls.Add(btnThoat);
            Controls.Add(btnTimkiem);
            Controls.Add(txtLoaiphong);
            Controls.Add(label3);
            Controls.Add(dtPkngaydi);
            Controls.Add(label2);
            Controls.Add(dtpkNgayden);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Thủ tục giao phòng";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpkNgayden;
        private Label label2;
        private DateTimePicker dtPkngaydi;
        private Label label3;
        private TextBox txtLoaiphong;
        private Button btnTimkiem;
        private Button btnThoat;
        private DataGridView dataGridView1;
        private Button btnGiao;
        private Button btnHuy;
        private Label label4;
        private TextBox txtMaphong;
        private Button btnReset;
    }
}
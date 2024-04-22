namespace QUANLYKS
{
    partial class Form2
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
            cbDiadiem = new ComboBox();
            label1 = new Label();
            dtPkngayden = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dtPkngaydi = new DateTimePicker();
            btnTimkiemphong = new Button();
            dataGridView1 = new DataGridView();
            btnThoat = new Button();
            btnDkidatphong = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbDiadiem
            // 
            cbDiadiem.FormattingEnabled = true;
            cbDiadiem.Items.AddRange(new object[] { "TP Hồ Chí Minh", "Nha Trang", "Cần Thơ", "Vũng Tàu", "Bình Định" });
            cbDiadiem.Location = new Point(133, 25);
            cbDiadiem.Name = "cbDiadiem";
            cbDiadiem.Size = new Size(121, 23);
            cbDiadiem.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 28);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Chọn địa điểm";
            // 
            // dtPkngayden
            // 
            dtPkngayden.Location = new Point(359, 25);
            dtPkngayden.Name = "dtPkngayden";
            dtPkngayden.Size = new Size(200, 23);
            dtPkngayden.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 28);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Ngày đến";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 69);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Ngày đi";
            // 
            // dtPkngaydi
            // 
            dtPkngaydi.Location = new Point(359, 65);
            dtPkngaydi.Name = "dtPkngaydi";
            dtPkngaydi.Size = new Size(200, 23);
            dtPkngaydi.TabIndex = 5;
            // 
            // btnTimkiemphong
            // 
            btnTimkiemphong.BackColor = Color.FromArgb(128, 255, 255);
            btnTimkiemphong.Location = new Point(629, 28);
            btnTimkiemphong.Name = "btnTimkiemphong";
            btnTimkiemphong.Size = new Size(105, 60);
            btnTimkiemphong.TabIndex = 6;
            btnTimkiemphong.Text = "Tra cứu";
            btnTimkiemphong.UseVisualStyleBackColor = false;
            btnTimkiemphong.Click += btnTimkiemphong_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(735, 186);
            dataGridView1.TabIndex = 7;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(128, 255, 255);
            btnThoat.Location = new Point(28, 310);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 60);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDkidatphong
            // 
            btnDkidatphong.BackColor = Color.FromArgb(128, 255, 255);
            btnDkidatphong.Location = new Point(658, 310);
            btnDkidatphong.Name = "btnDkidatphong";
            btnDkidatphong.Size = new Size(105, 60);
            btnDkidatphong.TabIndex = 9;
            btnDkidatphong.Text = "Đăng kí đặt phòng";
            btnDkidatphong.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnDkidatphong);
            Controls.Add(btnThoat);
            Controls.Add(dataGridView1);
            Controls.Add(btnTimkiemphong);
            Controls.Add(dtPkngaydi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtPkngayden);
            Controls.Add(label1);
            Controls.Add(cbDiadiem);
            Name = "Form2";
            Text = "Tra cứu khách sạn";
            Load += Form2_Load;
            KeyPress += Form2_KeyPress;
            MouseDown += Form2_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDiadiem;
        private Label label1;
        private DateTimePicker dtPkngayden;
        private Label label2;
        private Label label3;
        private DateTimePicker dtPkngaydi;
        private Button btnTimkiemphong;
        private DataGridView dataGridView1;
        private Button btnThoat;
        private Button btnDkidatphong;
    }
}
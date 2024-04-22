namespace QUANLYKS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pn1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnTtuc = new Button();
            btnTracuu = new Button();
            label1 = new Label();
            label2 = new Label();
            pn1.SuspendLayout();
            SuspendLayout();
            // 
            // pn1
            // 
            pn1.BackColor = Color.FromArgb(128, 128, 255);
            pn1.Controls.Add(button3);
            pn1.Controls.Add(button2);
            pn1.Controls.Add(button1);
            pn1.Controls.Add(btnTtuc);
            pn1.Controls.Add(btnTracuu);
            pn1.Dock = DockStyle.Top;
            pn1.Location = new Point(0, 0);
            pn1.Name = "pn1";
            pn1.Size = new Size(747, 46);
            pn1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(609, 0);
            button3.Name = "button3";
            button3.Size = new Size(97, 46);
            button3.TabIndex = 4;
            button3.Text = "Đánh giá khách sạn";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Location = new Point(466, 0);
            button2.Name = "button2";
            button2.Size = new Size(97, 46);
            button2.TabIndex = 3;
            button2.Text = "Đăng nhập tài khoản";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(320, 0);
            button1.Name = "button1";
            button1.Size = new Size(97, 46);
            button1.TabIndex = 2;
            button1.Text = "Đăng kí đặt phòng";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnTtuc
            // 
            btnTtuc.BackColor = Color.FromArgb(255, 128, 128);
            btnTtuc.Location = new Point(170, 0);
            btnTtuc.Name = "btnTtuc";
            btnTtuc.Size = new Size(97, 46);
            btnTtuc.TabIndex = 1;
            btnTtuc.Text = "Thủ tục giao phòng";
            btnTtuc.UseVisualStyleBackColor = false;
            btnTtuc.Click += btnTtuc_Click;
            // 
            // btnTracuu
            // 
            btnTracuu.BackColor = Color.FromArgb(255, 128, 128);
            btnTracuu.Location = new Point(27, 0);
            btnTracuu.Name = "btnTracuu";
            btnTracuu.Size = new Size(97, 46);
            btnTracuu.TabIndex = 0;
            btnTracuu.Text = "Tra cứu khách sạn";
            btnTracuu.UseVisualStyleBackColor = false;
            btnTracuu.Click += btnTracuu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(27, 113);
            label1.Name = "label1";
            label1.Size = new Size(652, 50);
            label1.TabIndex = 1;
            label1.Text = "PHẦN MỀM QUẢN LÝ KHÁCH SẠN ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(212, 163);
            label2.Name = "label2";
            label2.Size = new Size(284, 50);
            label2.TabIndex = 2;
            label2.Text = "LUXURY HOTEL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pn1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pn1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pn1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnTtuc;
        private Button btnTracuu;
        private Label label1;
        private Label label2;
    }
}

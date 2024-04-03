namespace Medical_Manage.AdministrtorUC
{
    partial class UC_Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            Adminlabel = new Label();
            label8 = new Label();
            label5 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            Pharlabel = new Label();
            label9 = new Label();
            label6 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(65, 38);
            label1.Name = "label1";
            label1.Size = new Size(146, 37);
            label1.TabIndex = 0;
            label1.Text = "DashBoard";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(Adminlabel);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(65, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 319);
            panel1.TabIndex = 1;
            // 
            // Adminlabel
            // 
            Adminlabel.AutoSize = true;
            Adminlabel.BorderStyle = BorderStyle.FixedSingle;
            Adminlabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Adminlabel.ForeColor = SystemColors.ButtonHighlight;
            Adminlabel.Location = new Point(72, 252);
            Adminlabel.Name = "Adminlabel";
            Adminlabel.Size = new Size(39, 32);
            Adminlabel.TabIndex = 4;
            Adminlabel.Text = "20";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 209);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 3;
            label8.Text = "Tổng Số Quản trị viên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 95);
            label5.Name = "label5";
            label5.Size = new Size(142, 60);
            label5.TabIndex = 2;
            label5.Text = "Công việc:\r\n* Thêm người dùng\r\n* Xem người dùng\r\n* Xem báo cáo từ dược sỹ\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 21);
            label2.Name = "label2";
            label2.Size = new Size(143, 30);
            label2.TabIndex = 0;
            label2.Text = "Quản Trị Viên";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 255);
            panel2.Controls.Add(Pharlabel);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(294, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 319);
            panel2.TabIndex = 2;
            // 
            // Pharlabel
            // 
            Pharlabel.AutoSize = true;
            Pharlabel.BorderStyle = BorderStyle.FixedSingle;
            Pharlabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Pharlabel.ForeColor = SystemColors.ButtonHighlight;
            Pharlabel.Location = new Point(81, 252);
            Pharlabel.Name = "Pharlabel";
            Pharlabel.Size = new Size(39, 32);
            Pharlabel.TabIndex = 5;
            Pharlabel.Text = "20";
            Pharlabel.Click += Pharlabel_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(55, 209);
            label9.Name = "label9";
            label9.Size = new Size(100, 15);
            label9.TabIndex = 4;
            label9.Text = "Tổng số Dược sỹ: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 95);
            label6.Name = "label6";
            label6.Size = new Size(157, 60);
            label6.TabIndex = 2;
            label6.Text = "Công việc:\r\n* Xem các sản phẩm vật tư\r\n* Thêm các sản phẩm vật tư \r\n* Tạo đơn hàng";
            label6.Click += label6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 21);
            label3.Name = "label3";
            label3.Size = new Size(149, 30);
            label3.TabIndex = 1;
            label3.Text = "Nhà Cung cấp";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(555, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 319);
            panel3.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 95);
            label7.Name = "label7";
            label7.Size = new Size(101, 30);
            label7.TabIndex = 3;
            label7.Text = "Công việc:\r\n*Xem và đặt hàng";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 21);
            label4.Name = "label4";
            label4.Size = new Size(125, 30);
            label4.TabIndex = 2;
            label4.Text = "Khách hàng";
            label4.Click += label4_Click;
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "UC_Dashboard";
            Size = new Size(1386, 768);
            Load += UC_Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label7;
        private Label Pharlabel;
        private Label label9;
        private Label Adminlabel;
        private Label label8;
    }
}

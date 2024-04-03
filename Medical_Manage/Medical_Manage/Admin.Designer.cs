namespace Medical_Manage
{
    partial class Admin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel1 = new Panel();
            userNamelabel = new Label();
            btnLogOut = new Button();
            button4 = new Button();
            btnView = new Button();
            btnAddUser = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel2 = new Panel();
            uC_AddUser1 = new AdministrtorUC.UC_AddUser();
            uC_Dashboard1 = new AdministrtorUC.UC_Dashboard();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            uC_ViewUser1 = new AdministrtorUC.UC_ViewUser();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(userNamelabel);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnView);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 464);
            panel1.TabIndex = 0;
            // 
            // userNamelabel
            // 
            userNamelabel.AutoSize = true;
            userNamelabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            userNamelabel.ForeColor = Color.Fuchsia;
            userNamelabel.Location = new Point(58, 421);
            userNamelabel.Name = "userNamelabel";
            userNamelabel.Size = new Size(104, 30);
            userNamelabel.TabIndex = 8;
            userNamelabel.Text = "minhtoan";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(0, 64, 64);
            btnLogOut.ForeColor = SystemColors.Control;
            btnLogOut.Location = new Point(58, 365);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(157, 29);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Đăng Xuất";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 64, 64);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(58, 314);
            button4.Name = "button4";
            button4.Size = new Size(157, 29);
            button4.TabIndex = 6;
            button4.Text = "Profile";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(0, 64, 64);
            btnView.ForeColor = SystemColors.Control;
            btnView.Location = new Point(58, 259);
            btnView.Name = "btnView";
            btnView.Size = new Size(157, 29);
            btnView.TabIndex = 5;
            btnView.Text = "Xem User";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(0, 64, 64);
            btnAddUser.ForeColor = SystemColors.Control;
            btnAddUser.Location = new Point(58, 207);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(157, 29);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "Thêm User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(0, 64, 64);
            btnDashboard.ForeColor = SystemColors.Control;
            btnDashboard.Location = new Point(58, 161);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(157, 29);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(29, 119);
            label1.Name = "label1";
            label1.Size = new Size(143, 30);
            label1.TabIndex = 2;
            label1.Text = "Quản Trị Viên";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = panel2;
            // 
            // panel2
            // 
            panel2.Controls.Add(uC_ViewUser1);
            panel2.Controls.Add(uC_AddUser1);
            panel2.Controls.Add(uC_Dashboard1);
            panel2.Location = new Point(223, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(972, 580);
            panel2.TabIndex = 1;
            // 
            // uC_AddUser1
            // 
            uC_AddUser1.Location = new Point(3, 3);
            uC_AddUser1.Name = "uC_AddUser1";
            uC_AddUser1.Size = new Size(1104, 770);
            uC_AddUser1.TabIndex = 2;
            // 
            // uC_Dashboard1
            // 
            uC_Dashboard1.BackColor = SystemColors.ButtonHighlight;
            uC_Dashboard1.Location = new Point(3, 29);
            uC_Dashboard1.Name = "uC_Dashboard1";
            uC_Dashboard1.Size = new Size(815, 518);
            uC_Dashboard1.TabIndex = 0;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = panel2;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.TargetControl = panel2;
            // 
            // uC_ViewUser1
            // 
            uC_ViewUser1.BackColor = Color.White;
            uC_ViewUser1.Location = new Point(0, 3);
            uC_ViewUser1.Name = "uC_ViewUser1";
            uC_ViewUser1.Size = new Size(1104, 609);
            uC_ViewUser1.TabIndex = 2;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 729);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnDashboard;
        private Button btnLogOut;
        private Button button4;
        private Button btnView;
        private Button btnAddUser;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel2;
        private AdministrtorUC.UC_Dashboard uC_Dashboard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AdministrtorUC.UC_AddUser uC_AddUser1;
        private Label userNamelabel;
        private AdministrtorUC.UC_ViewUser uC_ViewUser1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    }
}
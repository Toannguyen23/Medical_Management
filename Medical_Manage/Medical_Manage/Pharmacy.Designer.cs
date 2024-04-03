namespace Medical_Manage
{
    partial class Pharmacy
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacy));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnUpdateMedicine = new Guna.UI2.WinForms.Guna2Button();
            btnMedicineView = new Guna.UI2.WinForms.Guna2Button();
            btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            uC_P_UpdateMedicine1 = new Pharmacists.UC_P_UpdateMedicine();
            uC_P_ViewMedicine1 = new Pharmacists.UC_P_ViewMedicine();
            uC_AddMedical1 = new Pharmacist.UC_AddMedical();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnUpdateMedicine);
            panel1.Controls.Add(btnMedicineView);
            panel1.Controls.Add(btnAddMedicine);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 599);
            panel1.TabIndex = 0;
            // 
            // btnUpdateMedicine
            // 
            btnUpdateMedicine.CustomizableEdges = customizableEdges3;
            btnUpdateMedicine.DisabledState.BorderColor = Color.DarkGray;
            btnUpdateMedicine.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdateMedicine.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdateMedicine.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdateMedicine.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateMedicine.ForeColor = Color.White;
            btnUpdateMedicine.Location = new Point(57, 337);
            btnUpdateMedicine.Name = "btnUpdateMedicine";
            btnUpdateMedicine.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnUpdateMedicine.Size = new Size(187, 45);
            btnUpdateMedicine.TabIndex = 4;
            btnUpdateMedicine.Text = "Cập Nhật";
            btnUpdateMedicine.Click += btnUpdateMedicine_Click;
            // 
            // btnMedicineView
            // 
            btnMedicineView.CustomizableEdges = customizableEdges5;
            btnMedicineView.DisabledState.BorderColor = Color.DarkGray;
            btnMedicineView.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMedicineView.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMedicineView.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMedicineView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMedicineView.ForeColor = Color.White;
            btnMedicineView.Location = new Point(57, 268);
            btnMedicineView.Name = "btnMedicineView";
            btnMedicineView.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnMedicineView.Size = new Size(187, 45);
            btnMedicineView.TabIndex = 3;
            btnMedicineView.Text = "Hiển Thị";
            btnMedicineView.Click += btnMedicineView_Click;
            // 
            // btnAddMedicine
            // 
            btnAddMedicine.CustomizableEdges = customizableEdges7;
            btnAddMedicine.DisabledState.BorderColor = Color.DarkGray;
            btnAddMedicine.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddMedicine.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddMedicine.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddMedicine.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddMedicine.ForeColor = Color.White;
            btnAddMedicine.Location = new Point(57, 199);
            btnAddMedicine.Name = "btnAddMedicine";
            btnAddMedicine.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAddMedicine.Size = new Size(187, 45);
            btnAddMedicine.TabIndex = 2;
            btnAddMedicine.Text = "Thêm Vật Tư";
            btnAddMedicine.Click += guna2Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(69, 155);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 1;
            label1.Text = "Dược Sỹ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(uC_P_UpdateMedicine1);
            panel2.Controls.Add(uC_P_ViewMedicine1);
            panel2.Controls.Add(uC_AddMedical1);
            panel2.Location = new Point(251, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(981, 737);
            panel2.TabIndex = 1;
            // 
            // uC_P_UpdateMedicine1
            // 
            uC_P_UpdateMedicine1.BackColor = Color.White;
            uC_P_UpdateMedicine1.Location = new Point(3, 38);
            uC_P_UpdateMedicine1.Name = "uC_P_UpdateMedicine1";
            uC_P_UpdateMedicine1.Size = new Size(967, 627);
            uC_P_UpdateMedicine1.TabIndex = 2;
            uC_P_UpdateMedicine1.Load += uC_P_UpdateMedicine1_Load;
            // 
            // uC_P_ViewMedicine1
            // 
            uC_P_ViewMedicine1.BackColor = Color.White;
            uC_P_ViewMedicine1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            uC_P_ViewMedicine1.Location = new Point(0, 6);
            uC_P_ViewMedicine1.Margin = new Padding(5, 6, 5, 6);
            uC_P_ViewMedicine1.Name = "uC_P_ViewMedicine1";
            uC_P_ViewMedicine1.Size = new Size(967, 600);
            uC_P_ViewMedicine1.TabIndex = 1;
            // 
            // uC_AddMedical1
            // 
            uC_AddMedical1.BackColor = Color.White;
            uC_AddMedical1.Location = new Point(3, 3);
            uC_AddMedical1.Name = "uC_AddMedical1";
            uC_AddMedical1.Size = new Size(925, 580);
            uC_AddMedical1.TabIndex = 0;
            uC_AddMedical1.Load += uC_AddMedical1_Load;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = panel2;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = panel2;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.TargetControl = panel2;
            // 
            // btnLogout
            // 
            btnLogout.CustomizableEdges = customizableEdges1;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(57, 416);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogout.Size = new Size(187, 45);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Đăng Xuất";
            btnLogout.Click += btnLogout_Click;
            // 
            // Pharmacy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1244, 749);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Pharmacy";
            Text = "Pharmacy";
            Load += Pharmacy_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private Label label1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Pharmacist.UC_AddMedical uC_AddMedical1;
        private Guna.UI2.WinForms.Guna2Button btnMedicineView;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Pharmacists.UC_P_ViewMedicine uC_P_ViewMedicine1;
        private Guna.UI2.WinForms.Guna2Button btnUpdateMedicine;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Pharmacists.UC_P_UpdateMedicine uC_P_UpdateMedicine1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}
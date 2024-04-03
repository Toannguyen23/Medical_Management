using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Manage
{
    public partial class Pharmacy : Form
    {
        public Pharmacy()
        {
            InitializeComponent();
        }

        private void Pharmacy_Load(object sender, EventArgs e)
        {
            uC_AddMedical1.Visible = false;
            uC_P_ViewMedicine1.Visible = false;
            uC_P_UpdateMedicine1.Visible = false;
            btnUpdateMedicine.PerformClick();
            btnMedicineView.PerformClick();
            btnAddMedicine.PerformClick();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_AddMedical1.Visible = true;
            uC_AddMedical1.BringToFront();
        }

        private void uC_AddMedical1_Load(object sender, EventArgs e)
        {

        }

        private void btnMedicineView_Click(object sender, EventArgs e)
        {
            uC_P_ViewMedicine1.Visible = true;
            uC_P_ViewMedicine1.BringToFront();

        }

        private void btnUpdateMedicine_Click(object sender, EventArgs e)
        {
            uC_P_UpdateMedicine1.Visible = true;
            uC_P_UpdateMedicine1.BringToFront();
        }

        private void uC_P_UpdateMedicine1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }
    }
}

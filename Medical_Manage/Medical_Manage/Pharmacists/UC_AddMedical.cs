using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Manage.Pharmacist
{
    public partial class UC_AddMedical : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddMedical()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMeid.Text != "" && txtMename.Text != "" && txtMeQuantity.Text != "" && txtSupplies.Text != "" && txtPrice.Text != "")
            {
                String ma_vat_tu = txtMeid.Text;
                String ten_vat_tu = txtMename.Text;
                Int64 so_luong = Int64.Parse(txtMeQuantity.Text);
                String nha_cung_cap = txtSupplies.Text;
                String ngay_sx = txtManudate.Text;
                String ngay_het_han = txtExpiredate.Text;
                Int64 don_gia = Int64.Parse(txtPrice.Text);

                query = "insert into Medicine (ma_vat_tu, ten_vat_tu, so_luong, nha_cung_cap, ngay_sx, ngay_het_han, don_gia) values('" + ma_vat_tu + "',N'" + ten_vat_tu + "','" + so_luong + "',N'" + nha_cung_cap + "','" + ngay_sx + "','" + ngay_het_han + "','" + don_gia + "')";
                fn.setData(query, "Added to data");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập hết dữ liệu ", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            txtMeid.Clear();
            txtMename.Clear();
            txtMeQuantity.Clear();
            txtSupplies.Clear();
            txtPrice.Clear();
            txtExpiredate.ResetText();
            txtManudate.ResetText();
        }

        private void UC_AddMedical_Load(object sender, EventArgs e)
        {

        }
    }
}

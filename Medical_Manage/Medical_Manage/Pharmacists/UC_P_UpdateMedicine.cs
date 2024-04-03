using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Manage.Pharmacists
{
    public partial class UC_P_UpdateMedicine : UserControl

    {
        function fn = new function();
        String query;
        public UC_P_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_P_UpdateMedicine_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMedicalID.Text != "")
            {
                query = "select * from Medicine where ma_vat_tu = '" + txtMedicalID.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMedicalname.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtAvaiMedical.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtSupplies.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtManDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtEpDate.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPrice.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        private void ClearAll()
        {
            txtMedicalname.Clear();
            txtAvaiMedical.Clear();
            txtSupplies.Clear();
            txtManDate.ResetText();
            txtEpDate.ResetText();
            txtPrice.Clear();
            if (txtQuantity.Text != "0")
            {
                txtQuantity.Text = "0";
            }
            else
            {
                txtQuantity.Text = "0";
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        Int64 TotalQuan;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String ten_vat_tu = txtMedicalname.Text;
            Int64 so_luong = Int64.Parse(txtAvaiMedical.Text);
            Int64 addQuan = Int64.Parse(txtQuantity.Text);
            String nha_cung_cap = txtSupplies.Text;
            String ngay_sx = txtManDate.Text;
            String ngay_het_han = txtEpDate.Text;
            Int64 don_gia = Int64.Parse(txtPrice.Text);

            TotalQuan = so_luong + addQuan;

            //thêm thứ tự ma_vat_tu, ten_vat_tu, so_luong, nha_cung_cap, ngay_sx, ngay_het_han, don_gia
            query = "update Medicine set ten_vat_tu = N'" + ten_vat_tu + "', so_luong =" + so_luong + ",nha_cung_cap = N'"+nha_cung_cap+"',ngay_sx = '" + ngay_sx + "', ngay_het_han = '" + ngay_het_han + "',don_gia = '"+don_gia+"' where ma_vat_tu = '"+txtMedicalID.Text+"'  ";
            fn.setData(query, "Cập Nhật Thành Công");
                
                }
    }
}

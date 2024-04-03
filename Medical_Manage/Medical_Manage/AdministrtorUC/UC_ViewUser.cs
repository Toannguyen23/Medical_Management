using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Manage.AdministrtorUC
{
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        String query;
        String curentuser = "";
        public UC_ViewUser()
        {
            InitializeComponent();
        }

        public String ID
        {
            set { curentuser = value; }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from Users";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Users where Username like '" + txtUsername.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        String userName;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {


                if (curentuser != userName)
                {
                    query = "delete from Users where Username = '" + userName + "'";
                    fn.setData(query, "tên người dùng đã xóa!");
                    UC_ViewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Bạn không thể xóa hồ sơ của chính mình.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

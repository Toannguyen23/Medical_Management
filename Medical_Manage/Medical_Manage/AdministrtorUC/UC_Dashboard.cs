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
    public partial class UC_Dashboard : UserControl
    {

        function fn = new function();
        String query;
        DataSet ds;
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from Users where userRole = 'Quản Trị Viên'";
            ds = fn.getData(query);
            setlabel(ds, Adminlabel);
            query = "select count(userRole) from Users where userRole = 'Dược sỹ'";
            ds = fn.getData(query);
            setlabel(ds, Pharlabel);

        }
        private void setlabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void Pharlabel_Click(object sender, EventArgs e)
        {

        }
    }
}

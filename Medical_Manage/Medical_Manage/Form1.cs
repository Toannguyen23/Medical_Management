using System.Data;

namespace Medical_Manage
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            query = "select * from Users";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtUsername.Text == "root" && txtPassword.Text == "root")
                {
                    Admin ad = new Admin();
                    ad.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from Users where Username = '" + txtUsername.Text + "' and pass = '" + txtPassword.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Quản Trị Viên")
                    {
                        Admin ad = new Admin(txtUsername.Text);
                        ad.Show();
                        this.Hide();
                    }
                    else if (role == "Dược sỹ")
                    {
                        Pharmacy pha = new Pharmacy();
                        pha.Show();
                        this.Hide();
                    }
                }
                
                
                   /* MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập vui lòng nhập lại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
               

            }





            /*if (txtUsername.Text == "minhtoan2002" && txtPassword.Text == "123")
            {
                Admin am = new Admin();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập vui lòng nhập lại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp2.DAO;

namespace WindowsFormsApp2
{
    public partial class FAddAccount : Form
    {
        public FAddAccount()
        {
            InitializeComponent();
        }

        private void CoverPassword1_CheckedChanged(object sender, EventArgs e)
        {
            if (CoverPassword1.Checked)
                TBMatKhau1.PasswordChar = '\0';
            else
                TBMatKhau1.PasswordChar = '*';
        }

        private void TBMatKhau1_Enter(object sender, EventArgs e)
        {
            TBMatKhau1.PasswordChar = '*';
        }

        private void CoverPassword2_CheckedChanged(object sender, EventArgs e)
        {
            if (CoverPassword2.Checked)
                TBMatKhau2.PasswordChar = '\0';
            else
                TBMatKhau2.PasswordChar = '*';
        }

        private void TBMatKhau2_Enter(object sender, EventArgs e)
        {
            TBMatKhau2.PasswordChar = '*';
        }

        private void BTXacNhan_Click(object sender, EventArgs e)
        {
            if (TBMatKhau1.Text == TBMatKhau2.Text && TBMatKhau1.Text.Length > 3)
            {
                string connectionSTR = "Data Source=.;Initial Catalog=QuanLy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                SqlConnection connection = new SqlConnection(connectionSTR);
                string query = "Insert into TaiKhoan Values('" + TBTaiKhoan.Text + "','" + TBMatKhau1.Text + "','" + CBMaNV.Text + "')";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Thêm thành công!");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else
                MessageBox.Show("Vui lòng nhập lại mật khẩu!");
        }

        private void FAddAccount_Load(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=.;Initial Catalog=QuanLy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connectionSTR);
            string query = "Select Id from NhanVien";
            connection.Open();
            DataProvider provider = new DataProvider();
            dt = provider.ExecuteQuery(query);
            if (dt.Rows.Count > 0) 
            {
                foreach (DataRow dr in dt.Rows) 
                {
                    CBMaNV.Items.Add(dr[0] + "");
                }
            }
        }
    }
}

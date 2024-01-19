using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.DAO;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class FSignIn : Form
    {
        public FSignIn()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);
        }

        private void TBAccount_Enter(object sender, EventArgs e)
        {
            if (TBAccount.Text == "Vui lòng nhập tài khoản")
            {
                TBAccount.Text = "";
                TBAccount.ForeColor = Color.Black;
            }
        }

        private void TBPassword_Enter(object sender, EventArgs e)
        {
            if (TBPassword.Text == "Vui lòng nhập mật khẩu")
            {
                TBPassword.Text = "";
                TBPassword.ForeColor = Color.Black;
                TBPassword.PasswordChar = '*';
            }
        }

        private void TBAccount_Leave(object sender, EventArgs e)
        {
            if(TBAccount.Text == "")
            {
                TBAccount.Text = "Vui lòng nhập tài khoản";
                TBAccount.ForeColor = Color.DimGray;
            }
        }

        private void TBPassword_Leave(object sender, EventArgs e)
        {
            if(TBPassword.Text == "")
            {
                TBPassword.Text = "Vui lòng nhập mật khẩu";
                TBPassword.ForeColor = Color.DimGray;
                TBPassword.PasswordChar = '\0';
            }
        }

        private void BTExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string LayChucVuNV()
        {
            string ChucVuNV="";
            string taikhoan = TBAccount.Text;
            string matkhau = TBPassword.Text;
            if (Login(taikhoan, matkhau))
            {
                string connectionSTR = "Data Source=.;Initial Catalog=QuanLy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                SqlConnection connection = new SqlConnection(connectionSTR);
                connection.Open();
                string query = "SELECT NhanVien.ChucVu FROM TaiKhoan,NhanVien WHERE TaiKhoan.TaiKhoan = '" + TBAccount.Text + "' AND TaiKhoan.MatKhau = '" + TBPassword.Text + "'And NhanVien.Id=TaiKhoan.MaNV";
                SqlCommand cmd = new SqlCommand(query, connection);
                ChucVuNV = cmd.ExecuteScalar().ToString().Trim();
                connection.Close();
            }
            return ChucVuNV;
        }
        private void BTSignIn_Click(object sender, EventArgs e)
        { 
            string taikhoan = TBAccount.Text;
            string matkhau = TBPassword.Text;
            if(Login(taikhoan,matkhau))
            {
                this.Hide();
                if (LayChucVuNV().ToString() == "Quản lý" || LayChucVuNV().ToString() == "Admin")
                {
                    FQuanLy f = new FQuanLy();
                    f.ShowDialog();
                    Application.Exit();
                }
                if (LayChucVuNV().ToString() == "Thủ kho")
                {
                    FThuKho f = new FThuKho();
                    f.ShowDialog();
                    Application.Exit();
                }
                if (LayChucVuNV().ToString() == "Nhân viên bán hàng")
                {
                    FBanHang f = new FBanHang();
                    f.ShowDialog();
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }
        bool Login(string taikhoan, string matkhau)
        {
            return TaiKhoanDAO.Instance.Login(taikhoan, matkhau);
        }
    }
}

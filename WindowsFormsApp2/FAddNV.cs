using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class FAddNV : Form
    {
        public FAddNV()
        {
            InitializeComponent();
        }

        private void TBLuong_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TBLuong.Text, "[^0-9]") && TBLuong.Text.Length > 0)
            {
                MessageBox.Show("Xin vui lòng chỉ nhập số!");
                TBLuong.Text = TBLuong.Text.Remove(TBLuong.Text.Length - 1);
            }
        }

        private void TBSDT_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TBSDT.Text, "[^0-9]") && TBSDT.Text.Length > 0)
            {
                MessageBox.Show("Xin vui lòng chỉ nhập số!");
                TBSDT.Text = TBSDT.Text.Remove(TBSDT.Text.Length - 1);
            }
        }

        private void BTXacNhan_Click(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=.;Initial Catalog=QuanLy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string query = "Insert into dbo.NhanVien Values('" + TBMaNV.Text + "','" + TBTen.Text + "','" + Date.Value.ToShortDateString() + "','" + CBGioiTinh.Text + "','" + TBDiaChi.Text + "','" + Convert.ToInt32(TBLuong.Text) + "','" + TBEmail.Text + "','" + TBSDT.Text + "','" + CBChucVu.Text + "')";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Thêm thành công!");
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}

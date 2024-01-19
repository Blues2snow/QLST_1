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

namespace WindowsFormsApp2
{
    public partial class FAddHH : Form
    {
        public FAddHH()
        {
            InitializeComponent();
        }

        private void TBGia_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TBGia.Text, "[^0-9]") && TBGia.Text.Length > 0)
            {
                MessageBox.Show("Xin vui lòng chỉ nhập số!");
                TBDonVi.Text = TBGia.Text.Remove(TBGia.Text.Length - 1);
            }
        }

        private void TBSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TBSoLuong.Text, "[^0-9]") && TBSoLuong.Text.Length > 0)
            {
                MessageBox.Show("Xin vui lòng chỉ nhập số!");
                TBSoLuong.Text = TBSoLuong.Text.Remove(TBSoLuong.Text.Length - 1);
            }
        }

        private void BTXacNhan_Click(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=.;Initial Catalog=QuanLy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string query = "Insert into HoaPham Values('" + TBMaHang.Text + "','" + TBTenHang.Text + "','" + TBGia.Text + "','" + TBSoLuong.Text + "','" + TBDonVi.Text + "','" + Date.Value.ToShortDateString() + "','" + TBNCC.Text + "','" + CBLoaiHang.Text + "')";
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.DAO;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class UC_QLAccount : UserControl
    {
        public UC_QLAccount()
        {
            InitializeComponent();
        }
        private void UC_QLAccount_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LBDate.Text = DateTime.Now.ToLongDateString();
            LBTime.Text = DateTime.Now.ToShortTimeString();
            dgvAccount.DataSource = AccountList();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LBTime.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
            dgvAccount.Update();
            dgvAccount.Refresh();
        }

        private void TBSearch_Enter(object sender, EventArgs e)
        {
            if (TBSearch.Text == "Tìm kiếm tên")
                TBSearch.Text = "";
            TBSearch.ForeColor = Color.Black;
        }

        private void TBSearch_Leave(object sender, EventArgs e)
        {
            if (TBSearch.Text == "")
            {
                TBSearch.Text = "Tìm kiếm tên";
                TBSearch.ForeColor = Color.DimGray;
            }
        }
        DataTable AccountList()
        {
            String query = "select TaiKhoan.TaiKhoan, NhanVien.TenNV, NhanVien.ChucVu  from TaiKhoan, NhanVien where TaiKhoan.MaNV=NhanVien.Id";
            DataProvider provider = new DataProvider();
            return provider.ExecuteQuery(query);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            FAddAccount f = new FAddAccount();
            f.ShowDialog();
        }
        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionSTR = "Data Source=.;Initial Catalog=QuanLy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            if (e.ColumnIndex == dgvAccount.Columns[4].Index)
            {
                string query = "DELETE FROM NhanVien WHERE Id='" + dgvAccount.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Xoá thành công!");
                dgvAccount.Rows.RemoveAt(e.RowIndex);
            }
        }
}

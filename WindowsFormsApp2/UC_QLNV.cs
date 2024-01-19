using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using WindowsFormsApp2.DAO;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class UC_QLNV : UserControl
    {
        public UC_QLNV()
        {
            InitializeComponent();
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
        }
        private void UC_QLNV_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LBDate.Text = DateTime.Now.ToLongDateString();
            LBTime.Text = DateTime.Now.ToShortTimeString();
            dgvNhanVien.DataSource = NhanVienList();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LBTime.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
            dgvNhanVien.Update();
            dgvNhanVien.Refresh();
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
        DataTable NhanVienList()
        {
            String query = "select * from NhanVien";
            DataProvider provider = new DataProvider();
            return provider.ExecuteQuery(query);
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionSTR = "Data Source=.;Initial Catalog=QuanLy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            if (e.ColumnIndex == dgvNhanVien.Columns[9].Index)
            {
                string query = "UPDATE NhanVien SET TenNV = '" + dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString() + "', DiaChi ='" + dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString() + "',Luong = '" + dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString() + "',Email = '" + dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString() + "',SDT = '" + dgvNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString() + "'where Id = '" + dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sửa thành công!");
            }
            if(e.ColumnIndex == dgvNhanVien.Columns[10].Index)
            {
                string query = "DELETE FROM NhanVien WHERE Id='" + dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Xoá thành công!");
                dgvNhanVien.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            FAddNV f = new FAddNV();
            f.ShowDialog();
        }
    }
}

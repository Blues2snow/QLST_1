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
    public partial class UC_QLHH : UserControl
    {
        public UC_QLHH()
        {
            InitializeComponent();

        }
        private void UC_QLHH_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LBDate.Text = DateTime.Now.ToLongDateString();
            LBTime.Text = DateTime.Now.ToShortTimeString();
            dgvHangHoa.DataSource = HangHoaList();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LBTime.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
            dgvHangHoa.Update();
            dgvHangHoa.Refresh();
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
        DataTable HangHoaList()
        {
            String query = "select * from HoaPham";
            DataProvider provider = new DataProvider();
            return provider.ExecuteQuery(query);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            FAddHH f = new FAddHH();
            f.ShowDialog();
        }
        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionSTR = "Data Source=.;Initial Catalog=QuanLy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            if (e.ColumnIndex == dgvHangHoa.Columns[9].Index)
            {
                string query = "UPDATE HoaPham SET GiaTien = '" + dgvHangHoa.Rows[e.RowIndex].Cells[2].Value.ToString() + "', SoLuong ='" + dgvHangHoa.Rows[e.RowIndex].Cells[3].Value.ToString() + "'where Id = '" + dgvHangHoa.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sửa thành công!");
            }
            if (e.ColumnIndex == dgvHangHoa.Columns[10].Index)
            {
                string query = "DELETE FROM NhanVien WHERE Id='" + dgvHangHoa.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Xoá thành công!");
                dgvHangHoa.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}

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
using System.DirectoryServices;

namespace WindowsFormsApp2
{
    public partial class UC_BanHang : UserControl
    {
        public UC_BanHang()
        {
            InitializeComponent();
            dgvBill.CellClick += dgvBill_CellClick;
        }
        private void UC_BanHang_Load(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=.;Initial Catalog=QuanLy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
             SqlConnection connection = new SqlConnection(connectionSTR);
            SqlCommand cmd = new SqlCommand("Select TenHang from HoaPham", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                collection.Add(dr.GetString(0));
            }
            TBSearch.AutoCompleteCustomSource = collection;
            connection.Close();
            connection.Open();
            int count = 0;
            cmd = new SqlCommand("select count(*) from HoaDon", connection);
            if (cmd.ExecuteScalar() == null)
                count = 1;
            else
                count = (int)cmd.ExecuteScalar();
            connection.Close();
            TBDate.Text = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
            TBMaHD.Text = "HD" + count.ToString();
        }
        private void TBSearch_Enter(object sender, EventArgs e)
        {
            if (TBSearch.Text == "Tìm kiếm tên")
                TBSearch.Text = "";
            TBSearch.ForeColor = Color.Black;
        }

        private void TBSearch_Leave(object sender, EventArgs e)
        {
            bool find=true;
            double a, b;
            if (TBSearch.Text == "")
            {
                TBSearch.Text = "Tìm kiếm tên";
                TBSearch.ForeColor = Color.DimGray;
            }
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvBill);
            string connectionSTR = "Data Source=.;Initial Catalog=QuanLy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            SqlCommand cmd = new SqlCommand("Select * from HoaPham where TenHang ='"+ TBSearch.Text +"'", connection);
            connection.Open ();
            SqlDataReader dr = cmd.ExecuteReader();
            for(int i = 0; i < dgvBill.Rows.Count; i++)
            {
                if (dgvBill.Rows[i].Cells[1].Value != null && TBSearch.Text == dgvBill.Rows[i].Cells[1].Value.ToString()) 
                {
                    dgvBill.Rows[i].Cells[2].Value = (int)dgvBill.Rows[i].Cells[2].Value + 1;
                    find = false;
                    break;
                }
            }
            if (find)
            {
                while (dr.Read())
                {
                    row.Cells[0].Value = dr["Id"].ToString();
                    row.Cells[1].Value = dr["TenHang"].ToString();
                    row.Cells[2].Value = 1;
                    row.Cells[3].Value = dr["DonViTinh"].ToString();
                    row.Cells[4].Value = dr["LoaiHang"].ToString();
                    row.Cells[5].Value = dr["GiaTien"].ToString();
                    a = Convert.ToDouble(row.Cells[2].Value.ToString());
                    b = Convert.ToDouble(row.Cells[5].Value.ToString());
                    row.Cells[6].Value = (a*b).ToString();
                    dgvBill.Rows.Add(row);
                }
            } 
        }
        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvBill.Columns[7].Index)
            {
                dgvBill.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvBill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            double a, b;
            double sum = 0;
            for (int i = 0; i < dgvBill.Rows.Count; i++)
            {
                a = Convert.ToDouble(dgvBill.Rows[i].Cells[2].Value.ToString());
                b = Convert.ToDouble(dgvBill.Rows[i].Cells[5].Value.ToString());
                dgvBill.Rows[i].Cells[6].Value = (a * b).ToString();
                sum += Convert.ToDouble(dgvBill.Rows[i].Cells[6].Value.ToString());
            }
            TongTien.Text = sum.ToString();
            a = Convert.ToDouble(Fee.Text);
            b = Convert.ToDouble(Discount.Text);
            double c = Convert.ToDouble(TongTien.Text);
            TienTra.Text = (c - b + a).ToString();
        }

        private void Discount_TextChanged(object sender, EventArgs e)
        {
            if (Discount.Text.Length > 0)
            {
                double a = Convert.ToDouble(Fee.Text);
                double b = Convert.ToDouble(Discount.Text);
                double c = Convert.ToDouble(TongTien.Text);
                TienTra.Text = (c- b + a).ToString();
            }
        }

        private void Fee_TextChanged(object sender, EventArgs e)
        {
            if (Fee.Text.Length > 0)
            {
                double a = Convert.ToDouble(Fee.Text);
                double b = Convert.ToDouble(Discount.Text);
                double c = Convert.ToDouble(TongTien.Text);
                TienTra.Text = (c - b + a).ToString();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Siêu thị minh cầu", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID: " + TBMaHD.Text, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Red, new Point(100, 70));

            e.Graphics.DrawString("Nhân viên: " + TBTenNV.Text, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Red, new Point(100, 100));

            e.Graphics.DrawString("Ngày: " + TBDate.Text, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Red, new Point(100, 130));
            e.Graphics.DrawString("Tổng tiền: " + TienTra.Text, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Red, new Point(100, 160));
            e.Graphics.DrawString("Cảm ơn quý khách", new Font("Century Gothic", 25, FontStyle.Italic), Brushes.Red, new Point(230, 230));
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=.;Initial Catalog=QuanLy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string query;
            connection.Open();
            query = "insert into HoaDon values('" + TBMaHD.Text + "','" + TBTenNV.Text + "','" + TBDate.Text +"','"+TienTra.Text +"')"; 
            SqlCommand cmd = new SqlCommand(query,connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thanh toán thành công!");
            connection.Close();
            printDocument1.Print();
        }
    }
}

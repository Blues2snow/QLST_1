using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FQuanLy : Form
    {
        public FQuanLy()
        {
            InitializeComponent();
        }

        private void FQuanLy_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);
        }

        private void SiticoneButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton1.Checked) uC_QLNV1.BringToFront();
        }
        private void SiticoneButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton2.Checked) uC_QLAccount1.BringToFront();
        }
        private void SiticoneButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton3.Checked) uC_QLHH1.BringToFront();
        }

        private void SiticoneButton5_CheckedChanged(object sender, EventArgs e)
        {
           if (siticoneButton5.Checked) uC_Account1.BringToFront();
        }

        private void FQuanLy_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uC_BanHang1_Load(object sender, EventArgs e)
        {

        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignIn f = new FSignIn();
            f.ShowDialog();
        }
    }
}

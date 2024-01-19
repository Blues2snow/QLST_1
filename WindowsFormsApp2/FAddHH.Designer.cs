namespace WindowsFormsApp2
{
    partial class FAddHH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Date = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.CBLoaiHang = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.TBTenHang = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TBSoLuong = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TBDonVi = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TBNCC = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TBMaHang = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBTenNV = new System.Windows.Forms.Label();
            this.TBGia = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.BTXacNhan = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.Animated = true;
            this.Date.Checked = true;
            this.Date.FillColor = System.Drawing.Color.White;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(203, 218);
            this.Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(257, 36);
            this.Date.TabIndex = 36;
            this.Date.Value = new System.DateTime(2024, 1, 18, 0, 0, 0, 0);
            // 
            // CBLoaiHang
            // 
            this.CBLoaiHang.BackColor = System.Drawing.Color.Transparent;
            this.CBLoaiHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBLoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLoaiHang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBLoaiHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBLoaiHang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CBLoaiHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBLoaiHang.ItemHeight = 30;
            this.CBLoaiHang.Items.AddRange(new object[] {
            "Hoá phẩm",
            "Thực phẩm"});
            this.CBLoaiHang.Location = new System.Drawing.Point(680, 301);
            this.CBLoaiHang.Name = "CBLoaiHang";
            this.CBLoaiHang.Size = new System.Drawing.Size(257, 36);
            this.CBLoaiHang.TabIndex = 34;
            // 
            // TBTenHang
            // 
            this.TBTenHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBTenHang.DefaultText = "";
            this.TBTenHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBTenHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBTenHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBTenHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBTenHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBTenHang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TBTenHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBTenHang.Location = new System.Drawing.Point(203, 139);
            this.TBTenHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBTenHang.Name = "TBTenHang";
            this.TBTenHang.PasswordChar = '\0';
            this.TBTenHang.PlaceholderText = "";
            this.TBTenHang.SelectedText = "";
            this.TBTenHang.Size = new System.Drawing.Size(257, 37);
            this.TBTenHang.TabIndex = 33;
            // 
            // TBSoLuong
            // 
            this.TBSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBSoLuong.DefaultText = "";
            this.TBSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBSoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBSoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBSoLuong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TBSoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBSoLuong.Location = new System.Drawing.Point(680, 68);
            this.TBSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBSoLuong.Name = "TBSoLuong";
            this.TBSoLuong.PasswordChar = '\0';
            this.TBSoLuong.PlaceholderText = "";
            this.TBSoLuong.SelectedText = "";
            this.TBSoLuong.Size = new System.Drawing.Size(257, 36);
            this.TBSoLuong.TabIndex = 32;
            this.TBSoLuong.TextChanged += new System.EventHandler(this.TBSoLuong_TextChanged);
            // 
            // TBDonVi
            // 
            this.TBDonVi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBDonVi.DefaultText = "";
            this.TBDonVi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBDonVi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBDonVi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBDonVi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBDonVi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBDonVi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TBDonVi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBDonVi.Location = new System.Drawing.Point(680, 140);
            this.TBDonVi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBDonVi.Name = "TBDonVi";
            this.TBDonVi.PasswordChar = '\0';
            this.TBDonVi.PlaceholderText = "";
            this.TBDonVi.SelectedText = "";
            this.TBDonVi.Size = new System.Drawing.Size(257, 36);
            this.TBDonVi.TabIndex = 31;
            // 
            // TBNCC
            // 
            this.TBNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBNCC.DefaultText = "";
            this.TBNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBNCC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TBNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBNCC.Location = new System.Drawing.Point(680, 217);
            this.TBNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBNCC.Name = "TBNCC";
            this.TBNCC.PasswordChar = '\0';
            this.TBNCC.PlaceholderText = "";
            this.TBNCC.SelectedText = "";
            this.TBNCC.Size = new System.Drawing.Size(257, 37);
            this.TBNCC.TabIndex = 30;
            // 
            // TBMaHang
            // 
            this.TBMaHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBMaHang.DefaultText = "";
            this.TBMaHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBMaHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBMaHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBMaHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBMaHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBMaHang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TBMaHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBMaHang.Location = new System.Drawing.Point(203, 68);
            this.TBMaHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBMaHang.Name = "TBMaHang";
            this.TBMaHang.PasswordChar = '\0';
            this.TBMaHang.PlaceholderText = "";
            this.TBMaHang.SelectedText = "";
            this.TBMaHang.Size = new System.Drawing.Size(257, 36);
            this.TBMaHang.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(519, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 28);
            this.label9.TabIndex = 27;
            this.label9.Text = "Loại hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(519, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 28);
            this.label7.TabIndex = 25;
            this.label7.Text = "Nhà cung cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(519, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = "Đơn vị tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(519, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(57, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Giá tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(57, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ngày nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(56, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã hàng";
            // 
            // TBTenNV
            // 
            this.TBTenNV.AutoSize = true;
            this.TBTenNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TBTenNV.Location = new System.Drawing.Point(56, 148);
            this.TBTenNV.Name = "TBTenNV";
            this.TBTenNV.Size = new System.Drawing.Size(90, 28);
            this.TBTenNV.TabIndex = 19;
            this.TBTenNV.Text = "Tên hàng";
            // 
            // TBGia
            // 
            this.TBGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBGia.DefaultText = "";
            this.TBGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBGia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TBGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBGia.Location = new System.Drawing.Point(203, 309);
            this.TBGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBGia.Name = "TBGia";
            this.TBGia.PasswordChar = '\0';
            this.TBGia.PlaceholderText = "";
            this.TBGia.SelectedText = "";
            this.TBGia.Size = new System.Drawing.Size(257, 37);
            this.TBGia.TabIndex = 38;
            this.TBGia.TextChanged += new System.EventHandler(this.TBGia_TextChanged);
            // 
            // BTXacNhan
            // 
            this.BTXacNhan.Animated = true;
            this.BTXacNhan.AutoRoundedCorners = true;
            this.BTXacNhan.BorderRadius = 24;
            this.BTXacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTXacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTXacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTXacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTXacNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTXacNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BTXacNhan.ForeColor = System.Drawing.Color.White;
            this.BTXacNhan.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.BTXacNhan.Location = new System.Drawing.Point(659, 397);
            this.BTXacNhan.Name = "BTXacNhan";
            this.BTXacNhan.Size = new System.Drawing.Size(223, 50);
            this.BTXacNhan.TabIndex = 37;
            this.BTXacNhan.Text = "Xác nhận";
            this.BTXacNhan.Click += new System.EventHandler(this.BTXacNhan_Click);
            // 
            // FAddHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 525);
            this.Controls.Add(this.TBGia);
            this.Controls.Add(this.BTXacNhan);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.CBLoaiHang);
            this.Controls.Add(this.TBTenHang);
            this.Controls.Add(this.TBSoLuong);
            this.Controls.Add(this.TBDonVi);
            this.Controls.Add(this.TBNCC);
            this.Controls.Add(this.TBMaHang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBTenNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FAddHH";
            this.Text = "FAddHH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker Date;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox CBLoaiHang;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TBTenHang;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TBSoLuong;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TBDonVi;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TBNCC;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TBMaHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TBTenNV;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TBGia;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BTXacNhan;
    }
}
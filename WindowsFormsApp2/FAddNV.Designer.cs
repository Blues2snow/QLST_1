namespace WindowsFormsApp2
{
    partial class FAddNV
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
            this.TBTenNV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TBMaNV = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TBSDT = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TBEmail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TBLuong = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TBDiaChi = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TBTen = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.CBChucVu = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.CBGioiTinh = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.Date = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.BTXacNhan = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // TBTenNV
            // 
            this.TBTenNV.AutoSize = true;
            this.TBTenNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TBTenNV.Location = new System.Drawing.Point(35, 155);
            this.TBTenNV.Name = "TBTenNV";
            this.TBTenNV.Size = new System.Drawing.Size(130, 28);
            this.TBTenNV.TabIndex = 0;
            this.TBTenNV.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(36, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(36, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(36, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(505, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lương";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(505, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(505, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "SDT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(505, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "Chức vụ";
            // 
            // TBMaNV
            // 
            this.TBMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBMaNV.DefaultText = "";
            this.TBMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBMaNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TBMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBMaNV.Location = new System.Drawing.Point(207, 75);
            this.TBMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBMaNV.Name = "TBMaNV";
            this.TBMaNV.PasswordChar = '\0';
            this.TBMaNV.PlaceholderText = "";
            this.TBMaNV.SelectedText = "";
            this.TBMaNV.Size = new System.Drawing.Size(257, 36);
            this.TBMaNV.TabIndex = 9;
            // 
            // TBSDT
            // 
            this.TBSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBSDT.DefaultText = "";
            this.TBSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBSDT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TBSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBSDT.Location = new System.Drawing.Point(638, 225);
            this.TBSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBSDT.Name = "TBSDT";
            this.TBSDT.PasswordChar = '\0';
            this.TBSDT.PlaceholderText = "";
            this.TBSDT.SelectedText = "";
            this.TBSDT.Size = new System.Drawing.Size(257, 36);
            this.TBSDT.TabIndex = 10;
            this.TBSDT.TextChanged += new System.EventHandler(this.TBSDT_TextChanged);
            // 
            // TBEmail
            // 
            this.TBEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBEmail.DefaultText = "";
            this.TBEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TBEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBEmail.Location = new System.Drawing.Point(638, 146);
            this.TBEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.PasswordChar = '\0';
            this.TBEmail.PlaceholderText = "";
            this.TBEmail.SelectedText = "";
            this.TBEmail.Size = new System.Drawing.Size(257, 37);
            this.TBEmail.TabIndex = 11;
            // 
            // TBLuong
            // 
            this.TBLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBLuong.DefaultText = "";
            this.TBLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBLuong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TBLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBLuong.Location = new System.Drawing.Point(638, 75);
            this.TBLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBLuong.Name = "TBLuong";
            this.TBLuong.PasswordChar = '\0';
            this.TBLuong.PlaceholderText = "";
            this.TBLuong.SelectedText = "";
            this.TBLuong.Size = new System.Drawing.Size(257, 36);
            this.TBLuong.TabIndex = 12;
            this.TBLuong.TextChanged += new System.EventHandler(this.TBLuong_TextChanged);
            // 
            // TBDiaChi
            // 
            this.TBDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBDiaChi.DefaultText = "";
            this.TBDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TBDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBDiaChi.Location = new System.Drawing.Point(207, 396);
            this.TBDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBDiaChi.Name = "TBDiaChi";
            this.TBDiaChi.PasswordChar = '\0';
            this.TBDiaChi.PlaceholderText = "";
            this.TBDiaChi.SelectedText = "";
            this.TBDiaChi.Size = new System.Drawing.Size(257, 36);
            this.TBDiaChi.TabIndex = 13;
            // 
            // TBTen
            // 
            this.TBTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBTen.DefaultText = "";
            this.TBTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBTen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TBTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBTen.Location = new System.Drawing.Point(207, 146);
            this.TBTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBTen.Name = "TBTen";
            this.TBTen.PasswordChar = '\0';
            this.TBTen.PlaceholderText = "";
            this.TBTen.SelectedText = "";
            this.TBTen.Size = new System.Drawing.Size(257, 37);
            this.TBTen.TabIndex = 14;
            // 
            // CBChucVu
            // 
            this.CBChucVu.BackColor = System.Drawing.Color.Transparent;
            this.CBChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBChucVu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBChucVu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CBChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBChucVu.ItemHeight = 30;
            this.CBChucVu.Items.AddRange(new object[] {
            "Quản lý",
            "Thủ kho",
            "Nhân viên bán hàng"});
            this.CBChucVu.Location = new System.Drawing.Point(638, 308);
            this.CBChucVu.Name = "CBChucVu";
            this.CBChucVu.Size = new System.Drawing.Size(257, 36);
            this.CBChucVu.TabIndex = 15;
            // 
            // CBGioiTinh
            // 
            this.CBGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.CBGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CBGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBGioiTinh.ItemHeight = 30;
            this.CBGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.CBGioiTinh.Location = new System.Drawing.Point(207, 308);
            this.CBGioiTinh.Name = "CBGioiTinh";
            this.CBGioiTinh.Size = new System.Drawing.Size(257, 36);
            this.CBGioiTinh.TabIndex = 16;
            // 
            // Date
            // 
            this.Date.Animated = true;
            this.Date.Checked = true;
            this.Date.FillColor = System.Drawing.Color.White;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(207, 225);
            this.Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(257, 36);
            this.Date.TabIndex = 17;
            this.Date.Value = new System.DateTime(2024, 1, 18, 0, 0, 0, 0);
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
            this.BTXacNhan.Location = new System.Drawing.Point(638, 414);
            this.BTXacNhan.Name = "BTXacNhan";
            this.BTXacNhan.Size = new System.Drawing.Size(223, 50);
            this.BTXacNhan.TabIndex = 18;
            this.BTXacNhan.Text = "Xác nhận";
            this.BTXacNhan.Click += new System.EventHandler(this.BTXacNhan_Click);
            // 
            // FAddNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 525);
            this.Controls.Add(this.BTXacNhan);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.CBGioiTinh);
            this.Controls.Add(this.CBChucVu);
            this.Controls.Add(this.TBTen);
            this.Controls.Add(this.TBDiaChi);
            this.Controls.Add(this.TBLuong);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBSDT);
            this.Controls.Add(this.TBMaNV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBTenNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FAddNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TBTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TBMaNV;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TBSDT;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TBEmail;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TBLuong;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TBDiaChi;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TBTen;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox CBChucVu;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox CBGioiTinh;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker Date;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BTXacNhan;
    }
}
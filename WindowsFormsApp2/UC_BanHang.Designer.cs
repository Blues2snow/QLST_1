namespace WindowsFormsApp2
{
    partial class UC_BanHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BanHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.TBTenNV = new System.Windows.Forms.Label();
            this.TBDate = new System.Windows.Forms.Label();
            this.TBSearch = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.TBMaHD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Fee = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.Discount = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TienTra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TongTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hoaPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbHH = new WindowsFormsApp2.dbHH();
            this.hoaPhamTableAdapter = new WindowsFormsApp2.dbHHTableAdapters.HoaPhamTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvBill = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucNang = new System.Windows.Forms.DataGridViewImageColumn();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.siticonePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.siticonePanel1.Controls.Add(this.TBTenNV);
            this.siticonePanel1.Controls.Add(this.TBDate);
            this.siticonePanel1.Controls.Add(this.TBSearch);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(880, 97);
            this.siticonePanel1.TabIndex = 0;
            // 
            // TBTenNV
            // 
            this.TBTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBTenNV.AutoSize = true;
            this.TBTenNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBTenNV.Location = new System.Drawing.Point(664, 50);
            this.TBTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TBTenNV.Name = "TBTenNV";
            this.TBTenNV.Size = new System.Drawing.Size(70, 15);
            this.TBTenNV.TabIndex = 35;
            this.TBTenNV.Text = "Vũ Đình Đạt";
            // 
            // TBDate
            // 
            this.TBDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBDate.AutoSize = true;
            this.TBDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBDate.Location = new System.Drawing.Point(664, 20);
            this.TBDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TBDate.Name = "TBDate";
            this.TBDate.Size = new System.Drawing.Size(38, 15);
            this.TBDate.TabIndex = 34;
            this.TBDate.Text = "label2";
            // 
            // TBSearch
            // 
            this.TBSearch.Animated = true;
            this.TBSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TBSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TBSearch.AutoRoundedCorners = true;
            this.TBSearch.BorderColor = System.Drawing.Color.Black;
            this.TBSearch.BorderRadius = 17;
            this.TBSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBSearch.DefaultText = "Tìm kiếm tên";
            this.TBSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TBSearch.ForeColor = System.Drawing.Color.DimGray;
            this.TBSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("TBSearch.IconLeft")));
            this.TBSearch.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.TBSearch.Location = new System.Drawing.Point(28, 30);
            this.TBSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.PasswordChar = '\0';
            this.TBSearch.PlaceholderText = "";
            this.TBSearch.SelectedText = "";
            this.TBSearch.Size = new System.Drawing.Size(338, 36);
            this.TBSearch.TabIndex = 33;
            this.TBSearch.Enter += new System.EventHandler(this.TBSearch_Enter);
            this.TBSearch.Leave += new System.EventHandler(this.TBSearch_Leave);
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BackColor = System.Drawing.Color.White;
            this.siticonePanel2.Controls.Add(this.TBMaHD);
            this.siticonePanel2.Controls.Add(this.label2);
            this.siticonePanel2.Controls.Add(this.siticoneButton1);
            this.siticonePanel2.Controls.Add(this.Fee);
            this.siticonePanel2.Controls.Add(this.Discount);
            this.siticonePanel2.Controls.Add(this.label9);
            this.siticonePanel2.Controls.Add(this.label8);
            this.siticonePanel2.Controls.Add(this.TienTra);
            this.siticonePanel2.Controls.Add(this.label3);
            this.siticonePanel2.Controls.Add(this.TongTien);
            this.siticonePanel2.Controls.Add(this.label1);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticonePanel2.Location = new System.Drawing.Point(606, 97);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(274, 590);
            this.siticonePanel2.TabIndex = 1;
            // 
            // TBMaHD
            // 
            this.TBMaHD.AutoSize = true;
            this.TBMaHD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TBMaHD.Location = new System.Drawing.Point(158, 37);
            this.TBMaHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TBMaHD.Name = "TBMaHD";
            this.TBMaHD.Size = new System.Drawing.Size(52, 21);
            this.TBMaHD.TabIndex = 13;
            this.TBMaHD.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(24, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã hoá đơn:";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneButton1.Animated = true;
            this.siticoneButton1.BorderRadius = 12;
            this.siticoneButton1.BorderThickness = 1;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneButton1.Location = new System.Drawing.Point(34, 499);
            this.siticoneButton1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(178, 46);
            this.siticoneButton1.TabIndex = 11;
            this.siticoneButton1.Text = "Thanh toán";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // Fee
            // 
            this.Fee.BackColor = System.Drawing.Color.LightGray;
            this.Fee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Fee.DefaultText = "0";
            this.Fee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Fee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Fee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Fee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Fee.FillColor = System.Drawing.Color.LightGray;
            this.Fee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Fee.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Fee.ForeColor = System.Drawing.Color.Black;
            this.Fee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Fee.Location = new System.Drawing.Point(162, 225);
            this.Fee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fee.Name = "Fee";
            this.Fee.PasswordChar = '\0';
            this.Fee.PlaceholderText = "";
            this.Fee.SelectedText = "";
            this.Fee.Size = new System.Drawing.Size(96, 18);
            this.Fee.TabIndex = 10;
            this.Fee.TextChanged += new System.EventHandler(this.Fee_TextChanged);
            // 
            // Discount
            // 
            this.Discount.BackColor = System.Drawing.Color.LightGray;
            this.Discount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Discount.DefaultText = "0";
            this.Discount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Discount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Discount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Discount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Discount.FillColor = System.Drawing.Color.LightGray;
            this.Discount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Discount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Discount.ForeColor = System.Drawing.Color.Black;
            this.Discount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Discount.Location = new System.Drawing.Point(162, 163);
            this.Discount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Discount.Name = "Discount";
            this.Discount.PasswordChar = '\0';
            this.Discount.PlaceholderText = "";
            this.Discount.SelectedText = "";
            this.Discount.Size = new System.Drawing.Size(96, 18);
            this.Discount.TabIndex = 9;
            this.Discount.TextChanged += new System.EventHandler(this.Discount_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(24, 220);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phí:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(24, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Khách cần trả:";
            // 
            // TienTra
            // 
            this.TienTra.AutoSize = true;
            this.TienTra.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TienTra.Location = new System.Drawing.Point(158, 279);
            this.TienTra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TienTra.Name = "TienTra";
            this.TienTra.Size = new System.Drawing.Size(19, 21);
            this.TienTra.TabIndex = 3;
            this.TienTra.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(24, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giảm giá:";
            // 
            // TongTien
            // 
            this.TongTien.AutoSize = true;
            this.TongTien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TongTien.Location = new System.Drawing.Point(158, 95);
            this.TongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TongTien.Name = "TongTien";
            this.TongTien.Size = new System.Drawing.Size(19, 21);
            this.TongTien.TabIndex = 1;
            this.TongTien.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(24, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền hàng:";
            // 
            // hoaPhamBindingSource
            // 
            this.hoaPhamBindingSource.DataMember = "HoaPham";
            this.hoaPhamBindingSource.DataSource = this.dbHH;
            // 
            // dbHH
            // 
            this.dbHH.DataSetName = "dbHH";
            this.dbHH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaPhamTableAdapter
            // 
            this.hoaPhamTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 20F;
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::WindowsFormsApp2.Properties.Resources.x;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Xoá";
            this.dataGridViewImageColumn1.Width = 46;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBill.ColumnHeadersHeight = 28;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.soLuongDataGridViewTextBoxColumn,
            this.DonViTinh,
            this.LoaiHang,
            this.GiaTien,
            this.GiaTong,
            this.ChucNang});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBill.Location = new System.Drawing.Point(6, 101);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 100;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(596, 584);
            this.dgvBill.TabIndex = 0;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBill.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBill.ThemeStyle.HeaderStyle.Height = 28;
            this.dgvBill.ThemeStyle.ReadOnly = false;
            this.dgvBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBill.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBill.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBill_CellFormatting);
            // 
            // MaHang
            // 
            this.MaHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaHang.FillWeight = 37.86354F;
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            this.MaHang.Width = 50;
            // 
            // TenHang
            // 
            this.TenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenHang.FillWeight = 42.8573F;
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            this.TenHang.Width = 98;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.soLuongDataGridViewTextBoxColumn.FillWeight = 42.8573F;
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.Width = 50;
            // 
            // DonViTinh
            // 
            this.DonViTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DonViTinh.FillWeight = 42.8573F;
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            this.DonViTinh.Width = 98;
            // 
            // LoaiHang
            // 
            this.LoaiHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LoaiHang.FillWeight = 42.8573F;
            this.LoaiHang.HeaderText = "Loại hàng";
            this.LoaiHang.MinimumWidth = 6;
            this.LoaiHang.Name = "LoaiHang";
            this.LoaiHang.ReadOnly = true;
            this.LoaiHang.Width = 99;
            // 
            // GiaTien
            // 
            this.GiaTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GiaTien.FillWeight = 42.8573F;
            this.GiaTien.HeaderText = "Giá sản phẩm";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.Width = 98;
            // 
            // GiaTong
            // 
            this.GiaTong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GiaTong.FillWeight = 42.8573F;
            this.GiaTong.HeaderText = "Giá tổng";
            this.GiaTong.MinimumWidth = 6;
            this.GiaTong.Name = "GiaTong";
            this.GiaTong.Width = 50;
            // 
            // ChucNang
            // 
            this.ChucNang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ChucNang.FillWeight = 20F;
            this.ChucNang.HeaderText = "";
            this.ChucNang.Image = global::WindowsFormsApp2.Properties.Resources.delete;
            this.ChucNang.MinimumWidth = 6;
            this.ChucNang.Name = "ChucNang";
            this.ChucNang.ReadOnly = true;
            this.ChucNang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ChucNang.ToolTipText = "Xoá";
            this.ChucNang.Width = 46;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.dgvBill);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel3.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(880, 687);
            this.siticonePanel3.TabIndex = 2;
            // 
            // UC_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.siticonePanel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_BanHang";
            this.Size = new System.Drawing.Size(880, 687);
            this.Load += new System.EventHandler(this.UC_BanHang_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.siticonePanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TBSearch;
        private System.Windows.Forms.Label TongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TienTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource hoaPhamBindingSource;
        private dbHH dbHH;
        private dbHHTableAdapters.HoaPhamTableAdapter hoaPhamTableAdapter;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Fee;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Discount;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label TBTenNV;
        private System.Windows.Forms.Label TBDate;
        private System.Windows.Forms.Label TBMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTong;
        private System.Windows.Forms.DataGridViewImageColumn ChucNang;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
    }
}

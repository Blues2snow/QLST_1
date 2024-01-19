namespace WindowsFormsApp2
{
    partial class FBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBanHang));
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneButton6 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton5 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.uC_BanHang1 = new WindowsFormsApp2.UC_BanHang();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.White;
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Controls.Add(this.siticoneButton6);
            this.siticonePanel1.Controls.Add(this.siticoneButton5);
            this.siticonePanel1.Controls.Add(this.siticoneButton1);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(226, 687);
            this.siticonePanel1.TabIndex = 3;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.minhcau42;
            this.siticonePanel2.Location = new System.Drawing.Point(12, 27);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(200, 100);
            this.siticonePanel2.TabIndex = 8;
            // 
            // siticoneButton6
            // 
            this.siticoneButton6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneButton6.Animated = true;
            this.siticoneButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.siticoneButton6.BorderRadius = 15;
            this.siticoneButton6.BorderThickness = 1;
            this.siticoneButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton6.FillColor = System.Drawing.Color.White;
            this.siticoneButton6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.siticoneButton6.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton6.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.siticoneButton6.HoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton6.Location = new System.Drawing.Point(44, 576);
            this.siticoneButton6.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneButton6.Name = "siticoneButton6";
            this.siticoneButton6.Size = new System.Drawing.Size(130, 54);
            this.siticoneButton6.TabIndex = 3;
            this.siticoneButton6.Text = "Đăng xuất";
            this.siticoneButton6.Click += new System.EventHandler(this.siticoneButton6_Click);
            // 
            // siticoneButton5
            // 
            this.siticoneButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneButton5.Animated = true;
            this.siticoneButton5.BorderColor = System.Drawing.Color.White;
            this.siticoneButton5.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton5.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.siticoneButton5.CheckedState.FillColor = System.Drawing.Color.White;
            this.siticoneButton5.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.siticoneButton5.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.siticoneButton5.CustomBorderThickness = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.siticoneButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton5.FillColor = System.Drawing.Color.White;
            this.siticoneButton5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneButton5.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton5.Image = ((System.Drawing.Image)(resources.GetObject("siticoneButton5.Image")));
            this.siticoneButton5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton5.ImageOffset = new System.Drawing.Point(15, 0);
            this.siticoneButton5.ImageSize = new System.Drawing.Size(25, 25);
            this.siticoneButton5.Location = new System.Drawing.Point(0, 215);
            this.siticoneButton5.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneButton5.Name = "siticoneButton5";
            this.siticoneButton5.PressedDepth = 0;
            this.siticoneButton5.Size = new System.Drawing.Size(226, 50);
            this.siticoneButton5.TabIndex = 7;
            this.siticoneButton5.Text = "Tài khoản";
            this.siticoneButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton5.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneButton1.Animated = true;
            this.siticoneButton1.BorderColor = System.Drawing.Color.White;
            this.siticoneButton1.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton1.Checked = true;
            this.siticoneButton1.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.siticoneButton1.CheckedState.FillColor = System.Drawing.Color.White;
            this.siticoneButton1.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.siticoneButton1.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.siticoneButton1.CustomBorderThickness = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.White;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneButton1.Image")));
            this.siticoneButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton1.ImageOffset = new System.Drawing.Point(15, 0);
            this.siticoneButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.siticoneButton1.Location = new System.Drawing.Point(0, 162);
            this.siticoneButton1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.PressedDepth = 0;
            this.siticoneButton1.Size = new System.Drawing.Size(226, 50);
            this.siticoneButton1.TabIndex = 3;
            this.siticoneButton1.Text = "Bán hàng";
            this.siticoneButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton1.TextOffset = new System.Drawing.Point(15, 0);
            this.siticoneButton1.CheckedChanged += new System.EventHandler(this.siticoneButton1_CheckedChanged);
            // 
            // uC_BanHang1
            // 
            this.uC_BanHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_BanHang1.Location = new System.Drawing.Point(226, 0);
            this.uC_BanHang1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_BanHang1.Name = "uC_BanHang1";
            this.uC_BanHang1.Size = new System.Drawing.Size(880, 687);
            this.uC_BanHang1.TabIndex = 4;
            // 
            // FBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 687);
            this.Controls.Add(this.uC_BanHang1);
            this.Controls.Add(this.siticonePanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBanHang";
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton6;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private UC_BanHang uC_BanHang1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
    }
}
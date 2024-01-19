namespace WindowsFormsApp2
{
    partial class FSignIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSignIn));
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.BTExit = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BTSignIn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneShadowForm1 = new Siticone.Desktop.UI.WinForms.SiticoneShadowForm(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.TBAccount = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TBPassword = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.Controls.Add(this.siticoneControlBox2);
            this.siticonePanel1.Controls.Add(this.siticoneControlBox1);
            this.siticonePanel1.Controls.Add(this.BTExit);
            this.siticonePanel1.Controls.Add(this.BTSignIn);
            this.siticonePanel1.Controls.Add(this.TBAccount);
            this.siticonePanel1.Controls.Add(this.label2);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.TBPassword);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticonePanel1.Location = new System.Drawing.Point(420, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Enabled = true;
            this.siticonePanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.siticonePanel1.Size = new System.Drawing.Size(355, 466);
            this.siticonePanel1.TabIndex = 0;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.Animated = true;
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.White;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox2.Location = new System.Drawing.Point(273, 0);
            this.siticoneControlBox2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(43, 28);
            this.siticoneControlBox2.TabIndex = 9;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.Animated = true;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.White;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox1.Location = new System.Drawing.Point(313, 0);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(43, 28);
            this.siticoneControlBox1.TabIndex = 8;
            // 
            // BTExit
            // 
            this.BTExit.AutoRoundedCorners = true;
            this.BTExit.BorderRadius = 24;
            this.BTExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTExit.FillColor = System.Drawing.Color.RoyalBlue;
            this.BTExit.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.BTExit.ForeColor = System.Drawing.Color.White;
            this.BTExit.IndicateFocus = true;
            this.BTExit.Location = new System.Drawing.Point(216, 338);
            this.BTExit.Margin = new System.Windows.Forms.Padding(2);
            this.BTExit.Name = "BTExit";
            this.BTExit.Size = new System.Drawing.Size(116, 50);
            this.BTExit.TabIndex = 5;
            this.BTExit.Text = "Thoát";
            this.BTExit.Click += new System.EventHandler(this.BTExit_Click);
            // 
            // BTSignIn
            // 
            this.BTSignIn.Animated = true;
            this.BTSignIn.AutoRoundedCorners = true;
            this.BTSignIn.BorderRadius = 24;
            this.BTSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTSignIn.FillColor = System.Drawing.Color.RoyalBlue;
            this.BTSignIn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSignIn.ForeColor = System.Drawing.Color.White;
            this.BTSignIn.Location = new System.Drawing.Point(36, 338);
            this.BTSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.BTSignIn.Name = "BTSignIn";
            this.BTSignIn.Size = new System.Drawing.Size(116, 50);
            this.BTSignIn.TabIndex = 4;
            this.BTSignIn.Text = "Đăng nhập";
            this.BTSignIn.Click += new System.EventHandler(this.BTSignIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xin vui lòng đăng nhập để tiếp tục!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào!";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "anh-ff-1.jpg");
            this.imageList1.Images.SetKeyName(1, "b24153e90049ab17f258 (1).jpg");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TBAccount
            // 
            this.TBAccount.Animated = true;
            this.TBAccount.AutoRoundedCorners = true;
            this.TBAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBAccount.BorderRadius = 20;
            this.TBAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBAccount.DefaultText = "Vui lòng nhập tài khoản";
            this.TBAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBAccount.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.TBAccount.ForeColor = System.Drawing.Color.DimGray;
            this.TBAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBAccount.IconLeft = ((System.Drawing.Image)(resources.GetObject("TBAccount.IconLeft")));
            this.TBAccount.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.TBAccount.Location = new System.Drawing.Point(36, 164);
            this.TBAccount.Margin = new System.Windows.Forms.Padding(4);
            this.TBAccount.MaxLength = 32;
            this.TBAccount.Name = "TBAccount";
            this.TBAccount.PasswordChar = '\0';
            this.TBAccount.PlaceholderText = "";
            this.TBAccount.SelectedText = "";
            this.TBAccount.Size = new System.Drawing.Size(296, 42);
            this.TBAccount.TabIndex = 2;
            this.TBAccount.Enter += new System.EventHandler(this.TBAccount_Enter);
            this.TBAccount.Leave += new System.EventHandler(this.TBAccount_Leave);
            // 
            // TBPassword
            // 
            this.TBPassword.Animated = true;
            this.TBPassword.AutoRoundedCorners = true;
            this.TBPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBPassword.BorderRadius = 20;
            this.TBPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBPassword.DefaultText = "Vui lòng nhập mật khẩu";
            this.TBPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPassword.ForeColor = System.Drawing.Color.DimGray;
            this.TBPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("TBPassword.IconLeft")));
            this.TBPassword.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.TBPassword.Location = new System.Drawing.Point(36, 248);
            this.TBPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TBPassword.MaxLength = 32;
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '\0';
            this.TBPassword.PlaceholderText = "";
            this.TBPassword.SelectedText = "";
            this.TBPassword.Size = new System.Drawing.Size(296, 42);
            this.TBPassword.TabIndex = 3;
            this.TBPassword.Enter += new System.EventHandler(this.TBPassword_Enter);
            this.TBPassword.Leave += new System.EventHandler(this.TBPassword_Leave);
            // 
            // FSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 466);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TBPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TBAccount;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BTExit;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BTSignIn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private System.Windows.Forms.ImageList imageList2;
        public System.Windows.Forms.ImageList imageList1;
    }
}


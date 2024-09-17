namespace library_managment.PL
{
    partial class LogIn
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
            this.comUser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogIn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btmClose = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // comUser
            // 
            this.comUser.AutoRoundedCorners = true;
            this.comUser.BackColor = System.Drawing.Color.Transparent;
            this.comUser.BorderRadius = 17;
            this.comUser.BorderThickness = 2;
            this.comUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comUser.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comUser.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comUser.ItemHeight = 30;
            this.comUser.Location = new System.Drawing.Point(12, 216);
            this.comUser.Margin = new System.Windows.Forms.Padding(2);
            this.comUser.Name = "comUser";
            this.comUser.Size = new System.Drawing.Size(277, 36);
            this.comUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoRoundedCorners = true;
            this.txtPassword.BorderRadius = 16;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(12, 287);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(277, 35);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogIn
            // 
            this.btnLogIn.AutoRoundedCorners = true;
            this.btnLogIn.BorderRadius = 16;
            this.btnLogIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogIn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnLogIn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnLogIn.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(13, 337);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(277, 35);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "دخول";
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::library_managment.Properties.Resources.customer_96px;
            this.pictureBox1.Location = new System.Drawing.Point(80, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pnlMain.BorderRadius = 15;
            this.pnlMain.BorderThickness = 2;
            this.pnlMain.Controls.Add(this.btmClose);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Controls.Add(this.comUser);
            this.pnlMain.Controls.Add(this.btnLogIn);
            this.pnlMain.Controls.Add(this.txtPassword);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(301, 383);
            this.pnlMain.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "كلمة المرور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "اسم المستخدم";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btmClose
            // 
            this.btmClose.BackColor = System.Drawing.Color.Transparent;
            this.btmClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btmClose.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.btmClose.Image = global::library_managment.Properties.Resources.close_96px;
            this.btmClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btmClose.ImageRotate = 0F;
            this.btmClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btmClose.Location = new System.Drawing.Point(3, 3);
            this.btmClose.Name = "btmClose";
            this.btmClose.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.btmClose.Size = new System.Drawing.Size(30, 30);
            this.btmClose.TabIndex = 14;
            this.btmClose.Click += new System.EventHandler(this.btmClose_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(301, 383);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox comUser;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton btmClose;
    }
}
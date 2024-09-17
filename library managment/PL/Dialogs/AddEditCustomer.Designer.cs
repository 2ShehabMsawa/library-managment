namespace library_managment.PL.Dialogs
{
    partial class AddEditCustomer
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
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btmClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pnlMain.BorderRadius = 15;
            this.pnlMain.BorderThickness = 2;
            this.pnlMain.Controls.Add(this.btmClose);
            this.pnlMain.Controls.Add(this.guna2PictureBox1);
            this.pnlMain.Controls.Add(this.btnAddEdit);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.txtAddress);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtPhone);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(300, 420);
            this.pnlMain.TabIndex = 0;
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
            this.btmClose.TabIndex = 10;
            this.btmClose.Click += new System.EventHandler(this.btmClose_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::library_managment.Properties.Resources.customer_96px1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(100, 40);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(100, 100);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.AutoRoundedCorners = true;
            this.btnAddEdit.BorderRadius = 16;
            this.btnAddEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddEdit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAddEdit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAddEdit.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEdit.ForeColor = System.Drawing.Color.White;
            this.btnAddEdit.Location = new System.Drawing.Point(27, 370);
            this.btnAddEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(247, 35);
            this.btnAddEdit.TabIndex = 8;
            this.btnAddEdit.Text = "إضافة";
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 293);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "العنوان";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoRoundedCorners = true;
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BorderRadius = 16;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(12, 323);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(277, 35);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "الهاتف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "الاسم";
            // 
            // txtPhone
            // 
            this.txtPhone.AutoRoundedCorners = true;
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BorderRadius = 16;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(12, 258);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(277, 35);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.AutoRoundedCorners = true;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BorderRadius = 16;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(12, 193);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(277, 35);
            this.txtName.TabIndex = 3;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // AddEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 420);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditCustomer";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox txtPhone;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        public Guna.UI2.WinForms.Guna2GradientButton btnAddEdit;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btmClose;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
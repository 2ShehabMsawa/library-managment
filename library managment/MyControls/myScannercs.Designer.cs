namespace library_managment.MyControls
{
    partial class myScannercs
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
            this.picScan = new System.Windows.Forms.PictureBox();
            this.btnRun = new Guna.UI2.WinForms.Guna2GradientButton();
            this.comCamera = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBarCode = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picScan)).BeginInit();
            this.SuspendLayout();
            // 
            // picScan
            // 
            this.picScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picScan.Location = new System.Drawing.Point(0, 105);
            this.picScan.Name = "picScan";
            this.picScan.Size = new System.Drawing.Size(328, 224);
            this.picScan.TabIndex = 0;
            this.picScan.TabStop = false;
            // 
            // btnRun
            // 
            this.btnRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRun.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRun.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRun.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRun.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(0, 0);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(328, 38);
            this.btnRun.TabIndex = 29;
            this.btnRun.Text = "حفظ";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // comCamera
            // 
            this.comCamera.BackColor = System.Drawing.Color.Transparent;
            this.comCamera.Dock = System.Windows.Forms.DockStyle.Top;
            this.comCamera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCamera.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comCamera.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comCamera.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comCamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comCamera.ItemHeight = 30;
            this.comCamera.Location = new System.Drawing.Point(0, 38);
            this.comCamera.Margin = new System.Windows.Forms.Padding(2);
            this.comCamera.Name = "comCamera";
            this.comCamera.Size = new System.Drawing.Size(328, 36);
            this.comCamera.StartIndex = 0;
            this.comCamera.TabIndex = 30;
            this.comCamera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarCode.DefaultText = "";
            this.txtBarCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBarCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBarCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBarCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarCode.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarCode.Location = new System.Drawing.Point(0, 74);
            this.txtBarCode.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.PasswordChar = '\0';
            this.txtBarCode.PlaceholderText = "";
            this.txtBarCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBarCode.SelectedText = "";
            this.txtBarCode.Size = new System.Drawing.Size(328, 31);
            this.txtBarCode.TabIndex = 31;
            this.txtBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBarCode.TextChanged += new System.EventHandler(this.txtBarCode_TextChanged);
            // 
            // myScannercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picScan);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.comCamera);
            this.Controls.Add(this.btnRun);
            this.Name = "myScannercs";
            this.Size = new System.Drawing.Size(328, 329);
            this.Load += new System.EventHandler(this.myScannercs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picScan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picScan;
        public Guna.UI2.WinForms.Guna2GradientButton btnRun;
        public Guna.UI2.WinForms.Guna2ComboBox comCamera;
        public Guna.UI2.WinForms.Guna2TextBox txtBarCode;
    }
}

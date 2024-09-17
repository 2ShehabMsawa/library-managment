namespace library_managment.PL
{
    partial class ReportsPage
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
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gbCustomeRe = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnRun = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comPType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.gbCustomeRe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.guna2GroupBox1);
            this.pnlMain.Controls.Add(this.gbCustomeRe);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(959, 600);
            this.pnlMain.TabIndex = 0;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 185);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(959, 233);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "تقارير حسب العملاء";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbCustomeRe
            // 
            this.gbCustomeRe.Controls.Add(this.btnRun);
            this.gbCustomeRe.Controls.Add(this.label1);
            this.gbCustomeRe.Controls.Add(this.comCustomer);
            this.gbCustomeRe.Controls.Add(this.comType);
            this.gbCustomeRe.Controls.Add(this.label4);
            this.gbCustomeRe.Controls.Add(this.comPType);
            this.gbCustomeRe.Controls.Add(this.label3);
            this.gbCustomeRe.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbCustomeRe.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCustomeRe.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomeRe.ForeColor = System.Drawing.Color.White;
            this.gbCustomeRe.Location = new System.Drawing.Point(0, 0);
            this.gbCustomeRe.Name = "gbCustomeRe";
            this.gbCustomeRe.Size = new System.Drawing.Size(959, 185);
            this.gbCustomeRe.TabIndex = 0;
            this.gbCustomeRe.Text = "تقارير حسب العملاء";
            this.gbCustomeRe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRun
            // 
            this.btnRun.AutoRoundedCorners = true;
            this.btnRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRun.BorderRadius = 16;
            this.btnRun.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRun.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRun.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRun.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRun.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRun.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(3, 145);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(277, 35);
            this.btnRun.TabIndex = 34;
            this.btnRun.Text = "طباعة";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(220, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "العميل";
            // 
            // comCustomer
            // 
            this.comCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comCustomer.AutoRoundedCorners = true;
            this.comCustomer.BackColor = System.Drawing.Color.Transparent;
            this.comCustomer.BorderRadius = 17;
            this.comCustomer.BorderThickness = 2;
            this.comCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCustomer.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comCustomer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comCustomer.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comCustomer.ItemHeight = 30;
            this.comCustomer.Location = new System.Drawing.Point(3, 94);
            this.comCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.comCustomer.Name = "comCustomer";
            this.comCustomer.Size = new System.Drawing.Size(277, 36);
            this.comCustomer.StartIndex = 0;
            this.comCustomer.TabIndex = 18;
            this.comCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comType
            // 
            this.comType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comType.AutoRoundedCorners = true;
            this.comType.BackColor = System.Drawing.Color.Transparent;
            this.comType.BorderRadius = 17;
            this.comType.BorderThickness = 2;
            this.comType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comType.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comType.Font = new System.Drawing.Font("Cairo", 9F);
            this.comType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comType.ItemHeight = 30;
            this.comType.Items.AddRange(new object[] {
            "بيع",
            "استعارة"});
            this.comType.Location = new System.Drawing.Point(670, 94);
            this.comType.Margin = new System.Windows.Forms.Padding(2);
            this.comType.Name = "comType";
            this.comType.Size = new System.Drawing.Size(277, 36);
            this.comType.StartIndex = 0;
            this.comType.TabIndex = 14;
            this.comType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(533, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "نوع الدفع";
            // 
            // comPType
            // 
            this.comPType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comPType.AutoRoundedCorners = true;
            this.comPType.BackColor = System.Drawing.Color.Transparent;
            this.comPType.BorderRadius = 17;
            this.comPType.BorderThickness = 2;
            this.comPType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPType.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comPType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comPType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comPType.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comPType.ItemHeight = 30;
            this.comPType.Items.AddRange(new object[] {
            "نقد",
            "آجل"});
            this.comPType.Location = new System.Drawing.Point(331, 94);
            this.comPType.Margin = new System.Windows.Forms.Padding(2);
            this.comPType.Name = "comPType";
            this.comPType.Size = new System.Drawing.Size(277, 36);
            this.comPType.StartIndex = 0;
            this.comPType.TabIndex = 15;
            this.comPType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(856, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "نوع الفاتورة";
            // 
            // ReportsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 600);
            this.Controls.Add(this.pnlMain);
            this.KeyPreview = true;
            this.Name = "ReportsPage";
            this.Text = "ReportsPage";
            this.Activated += new System.EventHandler(this.ReportsPage_Activated);
            this.pnlMain.ResumeLayout(false);
            this.gbCustomeRe.ResumeLayout(false);
            this.gbCustomeRe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox gbCustomeRe;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2ComboBox comCustomer;
        public Guna.UI2.WinForms.Guna2ComboBox comType;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2ComboBox comPType;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2GradientButton btnRun;
        public Guna.UI2.WinForms.Guna2Panel pnlMain;
    }
}
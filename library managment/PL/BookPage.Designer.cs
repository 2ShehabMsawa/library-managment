namespace library_managment.PL
{
    partial class BookPage
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
            this.pnlMine = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlMine.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMine
            // 
            this.pnlMine.BackColor = System.Drawing.Color.White;
            this.pnlMine.Controls.Add(this.pnlDisplay);
            this.pnlMine.Controls.Add(this.guna2Panel2);
            this.pnlMine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMine.Location = new System.Drawing.Point(0, 0);
            this.pnlMine.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMine.Name = "pnlMine";
            this.pnlMine.Size = new System.Drawing.Size(906, 530);
            this.pnlMine.TabIndex = 2;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.Location = new System.Drawing.Point(0, 0);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(906, 476);
            this.pnlDisplay.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnDelete);
            this.guna2Panel2.Controls.Add(this.btnEdit);
            this.guna2Panel2.Controls.Add(this.btnAdd);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 476);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(906, 54);
            this.guna2Panel2.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderRadius = 16;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnDelete.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(59, 8);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(50, 3, 3, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 35);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.AutoRoundedCorners = true;
            this.btnEdit.BorderRadius = 16;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEdit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEdit.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(353, 8);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 35);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 16;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAdd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(647, 8);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 3, 50, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BookPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(906, 530);
            this.Controls.Add(this.pnlMine);
            this.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookPage";
            this.Text = "BookPage";
            this.pnlMine.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel pnlMine;
        private System.Windows.Forms.FlowLayoutPanel pnlDisplay;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnEdit;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
    }
}
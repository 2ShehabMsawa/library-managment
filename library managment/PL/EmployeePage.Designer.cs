namespace library_managment.PL
{
    partial class EmployeePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMine = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvEmployee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pnlMine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMine
            // 
            this.pnlMine.Controls.Add(this.guna2GroupBox1);
            this.pnlMine.Controls.Add(this.guna2Panel2);
            this.pnlMine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMine.Location = new System.Drawing.Point(0, 0);
            this.pnlMine.Name = "pnlMine";
            this.pnlMine.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMine.Size = new System.Drawing.Size(800, 450);
            this.pnlMine.TabIndex = 0;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmployee.ColumnHeadersHeight = 39;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmployee.Location = new System.Drawing.Point(0, 40);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.RowHeadersWidth = 62;
            this.dgvEmployee.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployee.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployee.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEmployee.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmployee.RowTemplate.Height = 29;
            this.dgvEmployee.Size = new System.Drawing.Size(790, 353);
            this.dgvEmployee.TabIndex = 1;
            this.dgvEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.dgvEmployee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEmployee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmployee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEmployee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmployee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmployee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEmployee.ThemeStyle.HeaderStyle.Height = 39;
            this.dgvEmployee.ThemeStyle.ReadOnly = true;
            this.dgvEmployee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmployee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmployee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEmployee.ThemeStyle.RowsStyle.Height = 29;
            this.dgvEmployee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmployee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnDelete);
            this.guna2Panel2.Controls.Add(this.btnEdit);
            this.guna2Panel2.Controls.Add(this.btnAdd);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(5, 398);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(790, 47);
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
            this.btnDelete.Location = new System.Drawing.Point(50, 7);
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
            this.btnEdit.Location = new System.Drawing.Point(295, 7);
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
            this.btnAdd.Location = new System.Drawing.Point(540, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 3, 50, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.Controls.Add(this.dgvEmployee);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.CustomizableEdges.BottomLeft = false;
            this.guna2GroupBox1.CustomizableEdges.BottomRight = false;
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(5, 5);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(790, 393);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "الموظفين";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmployeePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMine);
            this.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeePage";
            this.Text = "EmployeePage";
            this.pnlMine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnEdit;
        public Guna.UI2.WinForms.Guna2Panel pnlMine;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmployee;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
    }
}
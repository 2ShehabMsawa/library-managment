namespace library_managment.MyControls
{
    partial class BookItem
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
            this.lblName = new System.Windows.Forms.Label();
            this.picCover = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlBack = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.pnlBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblName.Location = new System.Drawing.Point(10, 171);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 26);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCover
            // 
            this.picCover.BackColor = System.Drawing.Color.Transparent;
            this.picCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCover.FillColor = System.Drawing.Color.Transparent;
            this.picCover.ImageRotate = 0F;
            this.picCover.Location = new System.Drawing.Point(10, 10);
            this.picCover.Margin = new System.Windows.Forms.Padding(2);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(149, 161);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCover.TabIndex = 2;
            this.picCover.TabStop = false;
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.White;
            this.pnlBack.BorderRadius = 15;
            this.pnlBack.BorderThickness = 2;
            this.pnlBack.Controls.Add(this.picCover);
            this.pnlBack.Controls.Add(this.lblName);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBack.Size = new System.Drawing.Size(169, 207);
            this.pnlBack.TabIndex = 1;
            // 
            // BookItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookItem";
            this.Size = new System.Drawing.Size(169, 207);
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.pnlBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        public Guna.UI2.WinForms.Guna2Panel pnlBack;
        public Guna.UI2.WinForms.Guna2PictureBox picCover;
    }
}

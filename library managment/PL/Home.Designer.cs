namespace library_managment.PL
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlBack = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlView = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlNav = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimized = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btmClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnBells = new Guna.UI2.WinForms.Guna2Button();
            this.btnBorrow = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnSrudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnBook = new Guna.UI2.WinForms.Guna2Button();
            this.btnMain = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMain.SuspendLayout();
            this.pnlBack.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBack);
            this.pnlMain.Controls.Add(this.pnlNav);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1247, 640);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBack
            // 
            this.pnlBack.Controls.Add(this.pnlView);
            this.pnlBack.Controls.Add(this.pnlTop);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(998, 640);
            this.pnlBack.TabIndex = 1;
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.White;
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 35);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(998, 605);
            this.pnlView.TabIndex = 1;
            this.pnlView.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlView_Paint);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnMinimized);
            this.pnlTop.Controls.Add(this.btmClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(998, 35);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BorderRadius = 15;
            this.pnlNav.Controls.Add(this.guna2ImageButton1);
            this.pnlNav.Controls.Add(this.guna2Panel1);
            this.pnlNav.CustomizableEdges.BottomRight = false;
            this.pnlNav.CustomizableEdges.TopRight = false;
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNav.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pnlNav.Location = new System.Drawing.Point(998, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(249, 640);
            this.pnlNav.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.btnReports);
            this.guna2Panel1.Controls.Add(this.btnBells);
            this.guna2Panel1.Controls.Add(this.btnBorrow);
            this.guna2Panel1.Controls.Add(this.btnCustomer);
            this.guna2Panel1.Controls.Add(this.btnEmployee);
            this.guna2Panel1.Controls.Add(this.btnSrudent);
            this.guna2Panel1.Controls.Add(this.btnBook);
            this.guna2Panel1.Controls.Add(this.btnMain);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 133);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(249, 507);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinimized.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.btnMinimized.Image = global::library_managment.Properties.Resources.subtract_96px;
            this.btnMinimized.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMinimized.ImageRotate = 0F;
            this.btnMinimized.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMinimized.Location = new System.Drawing.Point(39, 3);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.btnMinimized.Size = new System.Drawing.Size(30, 30);
            this.btnMinimized.TabIndex = 14;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
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
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Location = new System.Drawing.Point(6, 5);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.guna2ImageButton1.Size = new System.Drawing.Size(35, 37);
            this.guna2ImageButton1.TabIndex = 15;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // btnReports
            // 
            this.btnReports.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReports.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnReports.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnReports.CheckedState.Image = global::library_managment.Properties.Resources.bill_96px;
            this.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FillColor = System.Drawing.Color.Transparent;
            this.btnReports.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReports.Image = global::library_managment.Properties.Resources.wbill_96px;
            this.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReports.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReports.Location = new System.Drawing.Point(0, 315);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(249, 45);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "التقارير";
            this.btnReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnBells
            // 
            this.btnBells.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBells.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnBells.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnBells.CheckedState.Image = global::library_managment.Properties.Resources.bill_96px;
            this.btnBells.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBells.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBells.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBells.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBells.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBells.FillColor = System.Drawing.Color.Transparent;
            this.btnBells.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBells.ForeColor = System.Drawing.Color.White;
            this.btnBells.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBells.Image = global::library_managment.Properties.Resources.wbill_96px;
            this.btnBells.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBells.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBells.Location = new System.Drawing.Point(0, 270);
            this.btnBells.Name = "btnBells";
            this.btnBells.Size = new System.Drawing.Size(249, 45);
            this.btnBells.TabIndex = 4;
            this.btnBells.Text = "الفواتير";
            this.btnBells.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBells.Click += new System.EventHandler(this.btnBells_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBorrow.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnBorrow.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnBorrow.CheckedState.Image = global::library_managment.Properties.Resources.bill_96px;
            this.btnBorrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBorrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBorrow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrow.FillColor = System.Drawing.Color.Transparent;
            this.btnBorrow.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.White;
            this.btnBorrow.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBorrow.Image = global::library_managment.Properties.Resources.borrow_book_50pxww;
            this.btnBorrow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBorrow.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBorrow.Location = new System.Drawing.Point(0, 225);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(249, 45);
            this.btnBorrow.TabIndex = 7;
            this.btnBorrow.Text = "الاستعارة";
            this.btnBorrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCustomer
            // 
            this.btnCustomer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomer.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomer.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCustomer.CheckedState.Image = global::library_managment.Properties.Resources.customer_96px2;
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCustomer.Image = global::library_managment.Properties.Resources.wcustomer_96px;
            this.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomer.Location = new System.Drawing.Point(0, 180);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(249, 45);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "العملاء";
            this.btnCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnEmployee.CheckedState.Image = global::library_managment.Properties.Resources.tie_96px;
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FillColor = System.Drawing.Color.Transparent;
            this.btnEmployee.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEmployee.Image = global::library_managment.Properties.Resources.wtie_96px;
            this.btnEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEmployee.Location = new System.Drawing.Point(0, 135);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(249, 45);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "الموظفين";
            this.btnEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnSrudent
            // 
            this.btnSrudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSrudent.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSrudent.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnSrudent.CheckedState.Image = global::library_managment.Properties.Resources.book_90px;
            this.btnSrudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSrudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSrudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSrudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSrudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSrudent.FillColor = System.Drawing.Color.Transparent;
            this.btnSrudent.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnSrudent.ForeColor = System.Drawing.Color.White;
            this.btnSrudent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSrudent.Image = global::library_managment.Properties.Resources.Student_Male_50px;
            this.btnSrudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSrudent.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSrudent.Location = new System.Drawing.Point(0, 90);
            this.btnSrudent.Name = "btnSrudent";
            this.btnSrudent.Size = new System.Drawing.Size(249, 45);
            this.btnSrudent.TabIndex = 6;
            this.btnSrudent.Text = "الطلاب";
            this.btnSrudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBook
            // 
            this.btnBook.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBook.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnBook.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnBook.CheckedState.Image = global::library_managment.Properties.Resources.book_90px;
            this.btnBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBook.FillColor = System.Drawing.Color.Transparent;
            this.btnBook.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBook.Image = global::library_managment.Properties.Resources.wbook_96px;
            this.btnBook.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBook.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBook.Location = new System.Drawing.Point(0, 45);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(249, 45);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "الكتب";
            this.btnBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnMain
            // 
            this.btnMain.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMain.Checked = true;
            this.btnMain.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMain.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnMain.CheckedState.Image = global::library_managment.Properties.Resources.home_90px;
            this.btnMain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMain.FillColor = System.Drawing.Color.Transparent;
            this.btnMain.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMain.Image = global::library_managment.Properties.Resources.whome_90px;
            this.btnMain.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMain.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMain.Location = new System.Drawing.Point(0, 0);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(249, 45);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "الرئيسية";
            this.btnMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1247, 640);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlBack.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Panel pnlNav;
        private Guna.UI2.WinForms.Guna2Button btnMain;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnBells;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnBook;
        private Guna.UI2.WinForms.Guna2Panel pnlBack;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private Guna.UI2.WinForms.Guna2Panel pnlView;
        private Guna.UI2.WinForms.Guna2ImageButton btnMinimized;
        private Guna.UI2.WinForms.Guna2ImageButton btmClose;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Button btnSrudent;
        private Guna.UI2.WinForms.Guna2Button btnBorrow;
    }
}
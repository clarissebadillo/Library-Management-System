namespace Library_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMax = new Guna.UI.WinForms.GunaCircleButton();
            this.btnMin = new Guna.UI.WinForms.GunaCircleButton();
            this.btnClose = new Guna.UI.WinForms.GunaCircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDashboard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBooks = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnTransaction = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnStudents = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnBills = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUsers = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnLogout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 41);
            this.panel1.TabIndex = 0;
            // 
            // btnMax
            // 
            this.btnMax.AnimationHoverSpeed = 0.07F;
            this.btnMax.AnimationSpeed = 0.03F;
            this.btnMax.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(206)))), ((int)(((byte)(66)))));
            this.btnMax.BorderColor = System.Drawing.Color.Black;
            this.btnMax.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMax.FocusedColor = System.Drawing.Color.Empty;
            this.btnMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Image = null;
            this.btnMax.ImageSize = new System.Drawing.Size(52, 52);
            this.btnMax.Location = new System.Drawing.Point(52, 13);
            this.btnMax.Name = "btnMax";
            this.btnMax.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMax.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMax.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(223)))), ((int)(((byte)(129)))));
            this.btnMax.OnHoverImage = null;
            this.btnMax.OnPressedColor = System.Drawing.Color.Black;
            this.btnMax.Size = new System.Drawing.Size(14, 14);
            this.btnMax.TabIndex = 2;
            // 
            // btnMin
            // 
            this.btnMin.AnimationHoverSpeed = 0.07F;
            this.btnMin.AnimationSpeed = 0.03F;
            this.btnMin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(47)))));
            this.btnMin.BorderColor = System.Drawing.Color.Black;
            this.btnMin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMin.FocusedColor = System.Drawing.Color.Empty;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Image = null;
            this.btnMin.ImageSize = new System.Drawing.Size(52, 52);
            this.btnMin.Location = new System.Drawing.Point(32, 13);
            this.btnMin.Name = "btnMin";
            this.btnMin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMin.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(115)))));
            this.btnMin.OnHoverImage = null;
            this.btnMin.OnPressedColor = System.Drawing.Color.Black;
            this.btnMin.Size = new System.Drawing.Size(14, 14);
            this.btnMin.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(84)))));
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = null;
            this.btnClose.ImageSize = new System.Drawing.Size(52, 52);
            this.btnClose.Location = new System.Drawing.Point(12, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(144)))), ((int)(((byte)(141)))));
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(14, 14);
            this.btnClose.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnUsers);
            this.panel2.Controls.Add(this.btnBills);
            this.panel2.Controls.Add(this.btnTransaction);
            this.panel2.Controls.Add(this.btnStudents);
            this.panel2.Controls.Add(this.btnBooks);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 562);
            this.panel2.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BaseColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderColor = System.Drawing.Color.Black;
            this.btnDashboard.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDashboard.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.CheckedForeColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.CheckedImage")));
            this.btnDashboard.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageOffsetX = 20;
            this.btnDashboard.ImageSize = new System.Drawing.Size(24, 24);
            this.btnDashboard.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDashboard.Location = new System.Drawing.Point(1, 189);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnHoverImage = null;
            this.btnDashboard.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDashboard.OnPressedColor = System.Drawing.Color.Black;
            this.btnDashboard.OnPressedDepth = 0;
            this.btnDashboard.Size = new System.Drawing.Size(234, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextOffsetX = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBooks
            // 
            this.btnBooks.AnimationHoverSpeed = 0.07F;
            this.btnBooks.AnimationSpeed = 0.03F;
            this.btnBooks.BaseColor = System.Drawing.Color.Transparent;
            this.btnBooks.BorderColor = System.Drawing.Color.Black;
            this.btnBooks.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBooks.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBooks.CheckedForeColor = System.Drawing.Color.White;
            this.btnBooks.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBooks.CheckedImage")));
            this.btnBooks.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBooks.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBooks.FocusedColor = System.Drawing.Color.Empty;
            this.btnBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnBooks.Image")));
            this.btnBooks.ImageOffsetX = 20;
            this.btnBooks.ImageSize = new System.Drawing.Size(24, 24);
            this.btnBooks.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBooks.Location = new System.Drawing.Point(0, 238);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.btnBooks.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBooks.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBooks.OnHoverImage = null;
            this.btnBooks.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBooks.OnPressedColor = System.Drawing.Color.Black;
            this.btnBooks.OnPressedDepth = 0;
            this.btnBooks.Size = new System.Drawing.Size(234, 45);
            this.btnBooks.TabIndex = 2;
            this.btnBooks.Text = "Books";
            this.btnBooks.TextOffsetX = 5;
            // 
            // btnTransaction
            // 
            this.btnTransaction.AnimationHoverSpeed = 0.07F;
            this.btnTransaction.AnimationSpeed = 0.03F;
            this.btnTransaction.BaseColor = System.Drawing.Color.Transparent;
            this.btnTransaction.BorderColor = System.Drawing.Color.Black;
            this.btnTransaction.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnTransaction.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnTransaction.CheckedForeColor = System.Drawing.Color.White;
            this.btnTransaction.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnTransaction.CheckedImage")));
            this.btnTransaction.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnTransaction.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTransaction.FocusedColor = System.Drawing.Color.Empty;
            this.btnTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaction.Image")));
            this.btnTransaction.ImageOffsetX = 20;
            this.btnTransaction.ImageSize = new System.Drawing.Size(24, 24);
            this.btnTransaction.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTransaction.Location = new System.Drawing.Point(0, 336);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.btnTransaction.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTransaction.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTransaction.OnHoverImage = null;
            this.btnTransaction.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTransaction.OnPressedColor = System.Drawing.Color.Black;
            this.btnTransaction.OnPressedDepth = 0;
            this.btnTransaction.Size = new System.Drawing.Size(234, 45);
            this.btnTransaction.TabIndex = 4;
            this.btnTransaction.Text = "Issue Books";
            this.btnTransaction.TextOffsetX = 5;
            // 
            // btnStudents
            // 
            this.btnStudents.AnimationHoverSpeed = 0.07F;
            this.btnStudents.AnimationSpeed = 0.03F;
            this.btnStudents.BaseColor = System.Drawing.Color.Transparent;
            this.btnStudents.BorderColor = System.Drawing.Color.Black;
            this.btnStudents.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnStudents.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnStudents.CheckedForeColor = System.Drawing.Color.White;
            this.btnStudents.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnStudents.CheckedImage")));
            this.btnStudents.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnStudents.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStudents.FocusedColor = System.Drawing.Color.Empty;
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnStudents.Image")));
            this.btnStudents.ImageOffsetX = 20;
            this.btnStudents.ImageSize = new System.Drawing.Size(24, 24);
            this.btnStudents.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStudents.Location = new System.Drawing.Point(0, 287);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.btnStudents.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStudents.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStudents.OnHoverImage = null;
            this.btnStudents.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnStudents.OnPressedColor = System.Drawing.Color.Black;
            this.btnStudents.OnPressedDepth = 0;
            this.btnStudents.Size = new System.Drawing.Size(234, 45);
            this.btnStudents.TabIndex = 3;
            this.btnStudents.Text = "Students";
            this.btnStudents.TextOffsetX = 5;
            // 
            // btnBills
            // 
            this.btnBills.AnimationHoverSpeed = 0.07F;
            this.btnBills.AnimationSpeed = 0.03F;
            this.btnBills.BaseColor = System.Drawing.Color.Transparent;
            this.btnBills.BorderColor = System.Drawing.Color.Black;
            this.btnBills.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBills.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBills.CheckedForeColor = System.Drawing.Color.White;
            this.btnBills.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBills.CheckedImage")));
            this.btnBills.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBills.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBills.FocusedColor = System.Drawing.Color.Empty;
            this.btnBills.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Image = ((System.Drawing.Image)(resources.GetObject("btnBills.Image")));
            this.btnBills.ImageOffsetX = 20;
            this.btnBills.ImageSize = new System.Drawing.Size(24, 24);
            this.btnBills.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBills.Location = new System.Drawing.Point(0, 385);
            this.btnBills.Name = "btnBills";
            this.btnBills.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.btnBills.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBills.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBills.OnHoverImage = null;
            this.btnBills.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBills.OnPressedColor = System.Drawing.Color.Black;
            this.btnBills.OnPressedDepth = 0;
            this.btnBills.Size = new System.Drawing.Size(234, 45);
            this.btnBills.TabIndex = 5;
            this.btnBills.Text = "Bills";
            this.btnBills.TextOffsetX = 5;
            // 
            // btnUsers
            // 
            this.btnUsers.AnimationHoverSpeed = 0.07F;
            this.btnUsers.AnimationSpeed = 0.03F;
            this.btnUsers.BaseColor = System.Drawing.Color.Transparent;
            this.btnUsers.BorderColor = System.Drawing.Color.Black;
            this.btnUsers.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnUsers.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUsers.CheckedForeColor = System.Drawing.Color.White;
            this.btnUsers.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.CheckedImage")));
            this.btnUsers.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUsers.FocusedColor = System.Drawing.Color.Empty;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageOffsetX = 20;
            this.btnUsers.ImageSize = new System.Drawing.Size(24, 24);
            this.btnUsers.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUsers.Location = new System.Drawing.Point(0, 434);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.btnUsers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUsers.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUsers.OnHoverImage = null;
            this.btnUsers.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUsers.OnPressedColor = System.Drawing.Color.Black;
            this.btnUsers.OnPressedDepth = 0;
            this.btnUsers.Size = new System.Drawing.Size(234, 45);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextOffsetX = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BaseColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLogout.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogout.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.CheckedImage")));
            this.btnLogout.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageOffsetX = 20;
            this.btnLogout.ImageSize = new System.Drawing.Size(24, 24);
            this.btnLogout.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 515);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.OnPressedDepth = 0;
            this.btnLogout.Size = new System.Drawing.Size(234, 45);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextOffsetX = 5;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(250, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 510);
            this.panel3.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.lblTime.Location = new System.Drawing.Point(927, 52);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 17);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Time";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(915, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "|";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.lblDate.Location = new System.Drawing.Point(748, 52);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 17);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 603);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaCircleButton btnClose;
        private Guna.UI.WinForms.GunaCircleButton btnMax;
        private Guna.UI.WinForms.GunaCircleButton btnMin;
        private Guna.UI.WinForms.GunaAdvenceButton btnDashboard;
        private Guna.UI.WinForms.GunaAdvenceButton btnBills;
        private Guna.UI.WinForms.GunaAdvenceButton btnTransaction;
        private Guna.UI.WinForms.GunaAdvenceButton btnStudents;
        private Guna.UI.WinForms.GunaAdvenceButton btnBooks;
        private Guna.UI.WinForms.GunaAdvenceButton btnUsers;
        private Guna.UI.WinForms.GunaAdvenceButton btnLogout;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblDate;
    }
}


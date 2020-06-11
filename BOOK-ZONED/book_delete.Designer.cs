namespace BOOK_ZONED
{
    partial class book_delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book_delete));
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.headerLbl = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dbBtn = new System.Windows.Forms.Button();
            this.circulationBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.memberBtn = new System.Windows.Forms.Button();
            this.PanelSideMenu = new System.Windows.Forms.Panel();
            this.PanelAddMember = new System.Windows.Forms.Panel();
            this.bidBtn = new System.Windows.Forms.Button();
            this.bnBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dispBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookIdField = new System.Windows.Forms.TextBox();
            this.bookNameField = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.PanelMembers = new System.Windows.Forms.Panel();
            this.editMemberBtn = new System.Windows.Forms.Button();
            this.remMemberBtn = new System.Windows.Forms.Button();
            this.addmemberBtn = new System.Windows.Forms.Button();
            this.PanelBook = new System.Windows.Forms.Panel();
            this.remBookBtn = new System.Windows.Forms.Button();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.PanelDatabase = new System.Windows.Forms.Panel();
            this.vaibBtn = new System.Windows.Forms.Button();
            this.vamBtn = new System.Windows.Forms.Button();
            this.vabBtn = new System.Windows.Forms.Button();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.findmemBtn = new System.Windows.Forms.Button();
            this.findBookBtn = new System.Windows.Forms.Button();
            this.PanelCirculation = new System.Windows.Forms.Panel();
            this.renewBook = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.issueBtn = new System.Windows.Forms.Button();
            this.heading.SuspendLayout();
            this.logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelSideMenu.SuspendLayout();
            this.PanelAddMember.SuspendLayout();
            this.panel4.SuspendLayout();
            this.PanelMembers.SuspendLayout();
            this.PanelBook.SuspendLayout();
            this.PanelDatabase.SuspendLayout();
            this.PanelSearch.SuspendLayout();
            this.PanelCirculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(1738, 0);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(182, 69);
            this.logoutBtn.TabIndex = 17;
            this.logoutBtn.Text = "LOGOUT";
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1681, 1033);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "design copyrights © CHINMAYA SH";
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.headerLbl.ForeColor = System.Drawing.Color.White;
            this.headerLbl.Location = new System.Drawing.Point(769, 113);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(758, 46);
            this.headerLbl.TabIndex = 1;
            this.headerLbl.Text = "BOOK-ZONED LIBRARY MANAGEMENT";
            // 
            // heading
            // 
            this.heading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.heading.Controls.Add(this.logoutBtn);
            this.heading.Controls.Add(this.logo);
            this.heading.Controls.Add(this.headerLbl);
            this.heading.Location = new System.Drawing.Point(0, 0);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(1921, 264);
            this.heading.TabIndex = 44;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logo.Controls.Add(this.pictureBox1);
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(434, 264);
            this.logo.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(91, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(0, 652);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(434, 163);
            this.searchBtn.TabIndex = 23;
            this.searchBtn.Text = "         SEARCH ";
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dbBtn
            // 
            this.dbBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbBtn.FlatAppearance.BorderSize = 0;
            this.dbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbBtn.ForeColor = System.Drawing.Color.White;
            this.dbBtn.Image = ((System.Drawing.Image)(resources.GetObject("dbBtn.Image")));
            this.dbBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dbBtn.Location = new System.Drawing.Point(0, 489);
            this.dbBtn.Name = "dbBtn";
            this.dbBtn.Size = new System.Drawing.Size(434, 163);
            this.dbBtn.TabIndex = 22;
            this.dbBtn.Text = "         DATABASE";
            this.dbBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dbBtn.UseVisualStyleBackColor = true;
            this.dbBtn.Click += new System.EventHandler(this.dbBtn_Click);
            // 
            // circulationBtn
            // 
            this.circulationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.circulationBtn.FlatAppearance.BorderSize = 0;
            this.circulationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circulationBtn.ForeColor = System.Drawing.Color.White;
            this.circulationBtn.Image = ((System.Drawing.Image)(resources.GetObject("circulationBtn.Image")));
            this.circulationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.circulationBtn.Location = new System.Drawing.Point(0, 326);
            this.circulationBtn.Name = "circulationBtn";
            this.circulationBtn.Size = new System.Drawing.Size(434, 163);
            this.circulationBtn.TabIndex = 18;
            this.circulationBtn.Text = "      BOOK CIRCULATION";
            this.circulationBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.circulationBtn.UseVisualStyleBackColor = true;
            this.circulationBtn.Click += new System.EventHandler(this.circulationBtn_Click);
            // 
            // bookBtn
            // 
            this.bookBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookBtn.FlatAppearance.BorderSize = 0;
            this.bookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookBtn.ForeColor = System.Drawing.Color.White;
            this.bookBtn.Image = ((System.Drawing.Image)(resources.GetObject("bookBtn.Image")));
            this.bookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookBtn.Location = new System.Drawing.Point(0, 163);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(434, 163);
            this.bookBtn.TabIndex = 15;
            this.bookBtn.Text = "          BOOKS";
            this.bookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // memberBtn
            // 
            this.memberBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.memberBtn.FlatAppearance.BorderSize = 0;
            this.memberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberBtn.ForeColor = System.Drawing.Color.White;
            this.memberBtn.Image = ((System.Drawing.Image)(resources.GetObject("memberBtn.Image")));
            this.memberBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.memberBtn.Location = new System.Drawing.Point(0, 0);
            this.memberBtn.Name = "memberBtn";
            this.memberBtn.Size = new System.Drawing.Size(434, 163);
            this.memberBtn.TabIndex = 14;
            this.memberBtn.Text = "        MEMBERS";
            this.memberBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.memberBtn.UseVisualStyleBackColor = true;
            this.memberBtn.Click += new System.EventHandler(this.memberBtn_Click);
            // 
            // PanelSideMenu
            // 
            this.PanelSideMenu.AutoScroll = true;
            this.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.PanelSideMenu.Controls.Add(this.searchBtn);
            this.PanelSideMenu.Controls.Add(this.dbBtn);
            this.PanelSideMenu.Controls.Add(this.circulationBtn);
            this.PanelSideMenu.Controls.Add(this.bookBtn);
            this.PanelSideMenu.Controls.Add(this.memberBtn);
            this.PanelSideMenu.Location = new System.Drawing.Point(0, 264);
            this.PanelSideMenu.Name = "PanelSideMenu";
            this.PanelSideMenu.Size = new System.Drawing.Size(434, 816);
            this.PanelSideMenu.TabIndex = 46;
            // 
            // PanelAddMember
            // 
            this.PanelAddMember.Controls.Add(this.bidBtn);
            this.PanelAddMember.Controls.Add(this.bnBtn);
            this.PanelAddMember.Controls.Add(this.panel4);
            this.PanelAddMember.Controls.Add(this.label1);
            this.PanelAddMember.Controls.Add(this.bookIdField);
            this.PanelAddMember.Controls.Add(this.bookNameField);
            this.PanelAddMember.Controls.Add(this.Label5);
            this.PanelAddMember.Controls.Add(this.Label4);
            this.PanelAddMember.ForeColor = System.Drawing.Color.White;
            this.PanelAddMember.Location = new System.Drawing.Point(464, 294);
            this.PanelAddMember.Name = "PanelAddMember";
            this.PanelAddMember.Size = new System.Drawing.Size(1426, 715);
            this.PanelAddMember.TabIndex = 47;
            // 
            // bidBtn
            // 
            this.bidBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bidBtn.Location = new System.Drawing.Point(1033, 192);
            this.bidBtn.Name = "bidBtn";
            this.bidBtn.Size = new System.Drawing.Size(174, 32);
            this.bidBtn.TabIndex = 71;
            this.bidBtn.Text = "SUBMIT";
            this.bidBtn.UseVisualStyleBackColor = true;
            this.bidBtn.Click += new System.EventHandler(this.bidBtn_Click);
            // 
            // bnBtn
            // 
            this.bnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnBtn.Location = new System.Drawing.Point(568, 191);
            this.bnBtn.Name = "bnBtn";
            this.bnBtn.Size = new System.Drawing.Size(174, 32);
            this.bnBtn.TabIndex = 70;
            this.bnBtn.Text = "SUBMIT";
            this.bnBtn.UseVisualStyleBackColor = true;
            this.bnBtn.Click += new System.EventHandler(this.bnBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataBtn);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.dispBox);
            this.panel4.Location = new System.Drawing.Point(185, 264);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1143, 425);
            this.panel4.TabIndex = 60;
            // 
            // dataBtn
            // 
            this.dataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataBtn.Location = new System.Drawing.Point(966, 377);
            this.dataBtn.Name = "dataBtn";
            this.dataBtn.Size = new System.Drawing.Size(174, 32);
            this.dataBtn.TabIndex = 71;
            this.dataBtn.Text = "SUBMIT";
            this.dataBtn.UseVisualStyleBackColor = true;
            this.dataBtn.Click += new System.EventHandler(this.dataBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.label14.Location = new System.Drawing.Point(57, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(210, 31);
            this.label14.TabIndex = 62;
            this.label14.Text = "DELETED DATA";
            // 
            // dispBox
            // 
            this.dispBox.BackColor = System.Drawing.Color.White;
            this.dispBox.Location = new System.Drawing.Point(58, 58);
            this.dispBox.Multiline = true;
            this.dispBox.Name = "dispBox";
            this.dispBox.ReadOnly = true;
            this.dispBox.Size = new System.Drawing.Size(1004, 300);
            this.dispBox.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.label1.Location = new System.Drawing.Point(664, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 46);
            this.label1.TabIndex = 54;
            this.label1.Text = "DELETE BOOKS";
            // 
            // bookIdField
            // 
            this.bookIdField.Location = new System.Drawing.Point(956, 133);
            this.bookIdField.Name = "bookIdField";
            this.bookIdField.Size = new System.Drawing.Size(251, 32);
            this.bookIdField.TabIndex = 43;
            this.bookIdField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bookIdField_KeyPress);
            // 
            // bookNameField
            // 
            this.bookNameField.Location = new System.Drawing.Point(491, 133);
            this.bookNameField.Name = "bookNameField";
            this.bookNameField.Size = new System.Drawing.Size(251, 32);
            this.bookNameField.TabIndex = 42;
            this.bookNameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bookNameField_KeyPress);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.Label5.Location = new System.Drawing.Point(815, 133);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(123, 31);
            this.Label5.TabIndex = 39;
            this.Label5.Text = "BOOK ID";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.Label4.Location = new System.Drawing.Point(293, 134);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(175, 31);
            this.Label4.TabIndex = 38;
            this.Label4.Text = "BOOK NAME";
            // 
            // PanelMembers
            // 
            this.PanelMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelMembers.Controls.Add(this.editMemberBtn);
            this.PanelMembers.Controls.Add(this.remMemberBtn);
            this.PanelMembers.Controls.Add(this.addmemberBtn);
            this.PanelMembers.Location = new System.Drawing.Point(440, 266);
            this.PanelMembers.Name = "PanelMembers";
            this.PanelMembers.Size = new System.Drawing.Size(421, 230);
            this.PanelMembers.TabIndex = 54;
            // 
            // editMemberBtn
            // 
            this.editMemberBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.editMemberBtn.FlatAppearance.BorderSize = 0;
            this.editMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMemberBtn.ForeColor = System.Drawing.Color.White;
            this.editMemberBtn.Image = ((System.Drawing.Image)(resources.GetObject("editMemberBtn.Image")));
            this.editMemberBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editMemberBtn.Location = new System.Drawing.Point(0, 150);
            this.editMemberBtn.Name = "editMemberBtn";
            this.editMemberBtn.Size = new System.Drawing.Size(421, 75);
            this.editMemberBtn.TabIndex = 17;
            this.editMemberBtn.Text = "        EDIT MEMBERS";
            this.editMemberBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editMemberBtn.UseVisualStyleBackColor = true;
            this.editMemberBtn.Click += new System.EventHandler(this.editMemberBtn_Click);
            // 
            // remMemberBtn
            // 
            this.remMemberBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.remMemberBtn.FlatAppearance.BorderSize = 0;
            this.remMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remMemberBtn.ForeColor = System.Drawing.Color.White;
            this.remMemberBtn.Image = ((System.Drawing.Image)(resources.GetObject("remMemberBtn.Image")));
            this.remMemberBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remMemberBtn.Location = new System.Drawing.Point(0, 75);
            this.remMemberBtn.Name = "remMemberBtn";
            this.remMemberBtn.Size = new System.Drawing.Size(421, 75);
            this.remMemberBtn.TabIndex = 16;
            this.remMemberBtn.Text = "       REMOVE MEMBERS";
            this.remMemberBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.remMemberBtn.UseVisualStyleBackColor = true;
            this.remMemberBtn.Click += new System.EventHandler(this.remMemberBtn_Click);
            // 
            // addmemberBtn
            // 
            this.addmemberBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addmemberBtn.FlatAppearance.BorderSize = 0;
            this.addmemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addmemberBtn.ForeColor = System.Drawing.Color.White;
            this.addmemberBtn.Image = ((System.Drawing.Image)(resources.GetObject("addmemberBtn.Image")));
            this.addmemberBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addmemberBtn.Location = new System.Drawing.Point(0, 0);
            this.addmemberBtn.Name = "addmemberBtn";
            this.addmemberBtn.Size = new System.Drawing.Size(421, 75);
            this.addmemberBtn.TabIndex = 15;
            this.addmemberBtn.Text = "        ADD MEMBERS";
            this.addmemberBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addmemberBtn.UseVisualStyleBackColor = true;
            this.addmemberBtn.Click += new System.EventHandler(this.addmemberBtn_Click);
            // 
            // PanelBook
            // 
            this.PanelBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelBook.Controls.Add(this.remBookBtn);
            this.PanelBook.Controls.Add(this.addBookBtn);
            this.PanelBook.Location = new System.Drawing.Point(440, 427);
            this.PanelBook.Name = "PanelBook";
            this.PanelBook.Size = new System.Drawing.Size(421, 160);
            this.PanelBook.TabIndex = 56;
            // 
            // remBookBtn
            // 
            this.remBookBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.remBookBtn.FlatAppearance.BorderSize = 0;
            this.remBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remBookBtn.ForeColor = System.Drawing.Color.White;
            this.remBookBtn.Image = ((System.Drawing.Image)(resources.GetObject("remBookBtn.Image")));
            this.remBookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remBookBtn.Location = new System.Drawing.Point(0, 75);
            this.remBookBtn.Name = "remBookBtn";
            this.remBookBtn.Size = new System.Drawing.Size(421, 75);
            this.remBookBtn.TabIndex = 16;
            this.remBookBtn.Text = "       REMOVE BOOKS";
            this.remBookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.remBookBtn.UseVisualStyleBackColor = true;
            this.remBookBtn.Click += new System.EventHandler(this.remBookBtn_Click);
            // 
            // addBookBtn
            // 
            this.addBookBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addBookBtn.FlatAppearance.BorderSize = 0;
            this.addBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookBtn.ForeColor = System.Drawing.Color.White;
            this.addBookBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBookBtn.Image")));
            this.addBookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBookBtn.Location = new System.Drawing.Point(0, 0);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(421, 75);
            this.addBookBtn.TabIndex = 15;
            this.addBookBtn.Text = "        ADD BOOKS";
            this.addBookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // PanelDatabase
            // 
            this.PanelDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelDatabase.Controls.Add(this.vaibBtn);
            this.PanelDatabase.Controls.Add(this.vamBtn);
            this.PanelDatabase.Controls.Add(this.vabBtn);
            this.PanelDatabase.Location = new System.Drawing.Point(440, 753);
            this.PanelDatabase.Name = "PanelDatabase";
            this.PanelDatabase.Size = new System.Drawing.Size(421, 233);
            this.PanelDatabase.TabIndex = 57;
            // 
            // vaibBtn
            // 
            this.vaibBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.vaibBtn.FlatAppearance.BorderSize = 0;
            this.vaibBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vaibBtn.ForeColor = System.Drawing.Color.White;
            this.vaibBtn.Image = ((System.Drawing.Image)(resources.GetObject("vaibBtn.Image")));
            this.vaibBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vaibBtn.Location = new System.Drawing.Point(0, 150);
            this.vaibBtn.Name = "vaibBtn";
            this.vaibBtn.Size = new System.Drawing.Size(421, 75);
            this.vaibBtn.TabIndex = 17;
            this.vaibBtn.Text = "         VIEW ALL ISSUED BOOKS";
            this.vaibBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vaibBtn.UseVisualStyleBackColor = true;
            this.vaibBtn.Click += new System.EventHandler(this.vaibBtn_Click);
            // 
            // vamBtn
            // 
            this.vamBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.vamBtn.FlatAppearance.BorderSize = 0;
            this.vamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vamBtn.ForeColor = System.Drawing.Color.White;
            this.vamBtn.Image = ((System.Drawing.Image)(resources.GetObject("vamBtn.Image")));
            this.vamBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vamBtn.Location = new System.Drawing.Point(0, 75);
            this.vamBtn.Name = "vamBtn";
            this.vamBtn.Size = new System.Drawing.Size(421, 75);
            this.vamBtn.TabIndex = 16;
            this.vamBtn.Text = "      VIEW ALL MEMBERS";
            this.vamBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vamBtn.UseVisualStyleBackColor = true;
            this.vamBtn.Click += new System.EventHandler(this.vamBtn_Click);
            // 
            // vabBtn
            // 
            this.vabBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.vabBtn.FlatAppearance.BorderSize = 0;
            this.vabBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vabBtn.ForeColor = System.Drawing.Color.White;
            this.vabBtn.Image = ((System.Drawing.Image)(resources.GetObject("vabBtn.Image")));
            this.vabBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vabBtn.Location = new System.Drawing.Point(0, 0);
            this.vabBtn.Name = "vabBtn";
            this.vabBtn.Size = new System.Drawing.Size(421, 75);
            this.vabBtn.TabIndex = 15;
            this.vabBtn.Text = "        VIEW ALL BOOKS";
            this.vabBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vabBtn.UseVisualStyleBackColor = true;
            this.vabBtn.Click += new System.EventHandler(this.vabBtn_Click);
            // 
            // PanelSearch
            // 
            this.PanelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelSearch.Controls.Add(this.findmemBtn);
            this.PanelSearch.Controls.Add(this.findBookBtn);
            this.PanelSearch.Location = new System.Drawing.Point(440, 916);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(421, 162);
            this.PanelSearch.TabIndex = 58;
            // 
            // findmemBtn
            // 
            this.findmemBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.findmemBtn.FlatAppearance.BorderSize = 0;
            this.findmemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findmemBtn.ForeColor = System.Drawing.Color.White;
            this.findmemBtn.Image = ((System.Drawing.Image)(resources.GetObject("findmemBtn.Image")));
            this.findmemBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findmemBtn.Location = new System.Drawing.Point(0, 75);
            this.findmemBtn.Name = "findmemBtn";
            this.findmemBtn.Size = new System.Drawing.Size(421, 75);
            this.findmemBtn.TabIndex = 16;
            this.findmemBtn.Text = "      FIND MEMBERS";
            this.findmemBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.findmemBtn.UseVisualStyleBackColor = true;
            this.findmemBtn.Click += new System.EventHandler(this.findmemBtn_Click);
            // 
            // findBookBtn
            // 
            this.findBookBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.findBookBtn.FlatAppearance.BorderSize = 0;
            this.findBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findBookBtn.ForeColor = System.Drawing.Color.White;
            this.findBookBtn.Image = ((System.Drawing.Image)(resources.GetObject("findBookBtn.Image")));
            this.findBookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findBookBtn.Location = new System.Drawing.Point(0, 0);
            this.findBookBtn.Name = "findBookBtn";
            this.findBookBtn.Size = new System.Drawing.Size(421, 75);
            this.findBookBtn.TabIndex = 15;
            this.findBookBtn.Text = "        FIND BOOKS";
            this.findBookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.findBookBtn.UseVisualStyleBackColor = true;
            this.findBookBtn.Click += new System.EventHandler(this.findBookBtn_Click);
            // 
            // PanelCirculation
            // 
            this.PanelCirculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelCirculation.Controls.Add(this.renewBook);
            this.PanelCirculation.Controls.Add(this.returnBtn);
            this.PanelCirculation.Controls.Add(this.issueBtn);
            this.PanelCirculation.Location = new System.Drawing.Point(440, 590);
            this.PanelCirculation.Name = "PanelCirculation";
            this.PanelCirculation.Size = new System.Drawing.Size(421, 230);
            this.PanelCirculation.TabIndex = 55;
            // 
            // renewBook
            // 
            this.renewBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.renewBook.FlatAppearance.BorderSize = 0;
            this.renewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renewBook.ForeColor = System.Drawing.Color.White;
            this.renewBook.Image = ((System.Drawing.Image)(resources.GetObject("renewBook.Image")));
            this.renewBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.renewBook.Location = new System.Drawing.Point(0, 150);
            this.renewBook.Name = "renewBook";
            this.renewBook.Size = new System.Drawing.Size(421, 75);
            this.renewBook.TabIndex = 17;
            this.renewBook.Text = "        RENEW BOOK";
            this.renewBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.renewBook.UseVisualStyleBackColor = true;
            this.renewBook.Click += new System.EventHandler(this.renewBook_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.returnBtn.FlatAppearance.BorderSize = 0;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Image = ((System.Drawing.Image)(resources.GetObject("returnBtn.Image")));
            this.returnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBtn.Location = new System.Drawing.Point(0, 75);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(421, 75);
            this.returnBtn.TabIndex = 16;
            this.returnBtn.Text = "       RETURN BOOK";
            this.returnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // issueBtn
            // 
            this.issueBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.issueBtn.FlatAppearance.BorderSize = 0;
            this.issueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueBtn.ForeColor = System.Drawing.Color.White;
            this.issueBtn.Image = ((System.Drawing.Image)(resources.GetObject("issueBtn.Image")));
            this.issueBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issueBtn.Location = new System.Drawing.Point(0, 0);
            this.issueBtn.Name = "issueBtn";
            this.issueBtn.Size = new System.Drawing.Size(421, 75);
            this.issueBtn.TabIndex = 15;
            this.issueBtn.Text = "        ISSUE BOOK";
            this.issueBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.issueBtn.UseVisualStyleBackColor = true;
            this.issueBtn.Click += new System.EventHandler(this.issueBtn_Click);
            // 
            // book_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.PanelMembers);
            this.Controls.Add(this.PanelBook);
            this.Controls.Add(this.PanelDatabase);
            this.Controls.Add(this.PanelSearch);
            this.Controls.Add(this.PanelCirculation);
            this.Controls.Add(this.PanelAddMember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.PanelSideMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "book_delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deletebooks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.heading.ResumeLayout(false);
            this.heading.PerformLayout();
            this.logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelSideMenu.ResumeLayout(false);
            this.PanelAddMember.ResumeLayout(false);
            this.PanelAddMember.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.PanelMembers.ResumeLayout(false);
            this.PanelBook.ResumeLayout(false);
            this.PanelDatabase.ResumeLayout(false);
            this.PanelSearch.ResumeLayout(false);
            this.PanelCirculation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Panel heading;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button dbBtn;
        private System.Windows.Forms.Button circulationBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button memberBtn;
        private System.Windows.Forms.Panel PanelSideMenu;
        private System.Windows.Forms.Panel PanelAddMember;
        private System.Windows.Forms.Button bidBtn;
        private System.Windows.Forms.Button bnBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button dataBtn;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox dispBox;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox bookIdField;
        internal System.Windows.Forms.TextBox bookNameField;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Panel PanelMembers;
        private System.Windows.Forms.Button editMemberBtn;
        private System.Windows.Forms.Button remMemberBtn;
        private System.Windows.Forms.Button addmemberBtn;
        private System.Windows.Forms.Panel PanelBook;
        private System.Windows.Forms.Button remBookBtn;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Panel PanelDatabase;
        private System.Windows.Forms.Button vaibBtn;
        private System.Windows.Forms.Button vamBtn;
        private System.Windows.Forms.Button vabBtn;
        private System.Windows.Forms.Panel PanelSearch;
        private System.Windows.Forms.Button findmemBtn;
        private System.Windows.Forms.Button findBookBtn;
        private System.Windows.Forms.Panel PanelCirculation;
        private System.Windows.Forms.Button renewBook;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button issueBtn;
    }
}
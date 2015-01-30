namespace ConsoleApplication2
{
    partial class MainWindow
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.bookListTabPage = new System.Windows.Forms.TabPage();
            this.bookListDataGridView = new System.Windows.Forms.DataGridView();
            this.bookListPictureTree = new System.Windows.Forms.PictureBox();
            this.bookListBtnReset = new System.Windows.Forms.Button();
            this.bookListLabelTop = new System.Windows.Forms.Label();
            this.bookListBtnLogin = new System.Windows.Forms.Button();
            this.bookListBtnSearch = new System.Windows.Forms.Button();
            this.bookListSearchBox = new System.Windows.Forms.TextBox();
            this.userActabPage = new System.Windows.Forms.TabPage();
            this.userAcPictureTree = new System.Windows.Forms.PictureBox();
            this.userAcButtonCreateUsr = new System.Windows.Forms.Button();
            this.userAcButtonRefresh = new System.Windows.Forms.Button();
            this.userAcLabelAds = new System.Windows.Forms.Label();
            this.userAcButtonRemoveAc = new System.Windows.Forms.Button();
            this.userAcButtonUpdateInfo = new System.Windows.Forms.Button();
            this.userAcButtonCreateAd = new System.Windows.Forms.Button();
            this.userAcButtonRemoveAd = new System.Windows.Forms.Button();
            this.userAcFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.userAcLabelCity = new System.Windows.Forms.Label();
            this.userAcLabelPnbr = new System.Windows.Forms.Label();
            this.userAcLabelLname = new System.Windows.Forms.Label();
            this.userAcLabelFname = new System.Windows.Forms.Label();
            this.userAcTextBoxCity = new System.Windows.Forms.TextBox();
            this.userAcTextBoxPnbr = new System.Windows.Forms.TextBox();
            this.userAcTextBoxLname = new System.Windows.Forms.TextBox();
            this.userAcTextBoxFname = new System.Windows.Forms.TextBox();
            this.userAcLabelPassw = new System.Windows.Forms.Label();
            this.userAcLabelMail = new System.Windows.Forms.Label();
            this.userAcTextBoxPassw = new System.Windows.Forms.TextBox();
            this.userAcTextBoxMail = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.viewAdPictureTree = new System.Windows.Forms.PictureBox();
            this.viewAdComboBoxCourse = new System.Windows.Forms.ComboBox();
            this.viewAdTextBoxCity = new System.Windows.Forms.TextBox();
            this.viewAdTextBoxPnbr = new System.Windows.Forms.TextBox();
            this.viewAdTextBoxMail = new System.Windows.Forms.TextBox();
            this.viewAdLabelCity = new System.Windows.Forms.Label();
            this.viewAdLabelPnbr = new System.Windows.Forms.Label();
            this.viewAdLabelMail = new System.Windows.Forms.Label();
            this.viewAdTextBoxDate = new System.Windows.Forms.TextBox();
            this.viewAdTextBoxSeller = new System.Windows.Forms.TextBox();
            this.viewAdTextBoxText = new System.Windows.Forms.TextBox();
            this.viewAdTextBoxPrice = new System.Windows.Forms.TextBox();
            this.viewAdTextBoxInst = new System.Windows.Forms.TextBox();
            this.viewAdLabelSeller = new System.Windows.Forms.Label();
            this.viewAdLabelDate = new System.Windows.Forms.Label();
            this.viewAdLabelText = new System.Windows.Forms.Label();
            this.viewAdLabelPrice = new System.Windows.Forms.Label();
            this.viewAdLabelInst = new System.Windows.Forms.Label();
            this.viewAdButtonRemoveAd = new System.Windows.Forms.Button();
            this.viewAdButtonContactSeller = new System.Windows.Forms.Button();
            this.viewAdLabelCourse = new System.Windows.Forms.Label();
            this.viewAdLabelIsbn = new System.Windows.Forms.Label();
            this.viewAdLabelAuthor = new System.Windows.Forms.Label();
            this.viewAdLabelTitle = new System.Windows.Forms.Label();
            this.viewAdTextBoxIsbn = new System.Windows.Forms.TextBox();
            this.viewAdTextBoxAuthor = new System.Windows.Forms.TextBox();
            this.viewAdTextBoxTitle = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userAcButtonLogin = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.bookListTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListPictureTree)).BeginInit();
            this.userActabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAcPictureTree)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAdPictureTree)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.bookListTabPage);
            this.tabControl.Controls.Add(this.userActabPage);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(916, 584);
            this.tabControl.TabIndex = 0;
            // 
            // bookListTabPage
            // 
            this.bookListTabPage.Controls.Add(this.bookListDataGridView);
            this.bookListTabPage.Controls.Add(this.bookListPictureTree);
            this.bookListTabPage.Controls.Add(this.bookListBtnReset);
            this.bookListTabPage.Controls.Add(this.bookListLabelTop);
            this.bookListTabPage.Controls.Add(this.bookListBtnLogin);
            this.bookListTabPage.Controls.Add(this.bookListBtnSearch);
            this.bookListTabPage.Controls.Add(this.bookListSearchBox);
            this.bookListTabPage.Location = new System.Drawing.Point(4, 22);
            this.bookListTabPage.Name = "bookListTabPage";
            this.bookListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.bookListTabPage.Size = new System.Drawing.Size(908, 558);
            this.bookListTabPage.TabIndex = 0;
            this.bookListTabPage.Text = "List of Books";
            this.bookListTabPage.UseVisualStyleBackColor = true;
            this.bookListTabPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // bookListDataGridView
            // 
            this.bookListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookListDataGridView.Location = new System.Drawing.Point(6, 87);
            this.bookListDataGridView.Name = "bookListDataGridView";
            this.bookListDataGridView.Size = new System.Drawing.Size(896, 439);
            this.bookListDataGridView.TabIndex = 77;
            // 
            // bookListPictureTree
            // 
            this.bookListPictureTree.Image = global::ConsoleApplication2.Properties.Resources.LogoTree;
            this.bookListPictureTree.Location = new System.Drawing.Point(802, 6);
            this.bookListPictureTree.Name = "bookListPictureTree";
            this.bookListPictureTree.Size = new System.Drawing.Size(100, 75);
            this.bookListPictureTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookListPictureTree.TabIndex = 76;
            this.bookListPictureTree.TabStop = false;
            // 
            // bookListBtnReset
            // 
            this.bookListBtnReset.Location = new System.Drawing.Point(371, 532);
            this.bookListBtnReset.Name = "bookListBtnReset";
            this.bookListBtnReset.Size = new System.Drawing.Size(143, 20);
            this.bookListBtnReset.TabIndex = 23;
            this.bookListBtnReset.Text = "Reset";
            this.bookListBtnReset.UseVisualStyleBackColor = true;
            // 
            // bookListLabelTop
            // 
            this.bookListLabelTop.AutoSize = true;
            this.bookListLabelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookListLabelTop.Location = new System.Drawing.Point(360, 63);
            this.bookListLabelTop.Name = "bookListLabelTop";
            this.bookListLabelTop.Size = new System.Drawing.Size(154, 18);
            this.bookListLabelTop.TabIndex = 22;
            this.bookListLabelTop.Text = "Viewing all current ads";
            // 
            // bookListBtnLogin
            // 
            this.bookListBtnLogin.Location = new System.Drawing.Point(653, 6);
            this.bookListBtnLogin.Name = "bookListBtnLogin";
            this.bookListBtnLogin.Size = new System.Drawing.Size(143, 20);
            this.bookListBtnLogin.TabIndex = 4;
            this.bookListBtnLogin.Text = "Login";
            this.bookListBtnLogin.UseVisualStyleBackColor = true;
            // 
            // bookListBtnSearch
            // 
            this.bookListBtnSearch.Location = new System.Drawing.Point(504, 6);
            this.bookListBtnSearch.Name = "bookListBtnSearch";
            this.bookListBtnSearch.Size = new System.Drawing.Size(143, 20);
            this.bookListBtnSearch.TabIndex = 2;
            this.bookListBtnSearch.Text = "Search";
            this.bookListBtnSearch.UseVisualStyleBackColor = true;
            // 
            // bookListSearchBox
            // 
            this.bookListSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookListSearchBox.Location = new System.Drawing.Point(6, 6);
            this.bookListSearchBox.Name = "bookListSearchBox";
            this.bookListSearchBox.Size = new System.Drawing.Size(492, 20);
            this.bookListSearchBox.TabIndex = 1;
            // 
            // userActabPage
            // 
            this.userActabPage.Controls.Add(this.userAcButtonLogin);
            this.userActabPage.Controls.Add(this.userAcPictureTree);
            this.userActabPage.Controls.Add(this.userAcButtonCreateUsr);
            this.userActabPage.Controls.Add(this.userAcButtonRefresh);
            this.userActabPage.Controls.Add(this.userAcLabelAds);
            this.userActabPage.Controls.Add(this.userAcButtonRemoveAc);
            this.userActabPage.Controls.Add(this.userAcButtonUpdateInfo);
            this.userActabPage.Controls.Add(this.userAcButtonCreateAd);
            this.userActabPage.Controls.Add(this.userAcButtonRemoveAd);
            this.userActabPage.Controls.Add(this.userAcFlowLayoutPanel);
            this.userActabPage.Controls.Add(this.userAcLabelCity);
            this.userActabPage.Controls.Add(this.userAcLabelPnbr);
            this.userActabPage.Controls.Add(this.userAcLabelLname);
            this.userActabPage.Controls.Add(this.userAcLabelFname);
            this.userActabPage.Controls.Add(this.userAcTextBoxCity);
            this.userActabPage.Controls.Add(this.userAcTextBoxPnbr);
            this.userActabPage.Controls.Add(this.userAcTextBoxLname);
            this.userActabPage.Controls.Add(this.userAcTextBoxFname);
            this.userActabPage.Controls.Add(this.userAcLabelPassw);
            this.userActabPage.Controls.Add(this.userAcLabelMail);
            this.userActabPage.Controls.Add(this.userAcTextBoxPassw);
            this.userActabPage.Controls.Add(this.userAcTextBoxMail);
            this.userActabPage.Location = new System.Drawing.Point(4, 22);
            this.userActabPage.Name = "userActabPage";
            this.userActabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userActabPage.Size = new System.Drawing.Size(908, 558);
            this.userActabPage.TabIndex = 1;
            this.userActabPage.Text = "User Account";
            this.userActabPage.UseVisualStyleBackColor = true;
            this.userActabPage.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // userAcPictureTree
            // 
            this.userAcPictureTree.Image = global::ConsoleApplication2.Properties.Resources.LogoTree;
            this.userAcPictureTree.Location = new System.Drawing.Point(802, 6);
            this.userAcPictureTree.Name = "userAcPictureTree";
            this.userAcPictureTree.Size = new System.Drawing.Size(100, 75);
            this.userAcPictureTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userAcPictureTree.TabIndex = 76;
            this.userAcPictureTree.TabStop = false;
            // 
            // userAcButtonCreateUsr
            // 
            this.userAcButtonCreateUsr.Location = new System.Drawing.Point(346, 86);
            this.userAcButtonCreateUsr.Name = "userAcButtonCreateUsr";
            this.userAcButtonCreateUsr.Size = new System.Drawing.Size(99, 23);
            this.userAcButtonCreateUsr.TabIndex = 23;
            this.userAcButtonCreateUsr.Text = "Register";
            this.userAcButtonCreateUsr.UseVisualStyleBackColor = true;
            // 
            // userAcButtonRefresh
            // 
            this.userAcButtonRefresh.Location = new System.Drawing.Point(493, 509);
            this.userAcButtonRefresh.Name = "userAcButtonRefresh";
            this.userAcButtonRefresh.Size = new System.Drawing.Size(143, 20);
            this.userAcButtonRefresh.TabIndex = 22;
            this.userAcButtonRefresh.Text = "Refresh";
            this.userAcButtonRefresh.UseVisualStyleBackColor = true;
            this.userAcButtonRefresh.Visible = false;
            // 
            // userAcLabelAds
            // 
            this.userAcLabelAds.AutoSize = true;
            this.userAcLabelAds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAcLabelAds.Location = new System.Drawing.Point(341, 325);
            this.userAcLabelAds.Name = "userAcLabelAds";
            this.userAcLabelAds.Size = new System.Drawing.Size(142, 18);
            this.userAcLabelAds.TabIndex = 21;
            this.userAcLabelAds.Text = "All users current ads";
            this.userAcLabelAds.Visible = false;
            // 
            // userAcButtonRemoveAc
            // 
            this.userAcButtonRemoveAc.Location = new System.Drawing.Point(445, 259);
            this.userAcButtonRemoveAc.Name = "userAcButtonRemoveAc";
            this.userAcButtonRemoveAc.Size = new System.Drawing.Size(143, 20);
            this.userAcButtonRemoveAc.TabIndex = 20;
            this.userAcButtonRemoveAc.Text = "Remove Account";
            this.userAcButtonRemoveAc.UseVisualStyleBackColor = true;
            this.userAcButtonRemoveAc.Visible = false;
            // 
            // userAcButtonUpdateInfo
            // 
            this.userAcButtonUpdateInfo.Location = new System.Drawing.Point(296, 259);
            this.userAcButtonUpdateInfo.Name = "userAcButtonUpdateInfo";
            this.userAcButtonUpdateInfo.Size = new System.Drawing.Size(143, 20);
            this.userAcButtonUpdateInfo.TabIndex = 19;
            this.userAcButtonUpdateInfo.Text = "Update Info";
            this.userAcButtonUpdateInfo.UseVisualStyleBackColor = true;
            this.userAcButtonUpdateInfo.Visible = false;
            // 
            // userAcButtonCreateAd
            // 
            this.userAcButtonCreateAd.Location = new System.Drawing.Point(195, 509);
            this.userAcButtonCreateAd.Name = "userAcButtonCreateAd";
            this.userAcButtonCreateAd.Size = new System.Drawing.Size(143, 20);
            this.userAcButtonCreateAd.TabIndex = 18;
            this.userAcButtonCreateAd.Text = "Create New Ad";
            this.userAcButtonCreateAd.UseVisualStyleBackColor = true;
            this.userAcButtonCreateAd.Visible = false;
            // 
            // userAcButtonRemoveAd
            // 
            this.userAcButtonRemoveAd.Location = new System.Drawing.Point(344, 509);
            this.userAcButtonRemoveAd.Name = "userAcButtonRemoveAd";
            this.userAcButtonRemoveAd.Size = new System.Drawing.Size(143, 20);
            this.userAcButtonRemoveAd.TabIndex = 17;
            this.userAcButtonRemoveAd.Text = "Remove Ad";
            this.userAcButtonRemoveAd.UseVisualStyleBackColor = true;
            this.userAcButtonRemoveAd.Visible = false;
            // 
            // userAcFlowLayoutPanel
            // 
            this.userAcFlowLayoutPanel.Location = new System.Drawing.Point(6, 346);
            this.userAcFlowLayoutPanel.Name = "userAcFlowLayoutPanel";
            this.userAcFlowLayoutPanel.Size = new System.Drawing.Size(896, 147);
            this.userAcFlowLayoutPanel.TabIndex = 16;
            this.userAcFlowLayoutPanel.Visible = false;
            // 
            // userAcLabelCity
            // 
            this.userAcLabelCity.AutoSize = true;
            this.userAcLabelCity.Location = new System.Drawing.Point(228, 236);
            this.userAcLabelCity.Name = "userAcLabelCity";
            this.userAcLabelCity.Size = new System.Drawing.Size(27, 13);
            this.userAcLabelCity.TabIndex = 14;
            this.userAcLabelCity.Text = "City:";
            this.userAcLabelCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userAcLabelCity.Visible = false;
            // 
            // userAcLabelPnbr
            // 
            this.userAcLabelPnbr.AutoSize = true;
            this.userAcLabelPnbr.Location = new System.Drawing.Point(176, 210);
            this.userAcLabelPnbr.Name = "userAcLabelPnbr";
            this.userAcLabelPnbr.Size = new System.Drawing.Size(79, 13);
            this.userAcLabelPnbr.TabIndex = 12;
            this.userAcLabelPnbr.Text = "Phone number:";
            this.userAcLabelPnbr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userAcLabelPnbr.Visible = false;
            // 
            // userAcLabelLname
            // 
            this.userAcLabelLname.AutoSize = true;
            this.userAcLabelLname.Location = new System.Drawing.Point(196, 184);
            this.userAcLabelLname.Name = "userAcLabelLname";
            this.userAcLabelLname.Size = new System.Drawing.Size(59, 13);
            this.userAcLabelLname.TabIndex = 11;
            this.userAcLabelLname.Text = "Last name:";
            this.userAcLabelLname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userAcLabelLname.Visible = false;
            this.userAcLabelLname.Click += new System.EventHandler(this.label4_Click);
            // 
            // userAcLabelFname
            // 
            this.userAcLabelFname.AutoSize = true;
            this.userAcLabelFname.Location = new System.Drawing.Point(197, 158);
            this.userAcLabelFname.Name = "userAcLabelFname";
            this.userAcLabelFname.Size = new System.Drawing.Size(58, 13);
            this.userAcLabelFname.TabIndex = 10;
            this.userAcLabelFname.Text = "First name:";
            this.userAcLabelFname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userAcLabelFname.Visible = false;
            // 
            // userAcTextBoxCity
            // 
            this.userAcTextBoxCity.Location = new System.Drawing.Point(261, 233);
            this.userAcTextBoxCity.Name = "userAcTextBoxCity";
            this.userAcTextBoxCity.Size = new System.Drawing.Size(354, 20);
            this.userAcTextBoxCity.TabIndex = 7;
            this.userAcTextBoxCity.Visible = false;
            // 
            // userAcTextBoxPnbr
            // 
            this.userAcTextBoxPnbr.Location = new System.Drawing.Point(261, 207);
            this.userAcTextBoxPnbr.Name = "userAcTextBoxPnbr";
            this.userAcTextBoxPnbr.Size = new System.Drawing.Size(354, 20);
            this.userAcTextBoxPnbr.TabIndex = 6;
            this.userAcTextBoxPnbr.Visible = false;
            // 
            // userAcTextBoxLname
            // 
            this.userAcTextBoxLname.Location = new System.Drawing.Point(261, 181);
            this.userAcTextBoxLname.Name = "userAcTextBoxLname";
            this.userAcTextBoxLname.Size = new System.Drawing.Size(354, 20);
            this.userAcTextBoxLname.TabIndex = 5;
            this.userAcTextBoxLname.Visible = false;
            // 
            // userAcTextBoxFname
            // 
            this.userAcTextBoxFname.Location = new System.Drawing.Point(261, 155);
            this.userAcTextBoxFname.Name = "userAcTextBoxFname";
            this.userAcTextBoxFname.Size = new System.Drawing.Size(354, 20);
            this.userAcTextBoxFname.TabIndex = 4;
            this.userAcTextBoxFname.Visible = false;
            // 
            // userAcLabelPassw
            // 
            this.userAcLabelPassw.AutoSize = true;
            this.userAcLabelPassw.Location = new System.Drawing.Point(284, 63);
            this.userAcLabelPassw.Name = "userAcLabelPassw";
            this.userAcLabelPassw.Size = new System.Drawing.Size(56, 13);
            this.userAcLabelPassw.TabIndex = 3;
            this.userAcLabelPassw.Text = "Password:";
            // 
            // userAcLabelMail
            // 
            this.userAcLabelMail.AutoSize = true;
            this.userAcLabelMail.Location = new System.Drawing.Point(302, 37);
            this.userAcLabelMail.Name = "userAcLabelMail";
            this.userAcLabelMail.Size = new System.Drawing.Size(38, 13);
            this.userAcLabelMail.TabIndex = 2;
            this.userAcLabelMail.Text = "E-mail:";
            this.userAcLabelMail.Click += new System.EventHandler(this.label1_Click);
            // 
            // userAcTextBoxPassw
            // 
            this.userAcTextBoxPassw.Location = new System.Drawing.Point(346, 60);
            this.userAcTextBoxPassw.Name = "userAcTextBoxPassw";
            this.userAcTextBoxPassw.Size = new System.Drawing.Size(204, 20);
            this.userAcTextBoxPassw.TabIndex = 1;
            this.userAcTextBoxPassw.UseSystemPasswordChar = true;
            // 
            // userAcTextBoxMail
            // 
            this.userAcTextBoxMail.Location = new System.Drawing.Point(346, 34);
            this.userAcTextBoxMail.Name = "userAcTextBoxMail";
            this.userAcTextBoxMail.Size = new System.Drawing.Size(204, 20);
            this.userAcTextBoxMail.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.viewAdPictureTree);
            this.tabPage3.Controls.Add(this.viewAdComboBoxCourse);
            this.tabPage3.Controls.Add(this.viewAdTextBoxCity);
            this.tabPage3.Controls.Add(this.viewAdTextBoxPnbr);
            this.tabPage3.Controls.Add(this.viewAdTextBoxMail);
            this.tabPage3.Controls.Add(this.viewAdLabelCity);
            this.tabPage3.Controls.Add(this.viewAdLabelPnbr);
            this.tabPage3.Controls.Add(this.viewAdLabelMail);
            this.tabPage3.Controls.Add(this.viewAdTextBoxDate);
            this.tabPage3.Controls.Add(this.viewAdTextBoxSeller);
            this.tabPage3.Controls.Add(this.viewAdTextBoxText);
            this.tabPage3.Controls.Add(this.viewAdTextBoxPrice);
            this.tabPage3.Controls.Add(this.viewAdTextBoxInst);
            this.tabPage3.Controls.Add(this.viewAdLabelSeller);
            this.tabPage3.Controls.Add(this.viewAdLabelDate);
            this.tabPage3.Controls.Add(this.viewAdLabelText);
            this.tabPage3.Controls.Add(this.viewAdLabelPrice);
            this.tabPage3.Controls.Add(this.viewAdLabelInst);
            this.tabPage3.Controls.Add(this.viewAdButtonRemoveAd);
            this.tabPage3.Controls.Add(this.viewAdButtonContactSeller);
            this.tabPage3.Controls.Add(this.viewAdLabelCourse);
            this.tabPage3.Controls.Add(this.viewAdLabelIsbn);
            this.tabPage3.Controls.Add(this.viewAdLabelAuthor);
            this.tabPage3.Controls.Add(this.viewAdLabelTitle);
            this.tabPage3.Controls.Add(this.viewAdTextBoxIsbn);
            this.tabPage3.Controls.Add(this.viewAdTextBoxAuthor);
            this.tabPage3.Controls.Add(this.viewAdTextBoxTitle);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(908, 558);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Ad";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // viewAdPictureTree
            // 
            this.viewAdPictureTree.Image = global::ConsoleApplication2.Properties.Resources.LogoTree;
            this.viewAdPictureTree.Location = new System.Drawing.Point(802, 6);
            this.viewAdPictureTree.Name = "viewAdPictureTree";
            this.viewAdPictureTree.Size = new System.Drawing.Size(100, 75);
            this.viewAdPictureTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewAdPictureTree.TabIndex = 76;
            this.viewAdPictureTree.TabStop = false;
            // 
            // viewAdComboBoxCourse
            // 
            this.viewAdComboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewAdComboBoxCourse.FormattingEnabled = true;
            this.viewAdComboBoxCourse.Location = new System.Drawing.Point(276, 174);
            this.viewAdComboBoxCourse.Name = "viewAdComboBoxCourse";
            this.viewAdComboBoxCourse.Size = new System.Drawing.Size(354, 21);
            this.viewAdComboBoxCourse.Sorted = true;
            this.viewAdComboBoxCourse.TabIndex = 48;
            // 
            // viewAdTextBoxCity
            // 
            this.viewAdTextBoxCity.Location = new System.Drawing.Point(367, 429);
            this.viewAdTextBoxCity.Name = "viewAdTextBoxCity";
            this.viewAdTextBoxCity.ReadOnly = true;
            this.viewAdTextBoxCity.Size = new System.Drawing.Size(212, 20);
            this.viewAdTextBoxCity.TabIndex = 47;
            // 
            // viewAdTextBoxPnbr
            // 
            this.viewAdTextBoxPnbr.Location = new System.Drawing.Point(367, 403);
            this.viewAdTextBoxPnbr.Name = "viewAdTextBoxPnbr";
            this.viewAdTextBoxPnbr.ReadOnly = true;
            this.viewAdTextBoxPnbr.Size = new System.Drawing.Size(212, 20);
            this.viewAdTextBoxPnbr.TabIndex = 46;
            // 
            // viewAdTextBoxMail
            // 
            this.viewAdTextBoxMail.Location = new System.Drawing.Point(367, 377);
            this.viewAdTextBoxMail.Name = "viewAdTextBoxMail";
            this.viewAdTextBoxMail.ReadOnly = true;
            this.viewAdTextBoxMail.Size = new System.Drawing.Size(212, 20);
            this.viewAdTextBoxMail.TabIndex = 45;
            // 
            // viewAdLabelCity
            // 
            this.viewAdLabelCity.AutoSize = true;
            this.viewAdLabelCity.Location = new System.Drawing.Point(334, 432);
            this.viewAdLabelCity.Name = "viewAdLabelCity";
            this.viewAdLabelCity.Size = new System.Drawing.Size(27, 13);
            this.viewAdLabelCity.TabIndex = 44;
            this.viewAdLabelCity.Text = "City:";
            this.viewAdLabelCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewAdLabelPnbr
            // 
            this.viewAdLabelPnbr.AutoSize = true;
            this.viewAdLabelPnbr.Location = new System.Drawing.Point(282, 406);
            this.viewAdLabelPnbr.Name = "viewAdLabelPnbr";
            this.viewAdLabelPnbr.Size = new System.Drawing.Size(79, 13);
            this.viewAdLabelPnbr.TabIndex = 43;
            this.viewAdLabelPnbr.Text = "Phone number:";
            this.viewAdLabelPnbr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewAdLabelMail
            // 
            this.viewAdLabelMail.AutoSize = true;
            this.viewAdLabelMail.Location = new System.Drawing.Point(323, 380);
            this.viewAdLabelMail.Name = "viewAdLabelMail";
            this.viewAdLabelMail.Size = new System.Drawing.Size(38, 13);
            this.viewAdLabelMail.TabIndex = 42;
            this.viewAdLabelMail.Text = "E-mail:";
            this.viewAdLabelMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewAdTextBoxDate
            // 
            this.viewAdTextBoxDate.Location = new System.Drawing.Point(312, 70);
            this.viewAdTextBoxDate.Name = "viewAdTextBoxDate";
            this.viewAdTextBoxDate.ReadOnly = true;
            this.viewAdTextBoxDate.Size = new System.Drawing.Size(77, 20);
            this.viewAdTextBoxDate.TabIndex = 41;
            // 
            // viewAdTextBoxSeller
            // 
            this.viewAdTextBoxSeller.Location = new System.Drawing.Point(437, 70);
            this.viewAdTextBoxSeller.Name = "viewAdTextBoxSeller";
            this.viewAdTextBoxSeller.ReadOnly = true;
            this.viewAdTextBoxSeller.Size = new System.Drawing.Size(193, 20);
            this.viewAdTextBoxSeller.TabIndex = 40;
            // 
            // viewAdTextBoxText
            // 
            this.viewAdTextBoxText.Location = new System.Drawing.Point(276, 252);
            this.viewAdTextBoxText.Multiline = true;
            this.viewAdTextBoxText.Name = "viewAdTextBoxText";
            this.viewAdTextBoxText.ReadOnly = true;
            this.viewAdTextBoxText.Size = new System.Drawing.Size(354, 86);
            this.viewAdTextBoxText.TabIndex = 39;
            // 
            // viewAdTextBoxPrice
            // 
            this.viewAdTextBoxPrice.Location = new System.Drawing.Point(276, 226);
            this.viewAdTextBoxPrice.Name = "viewAdTextBoxPrice";
            this.viewAdTextBoxPrice.ReadOnly = true;
            this.viewAdTextBoxPrice.Size = new System.Drawing.Size(354, 20);
            this.viewAdTextBoxPrice.TabIndex = 38;
            this.viewAdTextBoxPrice.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // viewAdTextBoxInst
            // 
            this.viewAdTextBoxInst.Location = new System.Drawing.Point(276, 200);
            this.viewAdTextBoxInst.Name = "viewAdTextBoxInst";
            this.viewAdTextBoxInst.ReadOnly = true;
            this.viewAdTextBoxInst.Size = new System.Drawing.Size(354, 20);
            this.viewAdTextBoxInst.TabIndex = 37;
            this.viewAdTextBoxInst.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // viewAdLabelSeller
            // 
            this.viewAdLabelSeller.AutoSize = true;
            this.viewAdLabelSeller.Location = new System.Drawing.Point(395, 73);
            this.viewAdLabelSeller.Name = "viewAdLabelSeller";
            this.viewAdLabelSeller.Size = new System.Drawing.Size(36, 13);
            this.viewAdLabelSeller.TabIndex = 35;
            this.viewAdLabelSeller.Text = "Seller:";
            this.viewAdLabelSeller.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewAdLabelDate
            // 
            this.viewAdLabelDate.AutoSize = true;
            this.viewAdLabelDate.Location = new System.Drawing.Point(273, 73);
            this.viewAdLabelDate.Name = "viewAdLabelDate";
            this.viewAdLabelDate.Size = new System.Drawing.Size(33, 13);
            this.viewAdLabelDate.TabIndex = 34;
            this.viewAdLabelDate.Text = "Date:";
            this.viewAdLabelDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewAdLabelText
            // 
            this.viewAdLabelText.AutoSize = true;
            this.viewAdLabelText.Location = new System.Drawing.Point(235, 255);
            this.viewAdLabelText.Name = "viewAdLabelText";
            this.viewAdLabelText.Size = new System.Drawing.Size(31, 13);
            this.viewAdLabelText.TabIndex = 33;
            this.viewAdLabelText.Text = "Text:";
            this.viewAdLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewAdLabelPrice
            // 
            this.viewAdLabelPrice.AutoSize = true;
            this.viewAdLabelPrice.Location = new System.Drawing.Point(235, 229);
            this.viewAdLabelPrice.Name = "viewAdLabelPrice";
            this.viewAdLabelPrice.Size = new System.Drawing.Size(34, 13);
            this.viewAdLabelPrice.TabIndex = 32;
            this.viewAdLabelPrice.Text = "Price:";
            this.viewAdLabelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewAdLabelInst
            // 
            this.viewAdLabelInst.AutoSize = true;
            this.viewAdLabelInst.Location = new System.Drawing.Point(215, 203);
            this.viewAdLabelInst.Name = "viewAdLabelInst";
            this.viewAdLabelInst.Size = new System.Drawing.Size(55, 13);
            this.viewAdLabelInst.TabIndex = 31;
            this.viewAdLabelInst.Text = "Institution:";
            this.viewAdLabelInst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewAdButtonRemoveAd
            // 
            this.viewAdButtonRemoveAd.Location = new System.Drawing.Point(461, 465);
            this.viewAdButtonRemoveAd.Name = "viewAdButtonRemoveAd";
            this.viewAdButtonRemoveAd.Size = new System.Drawing.Size(143, 20);
            this.viewAdButtonRemoveAd.TabIndex = 30;
            this.viewAdButtonRemoveAd.Text = "Remove Ad";
            this.viewAdButtonRemoveAd.UseVisualStyleBackColor = true;
            // 
            // viewAdButtonContactSeller
            // 
            this.viewAdButtonContactSeller.Location = new System.Drawing.Point(312, 465);
            this.viewAdButtonContactSeller.Name = "viewAdButtonContactSeller";
            this.viewAdButtonContactSeller.Size = new System.Drawing.Size(143, 20);
            this.viewAdButtonContactSeller.TabIndex = 29;
            this.viewAdButtonContactSeller.Text = "Contact Seller";
            this.viewAdButtonContactSeller.UseVisualStyleBackColor = true;
            // 
            // viewAdLabelCourse
            // 
            this.viewAdLabelCourse.AutoSize = true;
            this.viewAdLabelCourse.Location = new System.Drawing.Point(227, 177);
            this.viewAdLabelCourse.Name = "viewAdLabelCourse";
            this.viewAdLabelCourse.Size = new System.Drawing.Size(43, 13);
            this.viewAdLabelCourse.TabIndex = 28;
            this.viewAdLabelCourse.Text = "Course:";
            this.viewAdLabelCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewAdLabelIsbn
            // 
            this.viewAdLabelIsbn.AutoSize = true;
            this.viewAdLabelIsbn.Location = new System.Drawing.Point(235, 151);
            this.viewAdLabelIsbn.Name = "viewAdLabelIsbn";
            this.viewAdLabelIsbn.Size = new System.Drawing.Size(35, 13);
            this.viewAdLabelIsbn.TabIndex = 27;
            this.viewAdLabelIsbn.Text = "ISBN:";
            this.viewAdLabelIsbn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewAdLabelAuthor
            // 
            this.viewAdLabelAuthor.AutoSize = true;
            this.viewAdLabelAuthor.Location = new System.Drawing.Point(229, 125);
            this.viewAdLabelAuthor.Name = "viewAdLabelAuthor";
            this.viewAdLabelAuthor.Size = new System.Drawing.Size(41, 13);
            this.viewAdLabelAuthor.TabIndex = 26;
            this.viewAdLabelAuthor.Text = "Author:";
            this.viewAdLabelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewAdLabelTitle
            // 
            this.viewAdLabelTitle.AutoSize = true;
            this.viewAdLabelTitle.Location = new System.Drawing.Point(240, 99);
            this.viewAdLabelTitle.Name = "viewAdLabelTitle";
            this.viewAdLabelTitle.Size = new System.Drawing.Size(30, 13);
            this.viewAdLabelTitle.TabIndex = 25;
            this.viewAdLabelTitle.Text = "Title:";
            this.viewAdLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewAdTextBoxIsbn
            // 
            this.viewAdTextBoxIsbn.Location = new System.Drawing.Point(276, 148);
            this.viewAdTextBoxIsbn.Name = "viewAdTextBoxIsbn";
            this.viewAdTextBoxIsbn.ReadOnly = true;
            this.viewAdTextBoxIsbn.Size = new System.Drawing.Size(354, 20);
            this.viewAdTextBoxIsbn.TabIndex = 23;
            // 
            // viewAdTextBoxAuthor
            // 
            this.viewAdTextBoxAuthor.Location = new System.Drawing.Point(276, 122);
            this.viewAdTextBoxAuthor.Name = "viewAdTextBoxAuthor";
            this.viewAdTextBoxAuthor.ReadOnly = true;
            this.viewAdTextBoxAuthor.Size = new System.Drawing.Size(354, 20);
            this.viewAdTextBoxAuthor.TabIndex = 22;
            // 
            // viewAdTextBoxTitle
            // 
            this.viewAdTextBoxTitle.Location = new System.Drawing.Point(276, 96);
            this.viewAdTextBoxTitle.Name = "viewAdTextBoxTitle";
            this.viewAdTextBoxTitle.ReadOnly = true;
            this.viewAdTextBoxTitle.Size = new System.Drawing.Size(354, 20);
            this.viewAdTextBoxTitle.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // userAcButtonLogin
            // 
            this.userAcButtonLogin.Location = new System.Drawing.Point(452, 87);
            this.userAcButtonLogin.Name = "userAcButtonLogin";
            this.userAcButtonLogin.Size = new System.Drawing.Size(98, 23);
            this.userAcButtonLogin.TabIndex = 77;
            this.userAcButtonLogin.Text = "Login";
            this.userAcButtonLogin.UseVisualStyleBackColor = true;
            this.userAcButtonLogin.Click += new System.EventHandler(this.userAcButtonLogin_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(940, 608);
            this.Controls.Add(this.tabControl);
            this.Name = "MainWindow";
            this.Text = "BookAd";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.bookListTabPage.ResumeLayout(false);
            this.bookListTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListPictureTree)).EndInit();
            this.userActabPage.ResumeLayout(false);
            this.userActabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAcPictureTree)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAdPictureTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage bookListTabPage;
        private System.Windows.Forms.TabPage userActabPage;
        private System.Windows.Forms.Button bookListBtnLogin;
        private System.Windows.Forms.Button bookListBtnSearch;
        private System.Windows.Forms.TextBox bookListSearchBox;
        private System.Windows.Forms.Label userAcLabelPassw;
        private System.Windows.Forms.Label userAcLabelMail;
        private System.Windows.Forms.TextBox userAcTextBoxPassw;
        private System.Windows.Forms.TextBox userAcTextBoxMail;
        private System.Windows.Forms.Label userAcLabelCity;
        private System.Windows.Forms.Label userAcLabelPnbr;
        private System.Windows.Forms.Label userAcLabelLname;
        private System.Windows.Forms.Label userAcLabelFname;
        private System.Windows.Forms.TextBox userAcTextBoxCity;
        private System.Windows.Forms.TextBox userAcTextBoxPnbr;
        private System.Windows.Forms.TextBox userAcTextBoxLname;
        private System.Windows.Forms.TextBox userAcTextBoxFname;
        private System.Windows.Forms.Button userAcButtonCreateAd;
        private System.Windows.Forms.Button userAcButtonRemoveAd;
        private System.Windows.Forms.FlowLayoutPanel userAcFlowLayoutPanel;
        private System.Windows.Forms.Label userAcLabelAds;
        private System.Windows.Forms.Button userAcButtonRemoveAc;
        private System.Windows.Forms.Button userAcButtonUpdateInfo;
        private System.Windows.Forms.Button userAcButtonRefresh;
        private System.Windows.Forms.Button bookListBtnReset;
        private System.Windows.Forms.Label bookListLabelTop;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox viewAdTextBoxText;
        private System.Windows.Forms.TextBox viewAdTextBoxPrice;
        private System.Windows.Forms.TextBox viewAdTextBoxInst;
        private System.Windows.Forms.Label viewAdLabelSeller;
        private System.Windows.Forms.Label viewAdLabelDate;
        private System.Windows.Forms.Label viewAdLabelText;
        private System.Windows.Forms.Label viewAdLabelPrice;
        private System.Windows.Forms.Label viewAdLabelInst;
        private System.Windows.Forms.Button viewAdButtonRemoveAd;
        private System.Windows.Forms.Button viewAdButtonContactSeller;
        private System.Windows.Forms.Label viewAdLabelCourse;
        private System.Windows.Forms.Label viewAdLabelIsbn;
        private System.Windows.Forms.Label viewAdLabelAuthor;
        private System.Windows.Forms.Label viewAdLabelTitle;
        private System.Windows.Forms.TextBox viewAdTextBoxIsbn;
        private System.Windows.Forms.TextBox viewAdTextBoxAuthor;
        private System.Windows.Forms.TextBox viewAdTextBoxTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox viewAdTextBoxDate;
        private System.Windows.Forms.TextBox viewAdTextBoxSeller;
        private System.Windows.Forms.TextBox viewAdTextBoxCity;
        private System.Windows.Forms.TextBox viewAdTextBoxPnbr;
        private System.Windows.Forms.TextBox viewAdTextBoxMail;
        private System.Windows.Forms.Label viewAdLabelCity;
        private System.Windows.Forms.Label viewAdLabelPnbr;
        private System.Windows.Forms.Label viewAdLabelMail;
        private System.Windows.Forms.Button userAcButtonCreateUsr;
        private System.Windows.Forms.ComboBox viewAdComboBoxCourse;
        private System.Windows.Forms.PictureBox bookListPictureTree;
        private System.Windows.Forms.PictureBox userAcPictureTree;
        private System.Windows.Forms.PictureBox viewAdPictureTree;
        private System.Windows.Forms.DataGridView bookListDataGridView;
        private System.Windows.Forms.Button userAcButtonLogin;
    }
}
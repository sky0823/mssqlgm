namespace MySqlT
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Loadaccbtn = new System.Windows.Forms.Button();
            this.AccountsView = new System.Windows.Forms.DataGridView();
            this.HostText = new System.Windows.Forms.TextBox();
            this.UserText = new System.Windows.Forms.TextBox();
            this.PassText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.PortText = new System.Windows.Forms.TextBox();
            this.Accountstab = new System.Windows.Forms.TabControl();
            this.AccountsPage1 = new System.Windows.Forms.TabPage();
            this.UPDATEaccBtn = new System.Windows.Forms.Button();
            this.SessionIPlb = new System.Windows.Forms.Label();
            this.genderText = new System.Windows.Forms.TextBox();
            this.mPointText = new System.Windows.Forms.TextBox();
            this.ACashText = new System.Windows.Forms.TextBox();
            this.GmText = new System.Windows.Forms.TextBox();
            this.bannedlb = new System.Windows.Forms.Label();
            this.lastloginlb = new System.Windows.Forms.Label();
            this.loggedinlb = new System.Windows.Forms.Label();
            this.TwoPasswordText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.IDlb = new System.Windows.Forms.Label();
            this.AccountsText = new System.Windows.Forms.TextBox();
            this.charactersPage2 = new System.Windows.Forms.TabPage();
            this.charactersbtn = new System.Windows.Forms.Button();
            this.charactersView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.chIDlb = new System.Windows.Forms.Label();
            this.accountidlb = new System.Windows.Forms.Label();
            this.Worldlb = new System.Windows.Forms.Label();
            this.chnameText = new System.Windows.Forms.TextBox();
            this.chLevelText = new System.Windows.Forms.TextBox();
            this.chExpText = new System.Windows.Forms.TextBox();
            this.chStrText = new System.Windows.Forms.TextBox();
            this.chDexText = new System.Windows.Forms.TextBox();
            this.chLukText = new System.Windows.Forms.TextBox();
            this.chIntText = new System.Windows.Forms.TextBox();
            this.chHpText = new System.Windows.Forms.TextBox();
            this.chMpText = new System.Windows.Forms.TextBox();
            this.chMaxhpText = new System.Windows.Forms.TextBox();
            this.chMaxmpText = new System.Windows.Forms.TextBox();
            this.chMesoText = new System.Windows.Forms.TextBox();
            this.chJobText = new System.Windows.Forms.TextBox();
            this.chApText = new System.Windows.Forms.TextBox();
            this.chSpText = new System.Windows.Forms.TextBox();
            this.chMapText = new System.Windows.Forms.TextBox();
            this.chGmText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsView)).BeginInit();
            this.Accountstab.SuspendLayout();
            this.AccountsPage1.SuspendLayout();
            this.charactersPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charactersView)).BeginInit();
            this.SuspendLayout();
            // 
            // Loadaccbtn
            // 
            this.Loadaccbtn.Location = new System.Drawing.Point(697, 386);
            this.Loadaccbtn.Name = "Loadaccbtn";
            this.Loadaccbtn.Size = new System.Drawing.Size(79, 29);
            this.Loadaccbtn.TabIndex = 0;
            this.Loadaccbtn.Text = "載入";
            this.Loadaccbtn.UseVisualStyleBackColor = true;
            this.Loadaccbtn.Click += new System.EventHandler(this.Loadaccbtn_Click);
            // 
            // AccountsView
            // 
            this.AccountsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsView.Location = new System.Drawing.Point(0, 0);
            this.AccountsView.Name = "AccountsView";
            this.AccountsView.RowTemplate.Height = 24;
            this.AccountsView.Size = new System.Drawing.Size(779, 222);
            this.AccountsView.StandardTab = true;
            this.AccountsView.TabIndex = 1;
            this.AccountsView.SelectionChanged += new System.EventHandler(this.AccountsView_SelectionChanged);
            // 
            // HostText
            // 
            this.HostText.Location = new System.Drawing.Point(52, 11);
            this.HostText.Name = "HostText";
            this.HostText.Size = new System.Drawing.Size(84, 22);
            this.HostText.TabIndex = 2;
            this.HostText.Text = "localhost";
            this.HostText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(183, 12);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(84, 22);
            this.UserText.TabIndex = 3;
            this.UserText.Text = "root";
            this.UserText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(183, 40);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(84, 22);
            this.PassText.TabIndex = 4;
            this.PassText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(322, 12);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(84, 22);
            this.NameText.TabIndex = 5;
            this.NameText.Text = "87maplestory";
            this.NameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PortText
            // 
            this.PortText.Location = new System.Drawing.Point(52, 39);
            this.PortText.Name = "PortText";
            this.PortText.Size = new System.Drawing.Size(84, 22);
            this.PortText.TabIndex = 6;
            this.PortText.Text = "3306";
            this.PortText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Accountstab
            // 
            this.Accountstab.AccessibleName = "";
            this.Accountstab.Controls.Add(this.AccountsPage1);
            this.Accountstab.Controls.Add(this.charactersPage2);
            this.Accountstab.Controls.Add(this.tabPage3);
            this.Accountstab.Controls.Add(this.tabPage4);
            this.Accountstab.Controls.Add(this.tabPage5);
            this.Accountstab.Controls.Add(this.tabPage6);
            this.Accountstab.Controls.Add(this.tabPage7);
            this.Accountstab.Controls.Add(this.tabPage8);
            this.Accountstab.Controls.Add(this.tabPage9);
            this.Accountstab.Controls.Add(this.tabPage10);
            this.Accountstab.Controls.Add(this.tabPage11);
            this.Accountstab.Controls.Add(this.tabPage12);
            this.Accountstab.Controls.Add(this.tabPage13);
            this.Accountstab.Controls.Add(this.tabPage14);
            this.Accountstab.Location = new System.Drawing.Point(5, 75);
            this.Accountstab.Name = "Accountstab";
            this.Accountstab.SelectedIndex = 0;
            this.Accountstab.Size = new System.Drawing.Size(790, 447);
            this.Accountstab.TabIndex = 7;
            // 
            // AccountsPage1
            // 
            this.AccountsPage1.Controls.Add(this.UPDATEaccBtn);
            this.AccountsPage1.Controls.Add(this.SessionIPlb);
            this.AccountsPage1.Controls.Add(this.genderText);
            this.AccountsPage1.Controls.Add(this.mPointText);
            this.AccountsPage1.Controls.Add(this.ACashText);
            this.AccountsPage1.Controls.Add(this.GmText);
            this.AccountsPage1.Controls.Add(this.Loadaccbtn);
            this.AccountsPage1.Controls.Add(this.bannedlb);
            this.AccountsPage1.Controls.Add(this.lastloginlb);
            this.AccountsPage1.Controls.Add(this.loggedinlb);
            this.AccountsPage1.Controls.Add(this.TwoPasswordText);
            this.AccountsPage1.Controls.Add(this.PasswordText);
            this.AccountsPage1.Controls.Add(this.IDlb);
            this.AccountsPage1.Controls.Add(this.AccountsText);
            this.AccountsPage1.Controls.Add(this.AccountsView);
            this.AccountsPage1.Location = new System.Drawing.Point(4, 22);
            this.AccountsPage1.Name = "AccountsPage1";
            this.AccountsPage1.Padding = new System.Windows.Forms.Padding(3);
            this.AccountsPage1.Size = new System.Drawing.Size(782, 421);
            this.AccountsPage1.TabIndex = 0;
            this.AccountsPage1.Text = "帳號";
            this.AccountsPage1.UseVisualStyleBackColor = true;
            // 
            // UPDATEaccBtn
            // 
            this.UPDATEaccBtn.Location = new System.Drawing.Point(585, 386);
            this.UPDATEaccBtn.Name = "UPDATEaccBtn";
            this.UPDATEaccBtn.Size = new System.Drawing.Size(79, 29);
            this.UPDATEaccBtn.TabIndex = 14;
            this.UPDATEaccBtn.Text = "儲存修改";
            this.UPDATEaccBtn.UseVisualStyleBackColor = true;
            this.UPDATEaccBtn.Click += new System.EventHandler(this.UPDATEaccBtn_Click);
            // 
            // SessionIPlb
            // 
            this.SessionIPlb.AutoSize = true;
            this.SessionIPlb.Location = new System.Drawing.Point(428, 231);
            this.SessionIPlb.Name = "SessionIPlb";
            this.SessionIPlb.Size = new System.Drawing.Size(49, 12);
            this.SessionIPlb.TabIndex = 13;
            this.SessionIPlb.Text = "SessionIP";
            // 
            // genderText
            // 
            this.genderText.Location = new System.Drawing.Point(166, 258);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(92, 22);
            this.genderText.TabIndex = 12;
            this.genderText.Text = "帳號性別";
            this.genderText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mPointText
            // 
            this.mPointText.Location = new System.Drawing.Point(32, 396);
            this.mPointText.Name = "mPointText";
            this.mPointText.Size = new System.Drawing.Size(92, 22);
            this.mPointText.TabIndex = 11;
            this.mPointText.Text = "楓葉點數";
            this.mPointText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ACashText
            // 
            this.ACashText.Location = new System.Drawing.Point(32, 370);
            this.ACashText.Name = "ACashText";
            this.ACashText.Size = new System.Drawing.Size(92, 22);
            this.ACashText.TabIndex = 10;
            this.ACashText.Text = "點數";
            this.ACashText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GmText
            // 
            this.GmText.Location = new System.Drawing.Point(32, 342);
            this.GmText.Name = "GmText";
            this.GmText.Size = new System.Drawing.Size(92, 22);
            this.GmText.TabIndex = 9;
            this.GmText.Text = "是否GM帳號";
            this.GmText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bannedlb
            // 
            this.bannedlb.AutoSize = true;
            this.bannedlb.Location = new System.Drawing.Point(334, 231);
            this.bannedlb.Name = "bannedlb";
            this.bannedlb.Size = new System.Drawing.Size(53, 12);
            this.bannedlb.TabIndex = 8;
            this.bannedlb.Text = "封鎖狀態";
            // 
            // lastloginlb
            // 
            this.lastloginlb.AutoSize = true;
            this.lastloginlb.Location = new System.Drawing.Point(121, 231);
            this.lastloginlb.Name = "lastloginlb";
            this.lastloginlb.Size = new System.Drawing.Size(77, 12);
            this.lastloginlb.TabIndex = 7;
            this.lastloginlb.Text = "最後登入時間";
            // 
            // loggedinlb
            // 
            this.loggedinlb.AutoSize = true;
            this.loggedinlb.Location = new System.Drawing.Point(43, 231);
            this.loggedinlb.Name = "loggedinlb";
            this.loggedinlb.Size = new System.Drawing.Size(53, 12);
            this.loggedinlb.TabIndex = 6;
            this.loggedinlb.Text = "登入狀態";
            // 
            // TwoPasswordText
            // 
            this.TwoPasswordText.Location = new System.Drawing.Point(32, 314);
            this.TwoPasswordText.Name = "TwoPasswordText";
            this.TwoPasswordText.Size = new System.Drawing.Size(92, 22);
            this.TwoPasswordText.TabIndex = 5;
            this.TwoPasswordText.Text = "2nd密碼";
            this.TwoPasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(32, 286);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(92, 22);
            this.PasswordText.TabIndex = 4;
            this.PasswordText.Text = "密碼";
            this.PasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IDlb
            // 
            this.IDlb.AutoSize = true;
            this.IDlb.Location = new System.Drawing.Point(6, 231);
            this.IDlb.Name = "IDlb";
            this.IDlb.Size = new System.Drawing.Size(17, 12);
            this.IDlb.TabIndex = 3;
            this.IDlb.Text = "ID";
            this.IDlb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountsText
            // 
            this.AccountsText.Location = new System.Drawing.Point(32, 258);
            this.AccountsText.Name = "AccountsText";
            this.AccountsText.Size = new System.Drawing.Size(92, 22);
            this.AccountsText.TabIndex = 2;
            this.AccountsText.Text = "帳號";
            this.AccountsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // charactersPage2
            // 
            this.charactersPage2.Controls.Add(this.chGmText);
            this.charactersPage2.Controls.Add(this.chMapText);
            this.charactersPage2.Controls.Add(this.chSpText);
            this.charactersPage2.Controls.Add(this.chApText);
            this.charactersPage2.Controls.Add(this.chJobText);
            this.charactersPage2.Controls.Add(this.chMesoText);
            this.charactersPage2.Controls.Add(this.chMaxmpText);
            this.charactersPage2.Controls.Add(this.chMaxhpText);
            this.charactersPage2.Controls.Add(this.chMpText);
            this.charactersPage2.Controls.Add(this.chHpText);
            this.charactersPage2.Controls.Add(this.chIntText);
            this.charactersPage2.Controls.Add(this.chLukText);
            this.charactersPage2.Controls.Add(this.chDexText);
            this.charactersPage2.Controls.Add(this.chStrText);
            this.charactersPage2.Controls.Add(this.chExpText);
            this.charactersPage2.Controls.Add(this.chLevelText);
            this.charactersPage2.Controls.Add(this.chnameText);
            this.charactersPage2.Controls.Add(this.Worldlb);
            this.charactersPage2.Controls.Add(this.accountidlb);
            this.charactersPage2.Controls.Add(this.chIDlb);
            this.charactersPage2.Controls.Add(this.charactersbtn);
            this.charactersPage2.Controls.Add(this.charactersView);
            this.charactersPage2.Location = new System.Drawing.Point(4, 22);
            this.charactersPage2.Name = "charactersPage2";
            this.charactersPage2.Padding = new System.Windows.Forms.Padding(3);
            this.charactersPage2.Size = new System.Drawing.Size(782, 421);
            this.charactersPage2.TabIndex = 1;
            this.charactersPage2.Text = "角色";
            this.charactersPage2.UseVisualStyleBackColor = true;
            // 
            // charactersbtn
            // 
            this.charactersbtn.Location = new System.Drawing.Point(696, 385);
            this.charactersbtn.Name = "charactersbtn";
            this.charactersbtn.Size = new System.Drawing.Size(79, 29);
            this.charactersbtn.TabIndex = 1;
            this.charactersbtn.Text = "載入";
            this.charactersbtn.UseVisualStyleBackColor = true;
            this.charactersbtn.Click += new System.EventHandler(this.Charactersbtn_Click);
            // 
            // charactersView
            // 
            this.charactersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.charactersView.Location = new System.Drawing.Point(-4, 0);
            this.charactersView.Name = "charactersView";
            this.charactersView.RowTemplate.Height = 24;
            this.charactersView.Size = new System.Drawing.Size(786, 228);
            this.charactersView.TabIndex = 0;
            this.charactersView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CharactersView_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(782, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(782, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(782, 421);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(782, 421);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(782, 421);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(782, 421);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(782, 421);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "tabPage9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(782, 421);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "tabPage10";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(782, 421);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "tabPage11";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(782, 421);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "tabPage12";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(782, 421);
            this.tabPage13.TabIndex = 12;
            this.tabPage13.Text = "tabPage13";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // tabPage14
            // 
            this.tabPage14.Location = new System.Drawing.Point(4, 22);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(782, 421);
            this.tabPage14.TabIndex = 13;
            this.tabPage14.Text = "tabPage14";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // chIDlb
            // 
            this.chIDlb.AutoSize = true;
            this.chIDlb.Location = new System.Drawing.Point(9, 235);
            this.chIDlb.Name = "chIDlb";
            this.chIDlb.Size = new System.Drawing.Size(17, 12);
            this.chIDlb.TabIndex = 2;
            this.chIDlb.Text = "ID";
            this.chIDlb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // accountidlb
            // 
            this.accountidlb.AutoSize = true;
            this.accountidlb.Location = new System.Drawing.Point(51, 235);
            this.accountidlb.Name = "accountidlb";
            this.accountidlb.Size = new System.Drawing.Size(50, 12);
            this.accountidlb.TabIndex = 3;
            this.accountidlb.Text = "accountid";
            this.accountidlb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Worldlb
            // 
            this.Worldlb.AutoSize = true;
            this.Worldlb.Location = new System.Drawing.Point(124, 235);
            this.Worldlb.Name = "Worldlb";
            this.Worldlb.Size = new System.Drawing.Size(35, 12);
            this.Worldlb.TabIndex = 4;
            this.Worldlb.Text = "World";
            this.Worldlb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chnameText
            // 
            this.chnameText.Location = new System.Drawing.Point(43, 263);
            this.chnameText.Name = "chnameText";
            this.chnameText.Size = new System.Drawing.Size(100, 22);
            this.chnameText.TabIndex = 5;
            this.chnameText.Text = "角色名稱";
            this.chnameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chLevelText
            // 
            this.chLevelText.Location = new System.Drawing.Point(43, 291);
            this.chLevelText.Name = "chLevelText";
            this.chLevelText.Size = new System.Drawing.Size(100, 22);
            this.chLevelText.TabIndex = 6;
            this.chLevelText.Text = "角色等級";
            this.chLevelText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chExpText
            // 
            this.chExpText.Location = new System.Drawing.Point(43, 319);
            this.chExpText.Name = "chExpText";
            this.chExpText.Size = new System.Drawing.Size(100, 22);
            this.chExpText.TabIndex = 7;
            this.chExpText.Text = "角色經驗";
            this.chExpText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chStrText
            // 
            this.chStrText.Location = new System.Drawing.Point(43, 347);
            this.chStrText.Name = "chStrText";
            this.chStrText.Size = new System.Drawing.Size(100, 22);
            this.chStrText.TabIndex = 8;
            this.chStrText.Text = "角色力量";
            this.chStrText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chDexText
            // 
            this.chDexText.Location = new System.Drawing.Point(43, 375);
            this.chDexText.Name = "chDexText";
            this.chDexText.Size = new System.Drawing.Size(100, 22);
            this.chDexText.TabIndex = 9;
            this.chDexText.Text = "角色敏捷";
            this.chDexText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chLukText
            // 
            this.chLukText.Location = new System.Drawing.Point(149, 347);
            this.chLukText.Name = "chLukText";
            this.chLukText.Size = new System.Drawing.Size(100, 22);
            this.chLukText.TabIndex = 10;
            this.chLukText.Text = "角色幸運";
            this.chLukText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chIntText
            // 
            this.chIntText.Location = new System.Drawing.Point(149, 375);
            this.chIntText.Name = "chIntText";
            this.chIntText.Size = new System.Drawing.Size(100, 22);
            this.chIntText.TabIndex = 11;
            this.chIntText.Text = "角色智力";
            this.chIntText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chHpText
            // 
            this.chHpText.Location = new System.Drawing.Point(149, 263);
            this.chHpText.Name = "chHpText";
            this.chHpText.Size = new System.Drawing.Size(100, 22);
            this.chHpText.TabIndex = 12;
            this.chHpText.Text = "角色血量";
            this.chHpText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chMpText
            // 
            this.chMpText.Location = new System.Drawing.Point(149, 291);
            this.chMpText.Name = "chMpText";
            this.chMpText.Size = new System.Drawing.Size(100, 22);
            this.chMpText.TabIndex = 13;
            this.chMpText.Text = "角色魔量";
            this.chMpText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chMaxhpText
            // 
            this.chMaxhpText.Location = new System.Drawing.Point(255, 263);
            this.chMaxhpText.Name = "chMaxhpText";
            this.chMaxhpText.Size = new System.Drawing.Size(100, 22);
            this.chMaxhpText.TabIndex = 14;
            this.chMaxhpText.Text = "角色血量上限";
            this.chMaxhpText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chMaxmpText
            // 
            this.chMaxmpText.Location = new System.Drawing.Point(255, 291);
            this.chMaxmpText.Name = "chMaxmpText";
            this.chMaxmpText.Size = new System.Drawing.Size(100, 22);
            this.chMaxmpText.TabIndex = 15;
            this.chMaxmpText.Text = "角色魔量上限";
            this.chMaxmpText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chMesoText
            // 
            this.chMesoText.Location = new System.Drawing.Point(255, 319);
            this.chMesoText.Name = "chMesoText";
            this.chMesoText.Size = new System.Drawing.Size(100, 22);
            this.chMesoText.TabIndex = 16;
            this.chMesoText.Text = "角色楓幣";
            this.chMesoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chJobText
            // 
            this.chJobText.Location = new System.Drawing.Point(149, 319);
            this.chJobText.Name = "chJobText";
            this.chJobText.Size = new System.Drawing.Size(100, 22);
            this.chJobText.TabIndex = 17;
            this.chJobText.Text = "角色職業";
            this.chJobText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chApText
            // 
            this.chApText.Location = new System.Drawing.Point(255, 347);
            this.chApText.Name = "chApText";
            this.chApText.Size = new System.Drawing.Size(100, 22);
            this.chApText.TabIndex = 18;
            this.chApText.Text = "角色能力點";
            this.chApText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chSpText
            // 
            this.chSpText.Location = new System.Drawing.Point(255, 375);
            this.chSpText.Name = "chSpText";
            this.chSpText.Size = new System.Drawing.Size(100, 22);
            this.chSpText.TabIndex = 19;
            this.chSpText.Text = "角色技能點";
            this.chSpText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chMapText
            // 
            this.chMapText.Location = new System.Drawing.Point(361, 263);
            this.chMapText.Name = "chMapText";
            this.chMapText.Size = new System.Drawing.Size(100, 22);
            this.chMapText.TabIndex = 20;
            this.chMapText.Text = "角色地圖";
            this.chMapText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chGmText
            // 
            this.chGmText.Location = new System.Drawing.Point(361, 291);
            this.chGmText.Name = "chGmText";
            this.chGmText.Size = new System.Drawing.Size(100, 22);
            this.chGmText.TabIndex = 21;
            this.chGmText.Text = "角色GM等級";
            this.chGmText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 523);
            this.Controls.Add(this.Accountstab);
            this.Controls.Add(this.PortText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.HostText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AccountsView)).EndInit();
            this.Accountstab.ResumeLayout(false);
            this.AccountsPage1.ResumeLayout(false);
            this.AccountsPage1.PerformLayout();
            this.charactersPage2.ResumeLayout(false);
            this.charactersPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charactersView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loadaccbtn;
        private System.Windows.Forms.DataGridView AccountsView;
        private System.Windows.Forms.TextBox HostText;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox PortText;
        private System.Windows.Forms.TabControl Accountstab;
        private System.Windows.Forms.TabPage AccountsPage1;
        private System.Windows.Forms.TabPage charactersPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.TextBox AccountsText;
        private System.Windows.Forms.Label SessionIPlb;
        private System.Windows.Forms.TextBox genderText;
        private System.Windows.Forms.TextBox mPointText;
        private System.Windows.Forms.TextBox ACashText;
        private System.Windows.Forms.TextBox GmText;
        private System.Windows.Forms.Label bannedlb;
        private System.Windows.Forms.Label lastloginlb;
        private System.Windows.Forms.Label loggedinlb;
        private System.Windows.Forms.TextBox TwoPasswordText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label IDlb;
        private System.Windows.Forms.Button UPDATEaccBtn;
        private System.Windows.Forms.DataGridView charactersView;
        private System.Windows.Forms.Button charactersbtn;
        private System.Windows.Forms.TextBox chGmText;
        private System.Windows.Forms.TextBox chMapText;
        private System.Windows.Forms.TextBox chSpText;
        private System.Windows.Forms.TextBox chApText;
        private System.Windows.Forms.TextBox chJobText;
        private System.Windows.Forms.TextBox chMesoText;
        private System.Windows.Forms.TextBox chMaxmpText;
        private System.Windows.Forms.TextBox chMaxhpText;
        private System.Windows.Forms.TextBox chMpText;
        private System.Windows.Forms.TextBox chHpText;
        private System.Windows.Forms.TextBox chIntText;
        private System.Windows.Forms.TextBox chLukText;
        private System.Windows.Forms.TextBox chDexText;
        private System.Windows.Forms.TextBox chStrText;
        private System.Windows.Forms.TextBox chExpText;
        private System.Windows.Forms.TextBox chLevelText;
        private System.Windows.Forms.TextBox chnameText;
        private System.Windows.Forms.Label Worldlb;
        private System.Windows.Forms.Label accountidlb;
        private System.Windows.Forms.Label chIDlb;
    }
}


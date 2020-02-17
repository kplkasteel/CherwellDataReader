namespace SaggerLookup
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
            this.components = new System.ComponentModel.Container();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.lblEndPoint = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtTokenResponse = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnSummaries = new System.Windows.Forms.Button();
            this.txtResultBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSchemas = new System.Windows.Forms.Button();
            this.btnTemplates = new System.Windows.Forms.Button();
            this.txtObjectList = new System.Windows.Forms.TextBox();
            this.lblDownloadResult = new System.Windows.Forms.Label();
            this.lblObjectList = new System.Windows.Forms.Label();
            this.txtLookup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFields = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.FieldName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtFilterList = new System.Windows.Forms.TextBox();
            this.lblFilterList = new System.Windows.Forms.Label();
            this.btnGetLookup = new System.Windows.Forms.Button();
            this.tabbedPages = new System.Windows.Forms.TabControl();
            this.tabDbBasics = new System.Windows.Forms.TabPage();
            this.tabLookup = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.btnGetTeams = new System.Windows.Forms.Button();
            this.chkStoreIndiviual = new System.Windows.Forms.CheckBox();
            this.txtUserFields = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGetUsers = new System.Windows.Forms.Button();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCustomerFields = new System.Windows.Forms.TextBox();
            this.btnCustomerGetItems = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCustomerFilters = new System.Windows.Forms.TextBox();
            this.txtCustomerFilterFieldName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCustomerAddFilter = new System.Windows.Forms.Button();
            this.btnCustomerClearFilters = new System.Windows.Forms.Button();
            this.txtCustomerFieldValue = new System.Windows.Forms.TextBox();
            this.txCustomerFieldOperator = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chkStoreAsIndivilual = new System.Windows.Forms.CheckBox();
            this.tabbedPages.SuspendLayout();
            this.tabDbBasics.SuspendLayout();
            this.tabLookup.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLogin.Location = new System.Drawing.Point(301, 27);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(152, 104);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.Login_Click);
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(10, 27);
            this.txtEndPoint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(286, 23);
            this.txtEndPoint.TabIndex = 1;
            // 
            // lblEndPoint
            // 
            this.lblEndPoint.AutoSize = true;
            this.lblEndPoint.Location = new System.Drawing.Point(8, 8);
            this.lblEndPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndPoint.Name = "lblEndPoint";
            this.lblEndPoint.Size = new System.Drawing.Size(55, 15);
            this.lblEndPoint.TabIndex = 2;
            this.lblEndPoint.Text = "Endpoint";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(8, 50);
            this.lblClientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(49, 15);
            this.lblClientID.TabIndex = 4;
            this.lblClientID.Text = "ClientID";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(10, 67);
            this.txtClientId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(286, 23);
            this.txtClientId.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(8, 132);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(10, 150);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(286, 23);
            this.txtPassword.TabIndex = 7;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(8, 91);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(62, 15);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "UserName";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(10, 108);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(286, 23);
            this.txtUserName.TabIndex = 5;
            // 
            // txtTokenResponse
            // 
            this.txtTokenResponse.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.txtTokenResponse.Location = new System.Drawing.Point(457, 27);
            this.txtTokenResponse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTokenResponse.Multiline = true;
            this.txtTokenResponse.Name = "txtTokenResponse";
            this.txtTokenResponse.ReadOnly = true;
            this.txtTokenResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTokenResponse.Size = new System.Drawing.Size(720, 145);
            this.txtTokenResponse.TabIndex = 9;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(301, 150);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.progressBar.MarqueeAnimationSpeed = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(152, 21);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 10;
            // 
            // btnSummaries
            // 
            this.btnSummaries.Location = new System.Drawing.Point(5, 6);
            this.btnSummaries.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSummaries.Name = "btnSummaries";
            this.btnSummaries.Size = new System.Drawing.Size(152, 24);
            this.btnSummaries.TabIndex = 11;
            this.btnSummaries.Text = "Summaries";
            this.btnSummaries.UseVisualStyleBackColor = true;
            this.btnSummaries.Click += new System.EventHandler(this.btnSummaries_Click);
            // 
            // txtResultBox
            // 
            this.txtResultBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.txtResultBox.Location = new System.Drawing.Point(10, 192);
            this.txtResultBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtResultBox.Multiline = true;
            this.txtResultBox.Name = "txtResultBox";
            this.txtResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultBox.Size = new System.Drawing.Size(443, 419);
            this.txtResultBox.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(10, 622);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(442, 38);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // btnSchemas
            // 
            this.btnSchemas.Location = new System.Drawing.Point(5, 36);
            this.btnSchemas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSchemas.Name = "btnSchemas";
            this.btnSchemas.Size = new System.Drawing.Size(152, 24);
            this.btnSchemas.TabIndex = 16;
            this.btnSchemas.Text = "Schemas";
            this.btnSchemas.UseVisualStyleBackColor = true;
            this.btnSchemas.Click += new System.EventHandler(this.BtnSchemas_Click);
            // 
            // btnTemplates
            // 
            this.btnTemplates.Location = new System.Drawing.Point(5, 66);
            this.btnTemplates.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTemplates.Name = "btnTemplates";
            this.btnTemplates.Size = new System.Drawing.Size(152, 24);
            this.btnTemplates.TabIndex = 17;
            this.btnTemplates.Text = "Templates";
            this.btnTemplates.UseVisualStyleBackColor = true;
            this.btnTemplates.Click += new System.EventHandler(this.BtnTemplates_Click);
            // 
            // txtObjectList
            // 
            this.txtObjectList.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.txtObjectList.Location = new System.Drawing.Point(164, 24);
            this.txtObjectList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtObjectList.Multiline = true;
            this.txtObjectList.Name = "txtObjectList";
            this.txtObjectList.Size = new System.Drawing.Size(544, 416);
            this.txtObjectList.TabIndex = 18;
            // 
            // lblDownloadResult
            // 
            this.lblDownloadResult.AutoSize = true;
            this.lblDownloadResult.Location = new System.Drawing.Point(8, 173);
            this.lblDownloadResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDownloadResult.Name = "lblDownloadResult";
            this.lblDownloadResult.Size = new System.Drawing.Size(96, 15);
            this.lblDownloadResult.TabIndex = 19;
            this.lblDownloadResult.Text = "Download Result";
            // 
            // lblObjectList
            // 
            this.lblObjectList.AutoSize = true;
            this.lblObjectList.Location = new System.Drawing.Point(162, 6);
            this.lblObjectList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObjectList.Name = "lblObjectList";
            this.lblObjectList.Size = new System.Drawing.Size(63, 15);
            this.lblObjectList.TabIndex = 20;
            this.lblObjectList.Text = "Object List";
            // 
            // txtLookup
            // 
            this.txtLookup.Location = new System.Drawing.Point(13, 31);
            this.txtLookup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLookup.Name = "txtLookup";
            this.txtLookup.Size = new System.Drawing.Size(174, 23);
            this.txtLookup.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fields";
            // 
            // txtFields
            // 
            this.txtFields.Location = new System.Drawing.Point(13, 74);
            this.txtFields.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFields.Multiline = true;
            this.txtFields.Name = "txtFields";
            this.txtFields.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFields.Size = new System.Drawing.Size(174, 354);
            this.txtFields.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Filter";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(197, 52);
            this.txtFieldName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(227, 23);
            this.txtFieldName.TabIndex = 27;
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.Location = new System.Drawing.Point(197, 170);
            this.btnAddFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(226, 22);
            this.btnAddFilter.TabIndex = 28;
            this.btnAddFilter.Text = "Add Filter";
            this.btnAddFilter.UseVisualStyleBackColor = true;
            this.btnAddFilter.Click += new System.EventHandler(this.btnAddFilter_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(429, 405);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(279, 22);
            this.btnClearFilter.TabIndex = 29;
            this.btnClearFilter.Text = "Clear Filters";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // FieldName
            // 
            this.FieldName.AutoSize = true;
            this.FieldName.Location = new System.Drawing.Point(194, 33);
            this.FieldName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FieldName.Name = "FieldName";
            this.FieldName.Size = new System.Drawing.Size(67, 15);
            this.FieldName.TabIndex = 30;
            this.FieldName.Text = "Field Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Operator";
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(197, 98);
            this.txtOperator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(227, 23);
            this.txtOperator.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Value";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(197, 143);
            this.txtValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(227, 23);
            this.txtValue.TabIndex = 33;
            // 
            // txtFilterList
            // 
            this.txtFilterList.Location = new System.Drawing.Point(429, 27);
            this.txtFilterList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFilterList.Multiline = true;
            this.txtFilterList.Name = "txtFilterList";
            this.txtFilterList.ReadOnly = true;
            this.txtFilterList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFilterList.Size = new System.Drawing.Size(279, 372);
            this.txtFilterList.TabIndex = 36;
            // 
            // lblFilterList
            // 
            this.lblFilterList.AutoSize = true;
            this.lblFilterList.Location = new System.Drawing.Point(426, 8);
            this.lblFilterList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilterList.Name = "lblFilterList";
            this.lblFilterList.Size = new System.Drawing.Size(48, 15);
            this.lblFilterList.TabIndex = 35;
            this.lblFilterList.Text = "Filterlist";
            // 
            // btnGetLookup
            // 
            this.btnGetLookup.Location = new System.Drawing.Point(197, 361);
            this.btnGetLookup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGetLookup.Name = "btnGetLookup";
            this.btnGetLookup.Size = new System.Drawing.Size(226, 65);
            this.btnGetLookup.TabIndex = 37;
            this.btnGetLookup.Text = "Get Objects";
            this.btnGetLookup.UseVisualStyleBackColor = true;
            this.btnGetLookup.Click += new System.EventHandler(this.btnGetLookup_Click);
            // 
            // tabbedPages
            // 
            this.tabbedPages.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.tabbedPages.Controls.Add(this.tabDbBasics);
            this.tabbedPages.Controls.Add(this.tabLookup);
            this.tabbedPages.Controls.Add(this.tabUsers);
            this.tabbedPages.Controls.Add(this.tabCustomers);
            this.tabbedPages.Location = new System.Drawing.Point(457, 192);
            this.tabbedPages.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabbedPages.Name = "tabbedPages";
            this.tabbedPages.SelectedIndex = 0;
            this.tabbedPages.Size = new System.Drawing.Size(720, 472);
            this.tabbedPages.TabIndex = 38;
            
            // 
            // tabDbBasics
            // 
            this.tabDbBasics.Controls.Add(this.btnTemplates);
            this.tabDbBasics.Controls.Add(this.btnSummaries);
            this.tabDbBasics.Controls.Add(this.btnSchemas);
            this.tabDbBasics.Controls.Add(this.txtObjectList);
            this.tabDbBasics.Controls.Add(this.lblObjectList);
            this.tabDbBasics.Location = new System.Drawing.Point(4, 24);
            this.tabDbBasics.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabDbBasics.Name = "tabDbBasics";
            this.tabDbBasics.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabDbBasics.Size = new System.Drawing.Size(712, 444);
            this.tabDbBasics.TabIndex = 0;
            this.tabDbBasics.Text = "Db basics";
            this.tabDbBasics.UseVisualStyleBackColor = true;
            // 
            // tabLookup
            // 
            this.tabLookup.Controls.Add(this.label1);
            this.tabLookup.Controls.Add(this.txtFields);
            this.tabLookup.Controls.Add(this.btnGetLookup);
            this.tabLookup.Controls.Add(this.txtLookup);
            this.tabLookup.Controls.Add(this.label5);
            this.tabLookup.Controls.Add(this.lblFilterList);
            this.tabLookup.Controls.Add(this.label4);
            this.tabLookup.Controls.Add(this.txtFilterList);
            this.tabLookup.Controls.Add(this.FieldName);
            this.tabLookup.Controls.Add(this.txtFieldName);
            this.tabLookup.Controls.Add(this.label3);
            this.tabLookup.Controls.Add(this.btnAddFilter);
            this.tabLookup.Controls.Add(this.btnClearFilter);
            this.tabLookup.Controls.Add(this.txtValue);
            this.tabLookup.Controls.Add(this.label2);
            this.tabLookup.Controls.Add(this.txtOperator);
            this.tabLookup.Controls.Add(this.label6);
            this.tabLookup.Location = new System.Drawing.Point(4, 24);
            this.tabLookup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabLookup.Name = "tabLookup";
            this.tabLookup.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabLookup.Size = new System.Drawing.Size(712, 444);
            this.tabLookup.TabIndex = 1;
            this.tabLookup.Text = "Lookup Tables";
            this.tabLookup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tabel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 90);
            this.label6.TabIndex = 39;
            this.label6.Text = "Available operators are:\r\neq - Equals specified value:\r\ngt - Greater than specifi" +
                               "ed value\r\nlt - Less than specified value\r\ncontains - Contains specified value\r\ns" +
                               "tartswit - Starts with specified value";
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.btnGetTeams);
            this.tabUsers.Controls.Add(this.chkStoreIndiviual);
            this.tabUsers.Controls.Add(this.txtUserFields);
            this.tabUsers.Controls.Add(this.label7);
            this.tabUsers.Controls.Add(this.btnGetUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 24);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabUsers.Size = new System.Drawing.Size(712, 444);
            this.tabUsers.TabIndex = 2;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // btnGetTeams
            // 
            this.btnGetTeams.Location = new System.Drawing.Point(576, 48);
            this.btnGetTeams.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGetTeams.Name = "btnGetTeams";
            this.btnGetTeams.Size = new System.Drawing.Size(132, 22);
            this.btnGetTeams.TabIndex = 29;
            this.btnGetTeams.Text = "Get Teams";
            this.btnGetTeams.UseVisualStyleBackColor = true;
            this.btnGetTeams.Click += new System.EventHandler(this.btnGetTeams_Click);
            // 
            // chkStoreIndiviual
            // 
            this.chkStoreIndiviual.AutoSize = true;
            this.chkStoreIndiviual.Location = new System.Drawing.Point(206, 22);
            this.chkStoreIndiviual.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkStoreIndiviual.Name = "chkStoreIndiviual";
            this.chkStoreIndiviual.Size = new System.Drawing.Size(155, 19);
            this.chkStoreIndiviual.TabIndex = 28;
            this.chkStoreIndiviual.Text = "Store as indivilual Items?";
            this.chkStoreIndiviual.UseVisualStyleBackColor = true;
            // 
            // txtUserFields
            // 
            this.txtUserFields.Location = new System.Drawing.Point(6, 22);
            this.txtUserFields.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUserFields.Multiline = true;
            this.txtUserFields.Name = "txtUserFields";
            this.txtUserFields.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserFields.Size = new System.Drawing.Size(195, 418);
            this.txtUserFields.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fields";
            // 
            // btnGetUsers
            // 
            this.btnGetUsers.Location = new System.Drawing.Point(576, 20);
            this.btnGetUsers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGetUsers.Name = "btnGetUsers";
            this.btnGetUsers.Size = new System.Drawing.Size(132, 22);
            this.btnGetUsers.TabIndex = 0;
            this.btnGetUsers.Text = "Get Users";
            this.btnGetUsers.UseVisualStyleBackColor = true;
            this.btnGetUsers.Click += new System.EventHandler(this.BtnGetUsers_Click);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.chkStoreAsIndivilual);
            this.tabCustomers.Controls.Add(this.label14);
            this.tabCustomers.Controls.Add(this.label13);
            this.tabCustomers.Controls.Add(this.txtCustomerFields);
            this.tabCustomers.Controls.Add(this.btnCustomerGetItems);
            this.tabCustomers.Controls.Add(this.label8);
            this.tabCustomers.Controls.Add(this.label9);
            this.tabCustomers.Controls.Add(this.label10);
            this.tabCustomers.Controls.Add(this.txtCustomerFilters);
            this.tabCustomers.Controls.Add(this.txtCustomerFilterFieldName);
            this.tabCustomers.Controls.Add(this.label11);
            this.tabCustomers.Controls.Add(this.btnCustomerAddFilter);
            this.tabCustomers.Controls.Add(this.btnCustomerClearFilters);
            this.tabCustomers.Controls.Add(this.txtCustomerFieldValue);
            this.tabCustomers.Controls.Add(this.txCustomerFieldOperator);
            this.tabCustomers.Controls.Add(this.label12);
            this.tabCustomers.Location = new System.Drawing.Point(4, 24);
            this.tabCustomers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabCustomers.Size = new System.Drawing.Size(712, 444);
            this.tabCustomers.TabIndex = 3;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(192, 36);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 54;
            this.label14.Text = "Field Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 53;
            this.label13.Text = "Fields";
            // 
            // txtCustomerFields
            // 
            this.txtCustomerFields.Location = new System.Drawing.Point(9, 33);
            this.txtCustomerFields.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCustomerFields.Multiline = true;
            this.txtCustomerFields.Name = "txtCustomerFields";
            this.txtCustomerFields.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCustomerFields.Size = new System.Drawing.Size(174, 400);
            this.txtCustomerFields.TabIndex = 40;
            // 
            // btnCustomerGetItems
            // 
            this.btnCustomerGetItems.Location = new System.Drawing.Point(192, 367);
            this.btnCustomerGetItems.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCustomerGetItems.Name = "btnCustomerGetItems";
            this.btnCustomerGetItems.Size = new System.Drawing.Size(226, 65);
            this.btnCustomerGetItems.TabIndex = 51;
            this.btnCustomerGetItems.Text = "Get Objects";
            this.btnCustomerGetItems.UseVisualStyleBackColor = true;
            this.btnCustomerGetItems.Click += new System.EventHandler(this.btnCustomerGetItems_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 127);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 49;
            this.label9.Text = "Filterlist";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 46;
            this.label10.Text = "Operator";
            // 
            // txtCustomerFilters
            // 
            this.txtCustomerFilters.Location = new System.Drawing.Point(425, 33);
            this.txtCustomerFilters.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCustomerFilters.Multiline = true;
            this.txtCustomerFilters.Name = "txtCustomerFilters";
            this.txtCustomerFilters.ReadOnly = true;
            this.txtCustomerFilters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCustomerFilters.Size = new System.Drawing.Size(279, 372);
            this.txtCustomerFilters.TabIndex = 50;
            // 
            // txtCustomerFilterFieldName
            // 
            this.txtCustomerFilterFieldName.Location = new System.Drawing.Point(192, 59);
            this.txtCustomerFilterFieldName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCustomerFilterFieldName.Name = "txtCustomerFilterFieldName";
            this.txtCustomerFilterFieldName.Size = new System.Drawing.Size(227, 23);
            this.txtCustomerFilterFieldName.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(190, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 15);
            this.label11.TabIndex = 41;
            this.label11.Text = "Filter";
            // 
            // btnCustomerAddFilter
            // 
            this.btnCustomerAddFilter.Location = new System.Drawing.Point(192, 175);
            this.btnCustomerAddFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCustomerAddFilter.Name = "btnCustomerAddFilter";
            this.btnCustomerAddFilter.Size = new System.Drawing.Size(226, 22);
            this.btnCustomerAddFilter.TabIndex = 43;
            this.btnCustomerAddFilter.Text = "Add Filter";
            this.btnCustomerAddFilter.UseVisualStyleBackColor = true;
            this.btnCustomerAddFilter.Click += new System.EventHandler(this.btnCustomerAddFilter_Click);
            // 
            // btnCustomerClearFilters
            // 
            this.btnCustomerClearFilters.Location = new System.Drawing.Point(425, 411);
            this.btnCustomerClearFilters.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCustomerClearFilters.Name = "btnCustomerClearFilters";
            this.btnCustomerClearFilters.Size = new System.Drawing.Size(279, 22);
            this.btnCustomerClearFilters.TabIndex = 44;
            this.btnCustomerClearFilters.Text = "Clear Filters";
            this.btnCustomerClearFilters.UseVisualStyleBackColor = true;
            this.btnCustomerClearFilters.Click += new System.EventHandler(this.btnCustomerClearFilters_Click);
            // 
            // txtCustomerFieldValue
            // 
            this.txtCustomerFieldValue.Location = new System.Drawing.Point(192, 149);
            this.txtCustomerFieldValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCustomerFieldValue.Name = "txtCustomerFieldValue";
            this.txtCustomerFieldValue.Size = new System.Drawing.Size(227, 23);
            this.txtCustomerFieldValue.TabIndex = 47;
            // 
            // txCustomerFieldOperator
            // 
            this.txCustomerFieldOperator.Location = new System.Drawing.Point(192, 104);
            this.txCustomerFieldOperator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txCustomerFieldOperator.Name = "txCustomerFieldOperator";
            this.txCustomerFieldOperator.Size = new System.Drawing.Size(227, 23);
            this.txCustomerFieldOperator.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(192, 204);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 90);
            this.label12.TabIndex = 52;
            this.label12.Text =
                "Available operators are:\r\neq - Equals specified value:\r\ngt - Greater than specifi" +
                "ed value\r\nlt - Less than specified value\r\ncontains - Contains specified value\r\ns" +
                "tartswit - Starts with specified value";
            // 
            // chkStoreAsIndivilual
            // 
            this.chkStoreAsIndivilual.AutoSize = true;
            this.chkStoreAsIndivilual.Location = new System.Drawing.Point(192, 322);
            this.chkStoreAsIndivilual.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkStoreAsIndivilual.Name = "chkStoreAsIndivilual";
            this.chkStoreAsIndivilual.Size = new System.Drawing.Size(155, 19);
            this.chkStoreAsIndivilual.TabIndex = 55;
            this.chkStoreAsIndivilual.Text = "Store as indivilual Items?";
            this.chkStoreAsIndivilual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 682);
            this.Controls.Add(this.tabbedPages);
            this.Controls.Add(this.lblDownloadResult);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtResultBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txtTokenResponse);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.lblEndPoint);
            this.Controls.Add(this.txtEndPoint);
            this.Controls.Add(this.btnLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(1206, 721);
            this.MinimumSize = new System.Drawing.Size(1206, 721);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabbedPages.ResumeLayout(false);
            this.tabDbBasics.ResumeLayout(false);
            this.tabDbBasics.PerformLayout();
            this.tabLookup.ResumeLayout(false);
            this.tabLookup.PerformLayout();
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.Label lblEndPoint;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtTokenResponse;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnSummaries;
        private System.Windows.Forms.TextBox txtResultBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSchemas;
        private System.Windows.Forms.Button btnTemplates;
        private System.Windows.Forms.TextBox txtObjectList;
        private System.Windows.Forms.Label lblDownloadResult;
        private System.Windows.Forms.Label lblObjectList;
        private System.Windows.Forms.TextBox txtLookup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFields;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Label FieldName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtFilterList;
        private System.Windows.Forms.Label lblFilterList;
        private System.Windows.Forms.Button btnGetLookup;
        private System.Windows.Forms.TabPage tabDbBasics;
        private System.Windows.Forms.TabPage tabLookup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Button btnGetUsers;
        private System.Windows.Forms.CheckBox chkStoreIndiviual;
        private System.Windows.Forms.TextBox txtUserFields;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnGetTeams;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCustomerFields;
        private System.Windows.Forms.Button btnCustomerGetItems;
        private System.Windows.Forms.TextBox txtCustomerFilters;
        private System.Windows.Forms.TextBox txtCustomerFilterFieldName;
        private System.Windows.Forms.Button btnCustomerAddFilter;
        private System.Windows.Forms.Button btnCustomerClearFilters;
        private System.Windows.Forms.TextBox txtCustomerFieldValue;
        private System.Windows.Forms.TextBox txCustomerFieldOperator;
        private System.Windows.Forms.TabControl tabbedPages;
        private System.Windows.Forms.CheckBox chkStoreAsIndivilual;
    }
}


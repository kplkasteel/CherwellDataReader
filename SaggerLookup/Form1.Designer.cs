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
            this.tabCustomer = new System.Windows.Forms.TabControl();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabCustomer.SuspendLayout();
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
            this.btnLogin.Location = new System.Drawing.Point(344, 35);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(173, 138);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.Login_Click);
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(12, 35);
            this.txtEndPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(326, 27);
            this.txtEndPoint.TabIndex = 1;
            // 
            // lblEndPoint
            // 
            this.lblEndPoint.AutoSize = true;
            this.lblEndPoint.Location = new System.Drawing.Point(9, 11);
            this.lblEndPoint.Name = "lblEndPoint";
            this.lblEndPoint.Size = new System.Drawing.Size(69, 20);
            this.lblEndPoint.TabIndex = 2;
            this.lblEndPoint.Text = "Endpoint";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(9, 66);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(62, 20);
            this.lblClientID.TabIndex = 4;
            this.lblClientID.Text = "ClientID";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(12, 90);
            this.txtClientId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(326, 27);
            this.txtClientId.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 176);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 200);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(326, 27);
            this.txtPassword.TabIndex = 7;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(9, 121);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(78, 20);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "UserName";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(12, 145);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(326, 27);
            this.txtUserName.TabIndex = 5;
            // 
            // txtTokenResponse
            // 
            this.txtTokenResponse.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.txtTokenResponse.Location = new System.Drawing.Point(523, 35);
            this.txtTokenResponse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTokenResponse.Multiline = true;
            this.txtTokenResponse.Name = "txtTokenResponse";
            this.txtTokenResponse.ReadOnly = true;
            this.txtTokenResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTokenResponse.Size = new System.Drawing.Size(823, 192);
            this.txtTokenResponse.TabIndex = 9;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(344, 200);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar.MarqueeAnimationSpeed = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(173, 28);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 10;
            // 
            // btnSummaries
            // 
            this.btnSummaries.Location = new System.Drawing.Point(6, 8);
            this.btnSummaries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSummaries.Name = "btnSummaries";
            this.btnSummaries.Size = new System.Drawing.Size(173, 32);
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
            this.txtResultBox.Location = new System.Drawing.Point(12, 256);
            this.txtResultBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResultBox.Multiline = true;
            this.txtResultBox.Name = "txtResultBox";
            this.txtResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultBox.Size = new System.Drawing.Size(505, 558);
            this.txtResultBox.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(12, 830);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(505, 51);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // btnSchemas
            // 
            this.btnSchemas.Location = new System.Drawing.Point(6, 48);
            this.btnSchemas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSchemas.Name = "btnSchemas";
            this.btnSchemas.Size = new System.Drawing.Size(173, 32);
            this.btnSchemas.TabIndex = 16;
            this.btnSchemas.Text = "Schemas";
            this.btnSchemas.UseVisualStyleBackColor = true;
            this.btnSchemas.Click += new System.EventHandler(this.BtnSchemas_Click);
            // 
            // btnTemplates
            // 
            this.btnTemplates.Location = new System.Drawing.Point(6, 88);
            this.btnTemplates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTemplates.Name = "btnTemplates";
            this.btnTemplates.Size = new System.Drawing.Size(173, 32);
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
            this.txtObjectList.Location = new System.Drawing.Point(188, 32);
            this.txtObjectList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtObjectList.Multiline = true;
            this.txtObjectList.Name = "txtObjectList";
            this.txtObjectList.Size = new System.Drawing.Size(621, 549);
            this.txtObjectList.TabIndex = 18;
            // 
            // lblDownloadResult
            // 
            this.lblDownloadResult.AutoSize = true;
            this.lblDownloadResult.Location = new System.Drawing.Point(9, 231);
            this.lblDownloadResult.Name = "lblDownloadResult";
            this.lblDownloadResult.Size = new System.Drawing.Size(122, 20);
            this.lblDownloadResult.TabIndex = 19;
            this.lblDownloadResult.Text = "Download Result";
            // 
            // lblObjectList
            // 
            this.lblObjectList.AutoSize = true;
            this.lblObjectList.Location = new System.Drawing.Point(185, 8);
            this.lblObjectList.Name = "lblObjectList";
            this.lblObjectList.Size = new System.Drawing.Size(79, 20);
            this.lblObjectList.TabIndex = 20;
            this.lblObjectList.Text = "Object List";
            // 
            // txtLookup
            // 
            this.txtLookup.Location = new System.Drawing.Point(15, 41);
            this.txtLookup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLookup.Name = "txtLookup";
            this.txtLookup.Size = new System.Drawing.Size(199, 27);
            this.txtLookup.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fields";
            // 
            // txtFields
            // 
            this.txtFields.Location = new System.Drawing.Point(15, 98);
            this.txtFields.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFields.Multiline = true;
            this.txtFields.Name = "txtFields";
            this.txtFields.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFields.Size = new System.Drawing.Size(199, 470);
            this.txtFields.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Filter";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(225, 70);
            this.txtFieldName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(259, 27);
            this.txtFieldName.TabIndex = 27;
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.Location = new System.Drawing.Point(225, 226);
            this.btnAddFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(259, 29);
            this.btnAddFilter.TabIndex = 28;
            this.btnAddFilter.Text = "Add Filter";
            this.btnAddFilter.UseVisualStyleBackColor = true;
            this.btnAddFilter.Click += new System.EventHandler(this.btnAddFilter_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(490, 540);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(319, 29);
            this.btnClearFilter.TabIndex = 29;
            this.btnClearFilter.Text = "Clear Filters";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // FieldName
            // 
            this.FieldName.AutoSize = true;
            this.FieldName.Location = new System.Drawing.Point(222, 45);
            this.FieldName.Name = "FieldName";
            this.FieldName.Size = new System.Drawing.Size(85, 20);
            this.FieldName.TabIndex = 30;
            this.FieldName.Text = "Field Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Operator";
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(225, 131);
            this.txtOperator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(259, 27);
            this.txtOperator.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Value";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(225, 191);
            this.txtValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(259, 27);
            this.txtValue.TabIndex = 33;
            // 
            // txtFilterList
            // 
            this.txtFilterList.Location = new System.Drawing.Point(490, 36);
            this.txtFilterList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterList.Multiline = true;
            this.txtFilterList.Name = "txtFilterList";
            this.txtFilterList.ReadOnly = true;
            this.txtFilterList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFilterList.Size = new System.Drawing.Size(319, 495);
            this.txtFilterList.TabIndex = 36;
            // 
            // lblFilterList
            // 
            this.lblFilterList.AutoSize = true;
            this.lblFilterList.Location = new System.Drawing.Point(487, 11);
            this.lblFilterList.Name = "lblFilterList";
            this.lblFilterList.Size = new System.Drawing.Size(61, 20);
            this.lblFilterList.TabIndex = 35;
            this.lblFilterList.Text = "Filterlist";
            // 
            // btnGetLookup
            // 
            this.btnGetLookup.Location = new System.Drawing.Point(225, 482);
            this.btnGetLookup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetLookup.Name = "btnGetLookup";
            this.btnGetLookup.Size = new System.Drawing.Size(259, 86);
            this.btnGetLookup.TabIndex = 37;
            this.btnGetLookup.Text = "Get Objects";
            this.btnGetLookup.UseVisualStyleBackColor = true;
            this.btnGetLookup.Click += new System.EventHandler(this.btnGetLookup_Click);
            // 
            // tabCustomer
            // 
            this.tabCustomer.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.tabCustomer.Controls.Add(this.tabDbBasics);
            this.tabCustomer.Controls.Add(this.tabLookup);
            this.tabCustomer.Controls.Add(this.tabUsers);
            this.tabCustomer.Controls.Add(this.tabCustomers);
            this.tabCustomer.Location = new System.Drawing.Point(523, 256);
            this.tabCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.SelectedIndex = 0;
            this.tabCustomer.Size = new System.Drawing.Size(823, 630);
            this.tabCustomer.TabIndex = 38;
            // 
            // tabDbBasics
            // 
            this.tabDbBasics.Controls.Add(this.btnTemplates);
            this.tabDbBasics.Controls.Add(this.btnSummaries);
            this.tabDbBasics.Controls.Add(this.btnSchemas);
            this.tabDbBasics.Controls.Add(this.txtObjectList);
            this.tabDbBasics.Controls.Add(this.lblObjectList);
            this.tabDbBasics.Location = new System.Drawing.Point(4, 29);
            this.tabDbBasics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabDbBasics.Name = "tabDbBasics";
            this.tabDbBasics.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabDbBasics.Size = new System.Drawing.Size(815, 597);
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
            this.tabLookup.Location = new System.Drawing.Point(4, 29);
            this.tabLookup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabLookup.Name = "tabLookup";
            this.tabLookup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabLookup.Size = new System.Drawing.Size(815, 597);
            this.tabLookup.TabIndex = 1;
            this.tabLookup.Text = "Lookup Tables";
            this.tabLookup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tabel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 120);
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
            this.tabUsers.Location = new System.Drawing.Point(4, 29);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabUsers.Size = new System.Drawing.Size(815, 597);
            this.tabUsers.TabIndex = 2;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // btnGetTeams
            // 
            this.btnGetTeams.Location = new System.Drawing.Point(658, 64);
            this.btnGetTeams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetTeams.Name = "btnGetTeams";
            this.btnGetTeams.Size = new System.Drawing.Size(151, 29);
            this.btnGetTeams.TabIndex = 29;
            this.btnGetTeams.Text = "Get Teams";
            this.btnGetTeams.UseVisualStyleBackColor = true;
            this.btnGetTeams.Click += new System.EventHandler(this.btnGetTeams_Click);
            // 
            // chkStoreIndiviual
            // 
            this.chkStoreIndiviual.AutoSize = true;
            this.chkStoreIndiviual.Location = new System.Drawing.Point(236, 29);
            this.chkStoreIndiviual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkStoreIndiviual.Name = "chkStoreIndiviual";
            this.chkStoreIndiviual.Size = new System.Drawing.Size(195, 24);
            this.chkStoreIndiviual.TabIndex = 28;
            this.chkStoreIndiviual.Text = "Store as indivilual Items?";
            this.chkStoreIndiviual.UseVisualStyleBackColor = true;
            // 
            // txtUserFields
            // 
            this.txtUserFields.Location = new System.Drawing.Point(7, 29);
            this.txtUserFields.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserFields.Multiline = true;
            this.txtUserFields.Name = "txtUserFields";
            this.txtUserFields.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserFields.Size = new System.Drawing.Size(222, 556);
            this.txtUserFields.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fields";
            // 
            // btnGetUsers
            // 
            this.btnGetUsers.Location = new System.Drawing.Point(658, 26);
            this.btnGetUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetUsers.Name = "btnGetUsers";
            this.btnGetUsers.Size = new System.Drawing.Size(151, 29);
            this.btnGetUsers.TabIndex = 0;
            this.btnGetUsers.Text = "Get Users";
            this.btnGetUsers.UseVisualStyleBackColor = true;
            this.btnGetUsers.Click += new System.EventHandler(this.BtnGetUsers_Click);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.label14);
            this.tabCustomers.Controls.Add(this.label13);
            this.tabCustomers.Controls.Add(this.textBox1);
            this.tabCustomers.Controls.Add(this.button1);
            this.tabCustomers.Controls.Add(this.label8);
            this.tabCustomers.Controls.Add(this.label9);
            this.tabCustomers.Controls.Add(this.label10);
            this.tabCustomers.Controls.Add(this.textBox2);
            this.tabCustomers.Controls.Add(this.textBox3);
            this.tabCustomers.Controls.Add(this.label11);
            this.tabCustomers.Controls.Add(this.button2);
            this.tabCustomers.Controls.Add(this.button3);
            this.tabCustomers.Controls.Add(this.textBox4);
            this.tabCustomers.Controls.Add(this.textBox5);
            this.tabCustomers.Controls.Add(this.label12);
            this.tabCustomers.Location = new System.Drawing.Point(4, 29);
            this.tabCustomers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCustomers.Size = new System.Drawing.Size(815, 597);
            this.tabCustomers.TabIndex = 3;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            this.tabCustomers.Click += new System.EventHandler(this.tabCustomers_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(199, 532);
            this.textBox1.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 490);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 86);
            this.button1.TabIndex = 51;
            this.button1.Text = "Get Objects";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(482, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Filterlist";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(217, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Operator";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(485, 44);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(319, 495);
            this.textBox2.TabIndex = 50;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(220, 78);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(259, 27);
            this.textBox3.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "Filter";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 234);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 29);
            this.button2.TabIndex = 43;
            this.button2.Text = "Add Filter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(485, 548);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(319, 29);
            this.button3.TabIndex = 44;
            this.button3.Text = "Clear Filters";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(220, 199);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(259, 27);
            this.textBox4.TabIndex = 47;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(220, 139);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(259, 27);
            this.textBox5.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 120);
            this.label12.TabIndex = 52;
            this.label12.Text =
                "Available operators are:\r\neq - Equals specified value:\r\ngt - Greater than specifi" +
                "ed value\r\nlt - Less than specified value\r\ncontains - Contains specified value\r\ns" +
                "tartswit - Starts with specified value";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 53;
            this.label13.Text = "Fields";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(220, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.TabIndex = 54;
            this.label14.Text = "Field Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 901);
            this.Controls.Add(this.tabCustomer);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1376, 948);
            this.MinimumSize = new System.Drawing.Size(1376, 948);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCustomer.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabCustomer;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}


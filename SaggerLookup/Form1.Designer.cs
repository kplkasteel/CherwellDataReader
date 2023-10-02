namespace SwaggerLookup
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
            components = new System.ComponentModel.Container();
            btnLogin = new System.Windows.Forms.Button();
            txtEndPoint = new System.Windows.Forms.TextBox();
            lblEndPoint = new System.Windows.Forms.Label();
            lblClientID = new System.Windows.Forms.Label();
            txtClientId = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            lblUserName = new System.Windows.Forms.Label();
            txtUserName = new System.Windows.Forms.TextBox();
            txtTokenResponse = new System.Windows.Forms.TextBox();
            progressBar = new System.Windows.Forms.ProgressBar();
            txtResultBox = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            lblDownloadResult = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            tabSearches = new System.Windows.Forms.TabPage();
            tabCustomers = new System.Windows.Forms.TabPage();
            lblCount = new System.Windows.Forms.Label();
            chkStoreAsIndivilual = new System.Windows.Forms.CheckBox();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            txtCustomerFields = new System.Windows.Forms.TextBox();
            txtCustomerFilters = new System.Windows.Forms.TextBox();
            txtCustomerFilterFieldName = new System.Windows.Forms.TextBox();
            txtCustomerFieldValue = new System.Windows.Forms.TextBox();
            txCustomerFieldOperator = new System.Windows.Forms.TextBox();
            btnCustomerGetItems = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            btnCustomerAddFilter = new System.Windows.Forms.Button();
            btnCustomerClearFilters = new System.Windows.Forms.Button();
            label12 = new System.Windows.Forms.Label();
            tabUsers = new System.Windows.Forms.TabPage();
            lblUserTotal = new System.Windows.Forms.Label();
            btnGetTeams = new System.Windows.Forms.Button();
            chkStoreIndiviual = new System.Windows.Forms.CheckBox();
            txtUserFields = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            btnGetUsers = new System.Windows.Forms.Button();
            tabLookup = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            txtFields = new System.Windows.Forms.TextBox();
            txtLookup = new System.Windows.Forms.TextBox();
            txtFilterList = new System.Windows.Forms.TextBox();
            txtFieldName = new System.Windows.Forms.TextBox();
            txtValue = new System.Windows.Forms.TextBox();
            txtOperator = new System.Windows.Forms.TextBox();
            btnGetLookup = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            lblFilterList = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            FieldName = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnAddFilter = new System.Windows.Forms.Button();
            btnClearFilter = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            tabDbBasics = new System.Windows.Forms.TabPage();
            btnOneSteps = new System.Windows.Forms.Button();
            btnSearches = new System.Windows.Forms.Button();
            btnTemplates = new System.Windows.Forms.Button();
            btnSummaries = new System.Windows.Forms.Button();
            btnSchemas = new System.Windows.Forms.Button();
            txtObjectList = new System.Windows.Forms.TextBox();
            lblObjectList = new System.Windows.Forms.Label();
            tabbedPages = new System.Windows.Forms.TabControl();
            tabCustomers.SuspendLayout();
            tabUsers.SuspendLayout();
            tabLookup.SuspendLayout();
            tabDbBasics.SuspendLayout();
            tabbedPages.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogin.Location = new System.Drawing.Point(301, 27);
            btnLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(152, 104);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += Login_Click;
            // 
            // txtEndPoint
            // 
            txtEndPoint.Location = new System.Drawing.Point(10, 27);
            txtEndPoint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtEndPoint.Name = "txtEndPoint";
            txtEndPoint.Size = new System.Drawing.Size(286, 23);
            txtEndPoint.TabIndex = 1;
            txtEndPoint.TextChanged += txtEndPoint_TextChanged;
            // 
            // lblEndPoint
            // 
            lblEndPoint.AutoSize = true;
            lblEndPoint.Location = new System.Drawing.Point(8, 8);
            lblEndPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblEndPoint.Name = "lblEndPoint";
            lblEndPoint.Size = new System.Drawing.Size(55, 15);
            lblEndPoint.TabIndex = 2;
            lblEndPoint.Text = "Endpoint";
            // 
            // lblClientID
            // 
            lblClientID.AutoSize = true;
            lblClientID.Location = new System.Drawing.Point(8, 50);
            lblClientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblClientID.Name = "lblClientID";
            lblClientID.Size = new System.Drawing.Size(49, 15);
            lblClientID.TabIndex = 4;
            lblClientID.Text = "ClientID";
            // 
            // txtClientId
            // 
            txtClientId.Location = new System.Drawing.Point(10, 67);
            txtClientId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtClientId.Name = "txtClientId";
            txtClientId.Size = new System.Drawing.Size(286, 23);
            txtClientId.TabIndex = 3;
            txtClientId.TextChanged += txtClientId_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(8, 132);
            lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(57, 15);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(10, 150);
            txtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(286, 23);
            txtPassword.TabIndex = 7;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new System.Drawing.Point(8, 91);
            lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(62, 15);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "UserName";
            // 
            // txtUserName
            // 
            txtUserName.Location = new System.Drawing.Point(10, 108);
            txtUserName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(286, 23);
            txtUserName.TabIndex = 5;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtTokenResponse
            // 
            txtTokenResponse.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTokenResponse.Location = new System.Drawing.Point(457, 27);
            txtTokenResponse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtTokenResponse.Multiline = true;
            txtTokenResponse.Name = "txtTokenResponse";
            txtTokenResponse.ReadOnly = true;
            txtTokenResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtTokenResponse.Size = new System.Drawing.Size(720, 145);
            txtTokenResponse.TabIndex = 9;
            // 
            // progressBar
            // 
            progressBar.Location = new System.Drawing.Point(301, 150);
            progressBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            progressBar.MarqueeAnimationSpeed = 0;
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(152, 21);
            progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            progressBar.TabIndex = 10;
            // 
            // txtResultBox
            // 
            txtResultBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            txtResultBox.Location = new System.Drawing.Point(10, 192);
            txtResultBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtResultBox.Multiline = true;
            txtResultBox.Name = "txtResultBox";
            txtResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtResultBox.Size = new System.Drawing.Size(443, 419);
            txtResultBox.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnSave.Location = new System.Drawing.Point(10, 622);
            btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(442, 38);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += Save_Click;
            // 
            // lblDownloadResult
            // 
            lblDownloadResult.AutoSize = true;
            lblDownloadResult.Location = new System.Drawing.Point(8, 173);
            lblDownloadResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDownloadResult.Name = "lblDownloadResult";
            lblDownloadResult.Size = new System.Drawing.Size(96, 15);
            lblDownloadResult.TabIndex = 19;
            lblDownloadResult.Text = "Download Result";
            // 
            // tabSearches
            // 
            tabSearches.Location = new System.Drawing.Point(4, 24);
            tabSearches.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabSearches.Name = "tabSearches";
            tabSearches.Size = new System.Drawing.Size(712, 444);
            tabSearches.TabIndex = 4;
            tabSearches.Text = "Searches & OneStep";
            tabSearches.UseVisualStyleBackColor = true;
            // 
            // tabCustomers
            // 
            tabCustomers.Controls.Add(lblCount);
            tabCustomers.Controls.Add(chkStoreAsIndivilual);
            tabCustomers.Controls.Add(label14);
            tabCustomers.Controls.Add(label13);
            tabCustomers.Controls.Add(txtCustomerFields);
            tabCustomers.Controls.Add(txtCustomerFilters);
            tabCustomers.Controls.Add(txtCustomerFilterFieldName);
            tabCustomers.Controls.Add(txtCustomerFieldValue);
            tabCustomers.Controls.Add(txCustomerFieldOperator);
            tabCustomers.Controls.Add(btnCustomerGetItems);
            tabCustomers.Controls.Add(label8);
            tabCustomers.Controls.Add(label9);
            tabCustomers.Controls.Add(label10);
            tabCustomers.Controls.Add(label11);
            tabCustomers.Controls.Add(btnCustomerAddFilter);
            tabCustomers.Controls.Add(btnCustomerClearFilters);
            tabCustomers.Controls.Add(label12);
            tabCustomers.Location = new System.Drawing.Point(4, 24);
            tabCustomers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabCustomers.Name = "tabCustomers";
            tabCustomers.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabCustomers.Size = new System.Drawing.Size(712, 444);
            tabCustomers.TabIndex = 3;
            tabCustomers.Text = "Customers";
            tabCustomers.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new System.Drawing.Point(192, 345);
            lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new System.Drawing.Size(0, 15);
            lblCount.TabIndex = 56;
            // 
            // chkStoreAsIndivilual
            // 
            chkStoreAsIndivilual.AutoSize = true;
            chkStoreAsIndivilual.Location = new System.Drawing.Point(192, 322);
            chkStoreAsIndivilual.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            chkStoreAsIndivilual.Name = "chkStoreAsIndivilual";
            chkStoreAsIndivilual.Size = new System.Drawing.Size(155, 19);
            chkStoreAsIndivilual.TabIndex = 55;
            chkStoreAsIndivilual.Text = "Store as indivilual Items?";
            chkStoreAsIndivilual.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(192, 36);
            label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(67, 15);
            label14.TabIndex = 54;
            label14.Text = "Field Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(9, 14);
            label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(37, 15);
            label13.TabIndex = 53;
            label13.Text = "Fields";
            // 
            // txtCustomerFields
            // 
            txtCustomerFields.Location = new System.Drawing.Point(9, 33);
            txtCustomerFields.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtCustomerFields.Multiline = true;
            txtCustomerFields.Name = "txtCustomerFields";
            txtCustomerFields.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtCustomerFields.Size = new System.Drawing.Size(174, 400);
            txtCustomerFields.TabIndex = 40;
            // 
            // txtCustomerFilters
            // 
            txtCustomerFilters.Location = new System.Drawing.Point(425, 33);
            txtCustomerFilters.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtCustomerFilters.Multiline = true;
            txtCustomerFilters.Name = "txtCustomerFilters";
            txtCustomerFilters.ReadOnly = true;
            txtCustomerFilters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtCustomerFilters.Size = new System.Drawing.Size(279, 372);
            txtCustomerFilters.TabIndex = 50;
            // 
            // txtCustomerFilterFieldName
            // 
            txtCustomerFilterFieldName.Location = new System.Drawing.Point(192, 59);
            txtCustomerFilterFieldName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtCustomerFilterFieldName.Name = "txtCustomerFilterFieldName";
            txtCustomerFilterFieldName.Size = new System.Drawing.Size(227, 23);
            txtCustomerFilterFieldName.TabIndex = 42;
            // 
            // txtCustomerFieldValue
            // 
            txtCustomerFieldValue.Location = new System.Drawing.Point(192, 149);
            txtCustomerFieldValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtCustomerFieldValue.Name = "txtCustomerFieldValue";
            txtCustomerFieldValue.Size = new System.Drawing.Size(227, 23);
            txtCustomerFieldValue.TabIndex = 47;
            // 
            // txCustomerFieldOperator
            // 
            txCustomerFieldOperator.Location = new System.Drawing.Point(192, 104);
            txCustomerFieldOperator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txCustomerFieldOperator.Name = "txCustomerFieldOperator";
            txCustomerFieldOperator.Size = new System.Drawing.Size(227, 23);
            txCustomerFieldOperator.TabIndex = 45;
            // 
            // btnCustomerGetItems
            // 
            btnCustomerGetItems.Location = new System.Drawing.Point(192, 367);
            btnCustomerGetItems.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnCustomerGetItems.Name = "btnCustomerGetItems";
            btnCustomerGetItems.Size = new System.Drawing.Size(226, 65);
            btnCustomerGetItems.TabIndex = 51;
            btnCustomerGetItems.Text = "Get Objects";
            btnCustomerGetItems.UseVisualStyleBackColor = true;
            btnCustomerGetItems.Click += BtnCustomerGetItems_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(190, 127);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(35, 15);
            label8.TabIndex = 48;
            label8.Text = "Value";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(422, 14);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(48, 15);
            label9.TabIndex = 49;
            label9.Text = "Filterlist";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(190, 82);
            label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(54, 15);
            label10.TabIndex = 46;
            label10.Text = "Operator";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(190, 14);
            label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(33, 15);
            label11.TabIndex = 41;
            label11.Text = "Filter";
            // 
            // btnCustomerAddFilter
            // 
            btnCustomerAddFilter.Location = new System.Drawing.Point(192, 175);
            btnCustomerAddFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnCustomerAddFilter.Name = "btnCustomerAddFilter";
            btnCustomerAddFilter.Size = new System.Drawing.Size(226, 22);
            btnCustomerAddFilter.TabIndex = 43;
            btnCustomerAddFilter.Text = "Add Filter";
            btnCustomerAddFilter.UseVisualStyleBackColor = true;
            btnCustomerAddFilter.Click += BtnCustomerAddFilter_Click;
            // 
            // btnCustomerClearFilters
            // 
            btnCustomerClearFilters.Location = new System.Drawing.Point(425, 411);
            btnCustomerClearFilters.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnCustomerClearFilters.Name = "btnCustomerClearFilters";
            btnCustomerClearFilters.Size = new System.Drawing.Size(279, 22);
            btnCustomerClearFilters.TabIndex = 44;
            btnCustomerClearFilters.Text = "Clear Filters";
            btnCustomerClearFilters.UseVisualStyleBackColor = true;
            btnCustomerClearFilters.Click += btnCustomerClearFilters_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(192, 204);
            label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(198, 90);
            label12.TabIndex = 52;
            label12.Text = "Available operators are:\r\neq - Equals specified value:\r\ngt - Greater than specified value\r\nlt - Less than specified value\r\ncontains - Contains specified value\r\nstartswit - Starts with specified value";
            // 
            // tabUsers
            // 
            tabUsers.Controls.Add(lblUserTotal);
            tabUsers.Controls.Add(btnGetTeams);
            tabUsers.Controls.Add(chkStoreIndiviual);
            tabUsers.Controls.Add(txtUserFields);
            tabUsers.Controls.Add(label7);
            tabUsers.Controls.Add(btnGetUsers);
            tabUsers.Location = new System.Drawing.Point(4, 24);
            tabUsers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabUsers.Size = new System.Drawing.Size(712, 444);
            tabUsers.TabIndex = 2;
            tabUsers.Text = "Users";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // lblUserTotal
            // 
            lblUserTotal.AutoSize = true;
            lblUserTotal.Location = new System.Drawing.Point(209, 54);
            lblUserTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUserTotal.Name = "lblUserTotal";
            lblUserTotal.Size = new System.Drawing.Size(0, 15);
            lblUserTotal.TabIndex = 30;
            // 
            // btnGetTeams
            // 
            btnGetTeams.Location = new System.Drawing.Point(576, 48);
            btnGetTeams.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnGetTeams.Name = "btnGetTeams";
            btnGetTeams.Size = new System.Drawing.Size(132, 22);
            btnGetTeams.TabIndex = 29;
            btnGetTeams.Text = "Get Teams";
            btnGetTeams.UseVisualStyleBackColor = true;
            btnGetTeams.Click += btnGetTeams_Click;
            // 
            // chkStoreIndiviual
            // 
            chkStoreIndiviual.AutoSize = true;
            chkStoreIndiviual.Location = new System.Drawing.Point(206, 22);
            chkStoreIndiviual.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            chkStoreIndiviual.Name = "chkStoreIndiviual";
            chkStoreIndiviual.Size = new System.Drawing.Size(155, 19);
            chkStoreIndiviual.TabIndex = 28;
            chkStoreIndiviual.Text = "Store as indivilual Items?";
            chkStoreIndiviual.UseVisualStyleBackColor = true;
            // 
            // txtUserFields
            // 
            txtUserFields.Location = new System.Drawing.Point(6, 22);
            txtUserFields.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtUserFields.Multiline = true;
            txtUserFields.Name = "txtUserFields";
            txtUserFields.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtUserFields.Size = new System.Drawing.Size(195, 418);
            txtUserFields.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(5, 3);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(37, 15);
            label7.TabIndex = 26;
            label7.Text = "Fields";
            // 
            // btnGetUsers
            // 
            btnGetUsers.Location = new System.Drawing.Point(576, 20);
            btnGetUsers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnGetUsers.Name = "btnGetUsers";
            btnGetUsers.Size = new System.Drawing.Size(132, 22);
            btnGetUsers.TabIndex = 0;
            btnGetUsers.Text = "Get Users";
            btnGetUsers.UseVisualStyleBackColor = true;
            btnGetUsers.Click += BtnGetUsers_Click;
            // 
            // tabLookup
            // 
            tabLookup.Controls.Add(label1);
            tabLookup.Controls.Add(txtFields);
            tabLookup.Controls.Add(txtLookup);
            tabLookup.Controls.Add(txtFilterList);
            tabLookup.Controls.Add(txtFieldName);
            tabLookup.Controls.Add(txtValue);
            tabLookup.Controls.Add(txtOperator);
            tabLookup.Controls.Add(btnGetLookup);
            tabLookup.Controls.Add(label5);
            tabLookup.Controls.Add(lblFilterList);
            tabLookup.Controls.Add(label4);
            tabLookup.Controls.Add(FieldName);
            tabLookup.Controls.Add(label3);
            tabLookup.Controls.Add(btnAddFilter);
            tabLookup.Controls.Add(btnClearFilter);
            tabLookup.Controls.Add(label2);
            tabLookup.Controls.Add(label6);
            tabLookup.Location = new System.Drawing.Point(4, 24);
            tabLookup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabLookup.Name = "tabLookup";
            tabLookup.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabLookup.Size = new System.Drawing.Size(712, 444);
            tabLookup.TabIndex = 1;
            tabLookup.Text = "Lookup Tables";
            tabLookup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 8);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 15);
            label1.TabIndex = 38;
            label1.Text = "Tabel";
            // 
            // txtFields
            // 
            txtFields.Location = new System.Drawing.Point(13, 74);
            txtFields.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtFields.Multiline = true;
            txtFields.Name = "txtFields";
            txtFields.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtFields.Size = new System.Drawing.Size(174, 354);
            txtFields.TabIndex = 25;
            // 
            // txtLookup
            // 
            txtLookup.Location = new System.Drawing.Point(13, 31);
            txtLookup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtLookup.Name = "txtLookup";
            txtLookup.Size = new System.Drawing.Size(174, 23);
            txtLookup.TabIndex = 22;
            // 
            // txtFilterList
            // 
            txtFilterList.Location = new System.Drawing.Point(429, 27);
            txtFilterList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtFilterList.Multiline = true;
            txtFilterList.Name = "txtFilterList";
            txtFilterList.ReadOnly = true;
            txtFilterList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtFilterList.Size = new System.Drawing.Size(279, 372);
            txtFilterList.TabIndex = 36;
            // 
            // txtFieldName
            // 
            txtFieldName.Location = new System.Drawing.Point(197, 52);
            txtFieldName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtFieldName.Name = "txtFieldName";
            txtFieldName.Size = new System.Drawing.Size(227, 23);
            txtFieldName.TabIndex = 27;
            // 
            // txtValue
            // 
            txtValue.Location = new System.Drawing.Point(197, 143);
            txtValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtValue.Name = "txtValue";
            txtValue.Size = new System.Drawing.Size(227, 23);
            txtValue.TabIndex = 33;
            // 
            // txtOperator
            // 
            txtOperator.Location = new System.Drawing.Point(197, 98);
            txtOperator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new System.Drawing.Size(227, 23);
            txtOperator.TabIndex = 31;
            // 
            // btnGetLookup
            // 
            btnGetLookup.Location = new System.Drawing.Point(197, 361);
            btnGetLookup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnGetLookup.Name = "btnGetLookup";
            btnGetLookup.Size = new System.Drawing.Size(226, 65);
            btnGetLookup.TabIndex = 37;
            btnGetLookup.Text = "Get Objects";
            btnGetLookup.UseVisualStyleBackColor = true;
            btnGetLookup.Click += btnGetLookup_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(194, 121);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(35, 15);
            label5.TabIndex = 34;
            label5.Text = "Value";
            // 
            // lblFilterList
            // 
            lblFilterList.AutoSize = true;
            lblFilterList.Location = new System.Drawing.Point(426, 8);
            lblFilterList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblFilterList.Name = "lblFilterList";
            lblFilterList.Size = new System.Drawing.Size(48, 15);
            lblFilterList.TabIndex = 35;
            lblFilterList.Text = "Filterlist";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(194, 76);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 15);
            label4.TabIndex = 32;
            label4.Text = "Operator";
            // 
            // FieldName
            // 
            FieldName.AutoSize = true;
            FieldName.Location = new System.Drawing.Point(194, 33);
            FieldName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            FieldName.Name = "FieldName";
            FieldName.Size = new System.Drawing.Size(67, 15);
            FieldName.TabIndex = 30;
            FieldName.Text = "Field Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(194, 8);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 15);
            label3.TabIndex = 26;
            label3.Text = "Filter";
            // 
            // btnAddFilter
            // 
            btnAddFilter.Location = new System.Drawing.Point(197, 170);
            btnAddFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnAddFilter.Name = "btnAddFilter";
            btnAddFilter.Size = new System.Drawing.Size(226, 22);
            btnAddFilter.TabIndex = 28;
            btnAddFilter.Text = "Add Filter";
            btnAddFilter.UseVisualStyleBackColor = true;
            btnAddFilter.Click += BtnAddFilter_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Location = new System.Drawing.Point(429, 405);
            btnClearFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new System.Drawing.Size(279, 22);
            btnClearFilter.TabIndex = 29;
            btnClearFilter.Text = "Clear Filters";
            btnClearFilter.UseVisualStyleBackColor = true;
            btnClearFilter.Click += BtnClearFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 54);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 15);
            label2.TabIndex = 24;
            label2.Text = "Fields";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(197, 198);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(198, 90);
            label6.TabIndex = 39;
            label6.Text = "Available operators are:\r\neq - Equals specified value:\r\ngt - Greater than specified value\r\nlt - Less than specified value\r\ncontains - Contains specified value\r\nstartswit - Starts with specified value";
            // 
            // tabDbBasics
            // 
            tabDbBasics.Controls.Add(btnOneSteps);
            tabDbBasics.Controls.Add(btnSearches);
            tabDbBasics.Controls.Add(btnTemplates);
            tabDbBasics.Controls.Add(btnSummaries);
            tabDbBasics.Controls.Add(btnSchemas);
            tabDbBasics.Controls.Add(txtObjectList);
            tabDbBasics.Controls.Add(lblObjectList);
            tabDbBasics.Location = new System.Drawing.Point(4, 24);
            tabDbBasics.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabDbBasics.Name = "tabDbBasics";
            tabDbBasics.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabDbBasics.Size = new System.Drawing.Size(712, 444);
            tabDbBasics.TabIndex = 0;
            tabDbBasics.Text = "Db basics";
            tabDbBasics.UseVisualStyleBackColor = true;
            // 
            // btnOneSteps
            // 
            btnOneSteps.Location = new System.Drawing.Point(7, 132);
            btnOneSteps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnOneSteps.Name = "btnOneSteps";
            btnOneSteps.Size = new System.Drawing.Size(149, 27);
            btnOneSteps.TabIndex = 22;
            btnOneSteps.Text = "OneSteps";
            btnOneSteps.UseVisualStyleBackColor = true;
            btnOneSteps.Click += btnOneSteps_Click;
            // 
            // btnSearches
            // 
            btnSearches.Location = new System.Drawing.Point(5, 97);
            btnSearches.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSearches.Name = "btnSearches";
            btnSearches.Size = new System.Drawing.Size(152, 27);
            btnSearches.TabIndex = 21;
            btnSearches.Text = "Searches";
            btnSearches.UseVisualStyleBackColor = true;
            btnSearches.Click += btnSearches_Click;
            // 
            // btnTemplates
            // 
            btnTemplates.Location = new System.Drawing.Point(5, 66);
            btnTemplates.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnTemplates.Name = "btnTemplates";
            btnTemplates.Size = new System.Drawing.Size(152, 24);
            btnTemplates.TabIndex = 17;
            btnTemplates.Text = "Templates";
            btnTemplates.UseVisualStyleBackColor = true;
            btnTemplates.Click += BtnTemplates_Click;
            // 
            // btnSummaries
            // 
            btnSummaries.Location = new System.Drawing.Point(5, 6);
            btnSummaries.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnSummaries.Name = "btnSummaries";
            btnSummaries.Size = new System.Drawing.Size(152, 24);
            btnSummaries.TabIndex = 11;
            btnSummaries.Text = "Summaries";
            btnSummaries.UseVisualStyleBackColor = true;
            btnSummaries.Click += btnSummaries_Click;
            // 
            // btnSchemas
            // 
            btnSchemas.Location = new System.Drawing.Point(5, 36);
            btnSchemas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnSchemas.Name = "btnSchemas";
            btnSchemas.Size = new System.Drawing.Size(152, 24);
            btnSchemas.TabIndex = 16;
            btnSchemas.Text = "Schemas";
            btnSchemas.UseVisualStyleBackColor = true;
            btnSchemas.Click += BtnSchemas_Click;
            // 
            // txtObjectList
            // 
            txtObjectList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtObjectList.Location = new System.Drawing.Point(164, 24);
            txtObjectList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtObjectList.Multiline = true;
            txtObjectList.Name = "txtObjectList";
            txtObjectList.Size = new System.Drawing.Size(544, 416);
            txtObjectList.TabIndex = 18;
            // 
            // lblObjectList
            // 
            lblObjectList.AutoSize = true;
            lblObjectList.Location = new System.Drawing.Point(162, 6);
            lblObjectList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblObjectList.Name = "lblObjectList";
            lblObjectList.Size = new System.Drawing.Size(63, 15);
            lblObjectList.TabIndex = 20;
            lblObjectList.Text = "Object List";
            // 
            // tabbedPages
            // 
            tabbedPages.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabbedPages.Controls.Add(tabDbBasics);
            tabbedPages.Controls.Add(tabLookup);
            tabbedPages.Controls.Add(tabUsers);
            tabbedPages.Controls.Add(tabCustomers);
            tabbedPages.Controls.Add(tabSearches);
            tabbedPages.Location = new System.Drawing.Point(457, 192);
            tabbedPages.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabbedPages.Name = "tabbedPages";
            tabbedPages.SelectedIndex = 0;
            tabbedPages.Size = new System.Drawing.Size(720, 472);
            tabbedPages.TabIndex = 38;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1190, 682);
            Controls.Add(tabbedPages);
            Controls.Add(lblDownloadResult);
            Controls.Add(btnSave);
            Controls.Add(txtResultBox);
            Controls.Add(progressBar);
            Controls.Add(txtTokenResponse);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtUserName);
            Controls.Add(lblClientID);
            Controls.Add(txtClientId);
            Controls.Add(lblEndPoint);
            Controls.Add(txtEndPoint);
            Controls.Add(btnLogin);
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            MaximumSize = new System.Drawing.Size(1206, 721);
            MinimumSize = new System.Drawing.Size(1206, 721);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabCustomers.ResumeLayout(false);
            tabCustomers.PerformLayout();
            tabUsers.ResumeLayout(false);
            tabUsers.PerformLayout();
            tabLookup.ResumeLayout(false);
            tabLookup.PerformLayout();
            tabDbBasics.ResumeLayout(false);
            tabDbBasics.PerformLayout();
            tabbedPages.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.TextBox txtResultBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDownloadResult;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tabSearches;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.CheckBox chkStoreAsIndivilual;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCustomerFields;
        private System.Windows.Forms.TextBox txtCustomerFilters;
        private System.Windows.Forms.TextBox txtCustomerFilterFieldName;
        private System.Windows.Forms.TextBox txtCustomerFieldValue;
        private System.Windows.Forms.TextBox txCustomerFieldOperator;
        private System.Windows.Forms.Button btnCustomerGetItems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCustomerAddFilter;
        private System.Windows.Forms.Button btnCustomerClearFilters;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Button btnGetTeams;
        private System.Windows.Forms.CheckBox chkStoreIndiviual;
        private System.Windows.Forms.TextBox txtUserFields;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGetUsers;
        private System.Windows.Forms.TabPage tabLookup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFields;
        private System.Windows.Forms.TextBox txtLookup;
        private System.Windows.Forms.TextBox txtFilterList;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.Button btnGetLookup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFilterList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FieldName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabDbBasics;
        private System.Windows.Forms.Button btnOneSteps;
        private System.Windows.Forms.Button btnSearches;
        private System.Windows.Forms.Button btnTemplates;
        private System.Windows.Forms.Button btnSummaries;
        private System.Windows.Forms.Button btnSchemas;
        private System.Windows.Forms.TextBox txtObjectList;
        private System.Windows.Forms.Label lblObjectList;
        private System.Windows.Forms.TabControl tabbedPages;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblUserTotal;
    }
}


namespace UI
{
    partial class FormProject
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
            this.tabProject = new System.Windows.Forms.TabControl();
            this.tabNewpro = new System.Windows.Forms.TabPage();
            this.tabNew = new System.Windows.Forms.TabControl();
            this.tabInfoProject = new System.Windows.Forms.TabPage();
            this.btnNextInfo = new System.Windows.Forms.Button();
            this.labelDead_pro = new System.Windows.Forms.Label();
            this.labelStart_pro = new System.Windows.Forms.Label();
            this.dtpDead_line = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.labelDis_pro = new System.Windows.Forms.Label();
            this.txtDis_pro = new System.Windows.Forms.TextBox();
            this.labelName_pro = new System.Windows.Forms.Label();
            this.txtName_pro = new System.Windows.Forms.TextBox();
            this.tabTeam = new System.Windows.Forms.TabPage();
            this.txtName_Team = new System.Windows.Forms.TextBox();
            this.labelName_team = new System.Windows.Forms.Label();
            this.dgvTeam = new System.Windows.Forms.DataGridView();
            this.btnBackTeam = new System.Windows.Forms.Button();
            this.btnNextTeam = new System.Windows.Forms.Button();
            this.gboxMember = new System.Windows.Forms.GroupBox();
            this.btnDelmember = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAddmeber = new System.Windows.Forms.Button();
            this.btnAddrole = new System.Windows.Forms.Button();
            this.labelName_mem = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.tabTask = new System.Windows.Forms.TabPage();
            this.btnTaskEnd = new System.Windows.Forms.Button();
            this.btnBackTask = new System.Windows.Forms.Button();
            this.tabLoad = new System.Windows.Forms.TabPage();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.gboxShowTask = new System.Windows.Forms.GroupBox();
            this.dtpTaskStart = new System.Windows.Forms.DateTimePicker();
            this.labelStartTask = new System.Windows.Forms.Label();
            this.dtpTaskEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbAssignee = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.labelAssignee = new System.Windows.Forms.Label();
            this.labelEndTask = new System.Windows.Forms.Label();
            this.txtTaskDesc = new System.Windows.Forms.TextBox();
            this.labelTaskDesc = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.labelTaskTitle = new System.Windows.Forms.Label();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.tabProject.SuspendLayout();
            this.tabNewpro.SuspendLayout();
            this.tabNew.SuspendLayout();
            this.tabInfoProject.SuspendLayout();
            this.tabTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).BeginInit();
            this.gboxMember.SuspendLayout();
            this.tabTask.SuspendLayout();
            this.gboxShowTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProject
            // 
            this.tabProject.Controls.Add(this.tabHome);
            this.tabProject.Controls.Add(this.tabNewpro);
            this.tabProject.Controls.Add(this.tabLoad);
            this.tabProject.Location = new System.Drawing.Point(3, 9);
            this.tabProject.Name = "tabProject";
            this.tabProject.SelectedIndex = 0;
            this.tabProject.Size = new System.Drawing.Size(1041, 509);
            this.tabProject.TabIndex = 4;
            // 
            // tabNewpro
            // 
            this.tabNewpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.tabNewpro.Controls.Add(this.tabNew);
            this.tabNewpro.Location = new System.Drawing.Point(4, 25);
            this.tabNewpro.Name = "tabNewpro";
            this.tabNewpro.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewpro.Size = new System.Drawing.Size(1033, 480);
            this.tabNewpro.TabIndex = 0;
            this.tabNewpro.Text = "New ";
            // 
            // tabNew
            // 
            this.tabNew.Controls.Add(this.tabInfoProject);
            this.tabNew.Controls.Add(this.tabTeam);
            this.tabNew.Controls.Add(this.tabTask);
            this.tabNew.Location = new System.Drawing.Point(8, 3);
            this.tabNew.Name = "tabNew";
            this.tabNew.SelectedIndex = 0;
            this.tabNew.Size = new System.Drawing.Size(1019, 467);
            this.tabNew.TabIndex = 1;
            this.tabNew.SelectedIndexChanged += new System.EventHandler(this.tabNew_SelectedIndexChanged);
            // 
            // tabInfoProject
            // 
            this.tabInfoProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.tabInfoProject.Controls.Add(this.btnNextInfo);
            this.tabInfoProject.Controls.Add(this.labelDead_pro);
            this.tabInfoProject.Controls.Add(this.labelStart_pro);
            this.tabInfoProject.Controls.Add(this.dtpDead_line);
            this.tabInfoProject.Controls.Add(this.dtpStart);
            this.tabInfoProject.Controls.Add(this.labelDis_pro);
            this.tabInfoProject.Controls.Add(this.txtDis_pro);
            this.tabInfoProject.Controls.Add(this.labelName_pro);
            this.tabInfoProject.Controls.Add(this.txtName_pro);
            this.tabInfoProject.Location = new System.Drawing.Point(4, 25);
            this.tabInfoProject.Name = "tabInfoProject";
            this.tabInfoProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfoProject.Size = new System.Drawing.Size(1011, 438);
            this.tabInfoProject.TabIndex = 0;
            this.tabInfoProject.Text = "Information";
            // 
            // btnNextInfo
            // 
            this.btnNextInfo.Location = new System.Drawing.Point(884, 384);
            this.btnNextInfo.Name = "btnNextInfo";
            this.btnNextInfo.Size = new System.Drawing.Size(119, 50);
            this.btnNextInfo.TabIndex = 18;
            this.btnNextInfo.Text = "Next";
            this.btnNextInfo.UseVisualStyleBackColor = true;
            this.btnNextInfo.Click += new System.EventHandler(this.btnNextInfo_Click);
            // 
            // labelDead_pro
            // 
            this.labelDead_pro.AutoSize = true;
            this.labelDead_pro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDead_pro.Location = new System.Drawing.Point(55, 330);
            this.labelDead_pro.Name = "labelDead_pro";
            this.labelDead_pro.Size = new System.Drawing.Size(65, 16);
            this.labelDead_pro.TabIndex = 17;
            this.labelDead_pro.Text = "Dead line";
            // 
            // labelStart_pro
            // 
            this.labelStart_pro.AutoSize = true;
            this.labelStart_pro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStart_pro.Location = new System.Drawing.Point(55, 231);
            this.labelStart_pro.Name = "labelStart_pro";
            this.labelStart_pro.Size = new System.Drawing.Size(37, 16);
            this.labelStart_pro.TabIndex = 16;
            this.labelStart_pro.Text = "Start ";
            // 
            // dtpDead_line
            // 
            this.dtpDead_line.Location = new System.Drawing.Point(59, 355);
            this.dtpDead_line.Name = "dtpDead_line";
            this.dtpDead_line.Size = new System.Drawing.Size(247, 22);
            this.dtpDead_line.TabIndex = 15;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(59, 257);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(247, 22);
            this.dtpStart.TabIndex = 14;
            // 
            // labelDis_pro
            // 
            this.labelDis_pro.AutoSize = true;
            this.labelDis_pro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDis_pro.Location = new System.Drawing.Point(43, 114);
            this.labelDis_pro.Name = "labelDis_pro";
            this.labelDis_pro.Size = new System.Drawing.Size(120, 16);
            this.labelDis_pro.TabIndex = 12;
            this.labelDis_pro.Text = "Discarption Project";
            // 
            // txtDis_pro
            // 
            this.txtDis_pro.Location = new System.Drawing.Point(46, 139);
            this.txtDis_pro.Name = "txtDis_pro";
            this.txtDis_pro.Size = new System.Drawing.Size(311, 22);
            this.txtDis_pro.TabIndex = 13;
            // 
            // labelName_pro
            // 
            this.labelName_pro.AutoSize = true;
            this.labelName_pro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName_pro.Location = new System.Drawing.Point(40, 26);
            this.labelName_pro.Name = "labelName_pro";
            this.labelName_pro.Size = new System.Drawing.Size(89, 16);
            this.labelName_pro.TabIndex = 10;
            this.labelName_pro.Text = "Name Project";
            // 
            // txtName_pro
            // 
            this.txtName_pro.Location = new System.Drawing.Point(44, 51);
            this.txtName_pro.Name = "txtName_pro";
            this.txtName_pro.Size = new System.Drawing.Size(313, 22);
            this.txtName_pro.TabIndex = 11;
            // 
            // tabTeam
            // 
            this.tabTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.tabTeam.Controls.Add(this.txtName_Team);
            this.tabTeam.Controls.Add(this.labelName_team);
            this.tabTeam.Controls.Add(this.dgvTeam);
            this.tabTeam.Controls.Add(this.btnBackTeam);
            this.tabTeam.Controls.Add(this.btnNextTeam);
            this.tabTeam.Controls.Add(this.gboxMember);
            this.tabTeam.Location = new System.Drawing.Point(4, 25);
            this.tabTeam.Name = "tabTeam";
            this.tabTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeam.Size = new System.Drawing.Size(1011, 438);
            this.tabTeam.TabIndex = 1;
            this.tabTeam.Text = "Team";
            // 
            // txtName_Team
            // 
            this.txtName_Team.Location = new System.Drawing.Point(727, 24);
            this.txtName_Team.Name = "txtName_Team";
            this.txtName_Team.Size = new System.Drawing.Size(276, 22);
            this.txtName_Team.TabIndex = 26;
            // 
            // labelName_team
            // 
            this.labelName_team.AutoSize = true;
            this.labelName_team.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName_team.Location = new System.Drawing.Point(724, 6);
            this.labelName_team.Name = "labelName_team";
            this.labelName_team.Size = new System.Drawing.Size(83, 16);
            this.labelName_team.TabIndex = 25;
            this.labelName_team.Text = "Name Team";
            // 
            // dgvTeam
            // 
            this.dgvTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeam.Location = new System.Drawing.Point(6, 3);
            this.dgvTeam.Name = "dgvTeam";
            this.dgvTeam.RowHeadersWidth = 51;
            this.dgvTeam.RowTemplate.Height = 24;
            this.dgvTeam.Size = new System.Drawing.Size(712, 429);
            this.dgvTeam.TabIndex = 22;
            this.dgvTeam.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeam_CellDoubleClick);
            this.dgvTeam.DoubleClick += new System.EventHandler(this.dgvTeam_DoubleClick);
            // 
            // btnBackTeam
            // 
            this.btnBackTeam.Location = new System.Drawing.Point(759, 384);
            this.btnBackTeam.Name = "btnBackTeam";
            this.btnBackTeam.Size = new System.Drawing.Size(119, 50);
            this.btnBackTeam.TabIndex = 21;
            this.btnBackTeam.Text = "Back";
            this.btnBackTeam.UseVisualStyleBackColor = true;
            this.btnBackTeam.Click += new System.EventHandler(this.btnBackTeam_Click);
            // 
            // btnNextTeam
            // 
            this.btnNextTeam.Location = new System.Drawing.Point(884, 384);
            this.btnNextTeam.Name = "btnNextTeam";
            this.btnNextTeam.Size = new System.Drawing.Size(119, 50);
            this.btnNextTeam.TabIndex = 20;
            this.btnNextTeam.Text = "Next";
            this.btnNextTeam.UseVisualStyleBackColor = true;
            this.btnNextTeam.Click += new System.EventHandler(this.btnNextTeam_Click);
            // 
            // gboxMember
            // 
            this.gboxMember.Controls.Add(this.btnDelmember);
            this.gboxMember.Controls.Add(this.labelEmail);
            this.gboxMember.Controls.Add(this.txtEmail);
            this.gboxMember.Controls.Add(this.btnAddmeber);
            this.gboxMember.Controls.Add(this.btnAddrole);
            this.gboxMember.Controls.Add(this.labelName_mem);
            this.gboxMember.Controls.Add(this.cmbRole);
            this.gboxMember.Controls.Add(this.labelRole);
            this.gboxMember.Controls.Add(this.txtMember);
            this.gboxMember.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gboxMember.Location = new System.Drawing.Point(724, 52);
            this.gboxMember.Name = "gboxMember";
            this.gboxMember.Size = new System.Drawing.Size(279, 326);
            this.gboxMember.TabIndex = 19;
            this.gboxMember.TabStop = false;
            this.gboxMember.Text = "Member";
            // 
            // btnDelmember
            // 
            this.btnDelmember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelmember.Location = new System.Drawing.Point(83, 293);
            this.btnDelmember.Name = "btnDelmember";
            this.btnDelmember.Size = new System.Drawing.Size(92, 27);
            this.btnDelmember.TabIndex = 24;
            this.btnDelmember.Text = "Delete Member";
            this.btnDelmember.UseVisualStyleBackColor = true;
            this.btnDelmember.Click += new System.EventHandler(this.btnDelmember_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEmail.Location = new System.Drawing.Point(20, 90);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(94, 16);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email Member";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(23, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 22);
            this.txtEmail.TabIndex = 23;
            // 
            // btnAddmeber
            // 
            this.btnAddmeber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddmeber.Location = new System.Drawing.Point(181, 293);
            this.btnAddmeber.Name = "btnAddmeber";
            this.btnAddmeber.Size = new System.Drawing.Size(92, 27);
            this.btnAddmeber.TabIndex = 21;
            this.btnAddmeber.Text = "Add";
            this.btnAddmeber.UseVisualStyleBackColor = true;
            this.btnAddmeber.Click += new System.EventHandler(this.btnAddmemer_Click);
            // 
            // btnAddrole
            // 
            this.btnAddrole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddrole.Location = new System.Drawing.Point(150, 167);
            this.btnAddrole.Name = "btnAddrole";
            this.btnAddrole.Size = new System.Drawing.Size(22, 23);
            this.btnAddrole.TabIndex = 19;
            this.btnAddrole.Text = "+";
            this.btnAddrole.UseVisualStyleBackColor = true;
            this.btnAddrole.Click += new System.EventHandler(this.btnAddrole_Click);
            // 
            // labelName_mem
            // 
            this.labelName_mem.AutoSize = true;
            this.labelName_mem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName_mem.Location = new System.Drawing.Point(20, 33);
            this.labelName_mem.Name = "labelName_mem";
            this.labelName_mem.Size = new System.Drawing.Size(136, 16);
            this.labelName_mem.TabIndex = 0;
            this.labelName_mem.Text = "Team Member Name";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Lead",
            "Developer",
            "Tester",
            "Designer"});
            this.cmbRole.Location = new System.Drawing.Point(23, 167);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(121, 24);
            this.cmbRole.TabIndex = 18;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRole.Location = new System.Drawing.Point(20, 148);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(108, 16);
            this.labelRole.TabIndex = 16;
            this.labelRole.Text = "Role assignment\r\n";
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(23, 52);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(234, 22);
            this.txtMember.TabIndex = 15;
            // 
            // tabTask
            // 
            this.tabTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.tabTask.Controls.Add(this.dgvTasks);
            this.tabTask.Controls.Add(this.btnTaskEnd);
            this.tabTask.Controls.Add(this.gboxShowTask);
            this.tabTask.Controls.Add(this.btnBackTask);
            this.tabTask.Location = new System.Drawing.Point(4, 25);
            this.tabTask.Name = "tabTask";
            this.tabTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabTask.Size = new System.Drawing.Size(1011, 438);
            this.tabTask.TabIndex = 2;
            this.tabTask.Text = "Task";
            this.tabTask.Click += new System.EventHandler(this.tabTask_Click);
            // 
            // btnTaskEnd
            // 
            this.btnTaskEnd.Location = new System.Drawing.Point(884, 384);
            this.btnTaskEnd.Name = "btnTaskEnd";
            this.btnTaskEnd.Size = new System.Drawing.Size(119, 50);
            this.btnTaskEnd.TabIndex = 17;
            this.btnTaskEnd.Text = "End";
            this.btnTaskEnd.UseVisualStyleBackColor = true;
            this.btnTaskEnd.Click += new System.EventHandler(this.btnTaskEnd_Click);
            // 
            // btnBackTask
            // 
            this.btnBackTask.Location = new System.Drawing.Point(759, 384);
            this.btnBackTask.Name = "btnBackTask";
            this.btnBackTask.Size = new System.Drawing.Size(119, 50);
            this.btnBackTask.TabIndex = 15;
            this.btnBackTask.Text = "Back";
            this.btnBackTask.UseVisualStyleBackColor = true;
            this.btnBackTask.Click += new System.EventHandler(this.btnBackTask_Click);
            // 
            // tabLoad
            // 
            this.tabLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.tabLoad.Location = new System.Drawing.Point(4, 25);
            this.tabLoad.Name = "tabLoad";
            this.tabLoad.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoad.Size = new System.Drawing.Size(1033, 480);
            this.tabLoad.TabIndex = 1;
            this.tabLoad.Text = "Load";
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.tabHome.Location = new System.Drawing.Point(4, 25);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1033, 480);
            this.tabHome.TabIndex = 2;
            this.tabHome.Text = "Home";
            // 
            // gboxShowTask
            // 
            this.gboxShowTask.Controls.Add(this.btnDeleteTask);
            this.gboxShowTask.Controls.Add(this.labelEndTask);
            this.gboxShowTask.Controls.Add(this.cmbAssignee);
            this.gboxShowTask.Controls.Add(this.dtpTaskEnd);
            this.gboxShowTask.Controls.Add(this.labelStartTask);
            this.gboxShowTask.Controls.Add(this.dtpTaskStart);
            this.gboxShowTask.Controls.Add(this.button3);
            this.gboxShowTask.Controls.Add(this.labelTaskTitle);
            this.gboxShowTask.Controls.Add(this.labelAssignee);
            this.gboxShowTask.Controls.Add(this.txtTaskDesc);
            this.gboxShowTask.Controls.Add(this.txtTaskTitle);
            this.gboxShowTask.Controls.Add(this.labelTaskDesc);
            this.gboxShowTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gboxShowTask.Location = new System.Drawing.Point(719, 9);
            this.gboxShowTask.Name = "gboxShowTask";
            this.gboxShowTask.Size = new System.Drawing.Size(284, 369);
            this.gboxShowTask.TabIndex = 16;
            this.gboxShowTask.TabStop = false;
            this.gboxShowTask.Text = "Task";
            // 
            // dtpTaskStart
            // 
            this.dtpTaskStart.Location = new System.Drawing.Point(16, 141);
            this.dtpTaskStart.Name = "dtpTaskStart";
            this.dtpTaskStart.Size = new System.Drawing.Size(236, 22);
            this.dtpTaskStart.TabIndex = 10;
            // 
            // labelStartTask
            // 
            this.labelStartTask.AutoSize = true;
            this.labelStartTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStartTask.Location = new System.Drawing.Point(13, 122);
            this.labelStartTask.Name = "labelStartTask";
            this.labelStartTask.Size = new System.Drawing.Size(34, 16);
            this.labelStartTask.TabIndex = 13;
            this.labelStartTask.Text = "Start";
            // 
            // dtpTaskEnd
            // 
            this.dtpTaskEnd.Location = new System.Drawing.Point(16, 195);
            this.dtpTaskEnd.Name = "dtpTaskEnd";
            this.dtpTaskEnd.Size = new System.Drawing.Size(233, 22);
            this.dtpTaskEnd.TabIndex = 14;
            // 
            // cmbAssignee
            // 
            this.cmbAssignee.FormattingEnabled = true;
            this.cmbAssignee.Location = new System.Drawing.Point(17, 255);
            this.cmbAssignee.Name = "cmbAssignee";
            this.cmbAssignee.Size = new System.Drawing.Size(122, 24);
            this.cmbAssignee.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(168, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 26);
            this.button3.TabIndex = 9;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnSaveTask_Click);
            // 
            // labelAssignee
            // 
            this.labelAssignee.AutoSize = true;
            this.labelAssignee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAssignee.Location = new System.Drawing.Point(13, 236);
            this.labelAssignee.Name = "labelAssignee";
            this.labelAssignee.Size = new System.Drawing.Size(64, 16);
            this.labelAssignee.TabIndex = 9;
            this.labelAssignee.Text = "Assignee";
            // 
            // labelEndTask
            // 
            this.labelEndTask.AutoSize = true;
            this.labelEndTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEndTask.Location = new System.Drawing.Point(14, 176);
            this.labelEndTask.Name = "labelEndTask";
            this.labelEndTask.Size = new System.Drawing.Size(31, 16);
            this.labelEndTask.TabIndex = 15;
            this.labelEndTask.Text = "End";
            // 
            // txtTaskDesc
            // 
            this.txtTaskDesc.Location = new System.Drawing.Point(16, 94);
            this.txtTaskDesc.Multiline = true;
            this.txtTaskDesc.Name = "txtTaskDesc";
            this.txtTaskDesc.Size = new System.Drawing.Size(239, 22);
            this.txtTaskDesc.TabIndex = 5;
            // 
            // labelTaskDesc
            // 
            this.labelTaskDesc.AutoSize = true;
            this.labelTaskDesc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTaskDesc.Location = new System.Drawing.Point(14, 75);
            this.labelTaskDesc.Name = "labelTaskDesc";
            this.labelTaskDesc.Size = new System.Drawing.Size(109, 16);
            this.labelTaskDesc.TabIndex = 4;
            this.labelTaskDesc.Text = "Task Description";
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Location = new System.Drawing.Point(16, 42);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(239, 22);
            this.txtTaskTitle.TabIndex = 3;
            // 
            // labelTaskTitle
            // 
            this.labelTaskTitle.AutoSize = true;
            this.labelTaskTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTaskTitle.Location = new System.Drawing.Point(13, 23);
            this.labelTaskTitle.Name = "labelTaskTitle";
            this.labelTaskTitle.Size = new System.Drawing.Size(64, 16);
            this.labelTaskTitle.TabIndex = 2;
            this.labelTaskTitle.Text = "TaskTitel";
            // 
            // dgvTasks
            // 
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(6, 3);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.RowTemplate.Height = 24;
            this.dgvTasks.Size = new System.Drawing.Size(707, 429);
            this.dgvTasks.TabIndex = 16;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteTask.Location = new System.Drawing.Point(52, 337);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(110, 26);
            this.btnDeleteTask.TabIndex = 16;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1044, 522);
            this.ControlBox = false;
            this.Controls.Add(this.tabProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProject";
            this.Text = "FormProject";
            this.Load += new System.EventHandler(this.FormProject_Load);
            this.tabProject.ResumeLayout(false);
            this.tabNewpro.ResumeLayout(false);
            this.tabNew.ResumeLayout(false);
            this.tabInfoProject.ResumeLayout(false);
            this.tabInfoProject.PerformLayout();
            this.tabTeam.ResumeLayout(false);
            this.tabTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).EndInit();
            this.gboxMember.ResumeLayout(false);
            this.gboxMember.PerformLayout();
            this.tabTask.ResumeLayout(false);
            this.gboxShowTask.ResumeLayout(false);
            this.gboxShowTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProject;
        private System.Windows.Forms.TabPage tabNewpro;
        private System.Windows.Forms.TabControl tabNew;
        private System.Windows.Forms.TabPage tabInfoProject;
        private System.Windows.Forms.Button btnNextInfo;
        private System.Windows.Forms.Label labelDead_pro;
        private System.Windows.Forms.Label labelStart_pro;
        private System.Windows.Forms.DateTimePicker dtpDead_line;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label labelDis_pro;
        private System.Windows.Forms.TextBox txtDis_pro;
        private System.Windows.Forms.Label labelName_pro;
        private System.Windows.Forms.TextBox txtName_pro;
        private System.Windows.Forms.TabPage tabTeam;
        private System.Windows.Forms.TextBox txtName_Team;
        private System.Windows.Forms.Label labelName_team;
        private System.Windows.Forms.DataGridView dgvTeam;
        private System.Windows.Forms.Button btnBackTeam;
        private System.Windows.Forms.Button btnNextTeam;
        private System.Windows.Forms.GroupBox gboxMember;
        private System.Windows.Forms.Button btnDelmember;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAddmeber;
        private System.Windows.Forms.Button btnAddrole;
        private System.Windows.Forms.Label labelName_mem;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.TabPage tabTask;
        private System.Windows.Forms.Button btnBackTask;
        private System.Windows.Forms.TabPage tabLoad;
        private System.Windows.Forms.Button btnTaskEnd;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.GroupBox gboxShowTask;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Label labelEndTask;
        private System.Windows.Forms.ComboBox cmbAssignee;
        private System.Windows.Forms.DateTimePicker dtpTaskEnd;
        private System.Windows.Forms.Label labelStartTask;
        private System.Windows.Forms.DateTimePicker dtpTaskStart;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelTaskTitle;
        private System.Windows.Forms.Label labelAssignee;
        private System.Windows.Forms.TextBox txtTaskDesc;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.Label labelTaskDesc;
        private System.Windows.Forms.Button btnDeleteTask;
    }
}
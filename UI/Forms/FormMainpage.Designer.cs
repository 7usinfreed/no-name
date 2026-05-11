namespace UI
{
    partial class FormMainpage
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
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
           // this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBack_team = new System.Windows.Forms.Button();
            this.btnNext_team = new System.Windows.Forms.Button();
            this.gboxMember = new System.Windows.Forms.GroupBox();
            this.btnDelmember = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddmemer = new System.Windows.Forms.Button();
            this.txtAddrole = new System.Windows.Forms.TextBox();
            this.btnAddrole = new System.Windows.Forms.Button();
            this.labelName_mem = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.tabTask = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelprocessing = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTaskTitle = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
           // this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelTaskDis = new System.Windows.Forms.Label();
            this.labelAssignee = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelLevelShow = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.tabLoad = new System.Windows.Forms.TabPage();
            this.tabProject.SuspendLayout();
            this.tabNewpro.SuspendLayout();
            this.tabNew.SuspendLayout();
            this.tabInfoProject.SuspendLayout();
            this.tabTeam.SuspendLayout();
          //  ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gboxMember.SuspendLayout();
            this.tabTask.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProject
            // 
            this.tabProject.Controls.Add(this.tabNewpro);
            this.tabProject.Controls.Add(this.tabLoad);
            this.tabProject.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProject.Location = new System.Drawing.Point(3, 11);
            this.tabProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProject.Name = "tabProject";
            this.tabProject.SelectedIndex = 0;
            this.tabProject.Size = new System.Drawing.Size(1171, 604);
            this.tabProject.TabIndex = 4;
            // 
            // tabNewpro
            // 
            this.tabNewpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.tabNewpro.Controls.Add(this.tabNew);
            this.tabNewpro.Location = new System.Drawing.Point(4, 34);
            this.tabNewpro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabNewpro.Name = "tabNewpro";
            this.tabNewpro.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabNewpro.Size = new System.Drawing.Size(1163, 566);
            this.tabNewpro.TabIndex = 0;
            this.tabNewpro.Text = "New ";
            // 
            // tabNew
            // 
            this.tabNew.Controls.Add(this.tabInfoProject);
            this.tabNew.Controls.Add(this.tabTeam);
            this.tabNew.Controls.Add(this.tabTask);
            this.tabNew.Location = new System.Drawing.Point(9, 4);
            this.tabNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabNew.Name = "tabNew";
            this.tabNew.SelectedIndex = 0;
            this.tabNew.Size = new System.Drawing.Size(1146, 555);
            this.tabNew.TabIndex = 1;
            // 
            // tabInfoProject
            // 
            this.tabInfoProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.tabInfoProject.Controls.Add(this.button7);
            this.tabInfoProject.Controls.Add(this.button1);
            this.tabInfoProject.Controls.Add(this.labelDead_pro);
            this.tabInfoProject.Controls.Add(this.labelStart_pro);
            this.tabInfoProject.Controls.Add(this.dtpDead_line);
            this.tabInfoProject.Controls.Add(this.dtpStart);
            this.tabInfoProject.Controls.Add(this.labelDis_pro);
            this.tabInfoProject.Controls.Add(this.txtDis_pro);
            this.tabInfoProject.Controls.Add(this.labelName_pro);
            this.tabInfoProject.Controls.Add(this.txtName_pro);
            this.tabInfoProject.Location = new System.Drawing.Point(4, 34);
            this.tabInfoProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabInfoProject.Name = "tabInfoProject";
            this.tabInfoProject.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabInfoProject.Size = new System.Drawing.Size(1138, 517);
            this.tabInfoProject.TabIndex = 0;
            this.tabInfoProject.Text = "Information";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(854, 456);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 59);
            this.button7.TabIndex = 28;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(994, 456);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 59);
            this.button1.TabIndex = 18;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelDead_pro
            // 
            this.labelDead_pro.AutoSize = true;
            this.labelDead_pro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDead_pro.Location = new System.Drawing.Point(62, 392);
            this.labelDead_pro.Name = "labelDead_pro";
            this.labelDead_pro.Size = new System.Drawing.Size(92, 25);
            this.labelDead_pro.TabIndex = 17;
            this.labelDead_pro.Text = "Dead line";
            // 
            // labelStart_pro
            // 
            this.labelStart_pro.AutoSize = true;
            this.labelStart_pro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStart_pro.Location = new System.Drawing.Point(62, 274);
            this.labelStart_pro.Name = "labelStart_pro";
            this.labelStart_pro.Size = new System.Drawing.Size(58, 25);
            this.labelStart_pro.TabIndex = 16;
            this.labelStart_pro.Text = "Start ";
            // 
            // dtpDead_line
            // 
            this.dtpDead_line.Location = new System.Drawing.Point(66, 422);
            this.dtpDead_line.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDead_line.Name = "dtpDead_line";
            this.dtpDead_line.Size = new System.Drawing.Size(277, 30);
            this.dtpDead_line.TabIndex = 15;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(66, 305);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(277, 30);
            this.dtpStart.TabIndex = 14;
            // 
            // labelDis_pro
            // 
            this.labelDis_pro.AutoSize = true;
            this.labelDis_pro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDis_pro.Location = new System.Drawing.Point(48, 135);
            this.labelDis_pro.Name = "labelDis_pro";
            this.labelDis_pro.Size = new System.Drawing.Size(174, 25);
            this.labelDis_pro.TabIndex = 12;
            this.labelDis_pro.Text = "Discarption Project";
            // 
            // txtDis_pro
            // 
            this.txtDis_pro.Location = new System.Drawing.Point(52, 165);
            this.txtDis_pro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDis_pro.Name = "txtDis_pro";
            this.txtDis_pro.Size = new System.Drawing.Size(349, 30);
            this.txtDis_pro.TabIndex = 13;
            // 
            // labelName_pro
            // 
            this.labelName_pro.AutoSize = true;
            this.labelName_pro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName_pro.Location = new System.Drawing.Point(45, 31);
            this.labelName_pro.Name = "labelName_pro";
            this.labelName_pro.Size = new System.Drawing.Size(127, 25);
            this.labelName_pro.TabIndex = 10;
            this.labelName_pro.Text = "Name Project";
            // 
            // txtName_pro
            // 
            this.txtName_pro.Location = new System.Drawing.Point(50, 61);
            this.txtName_pro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName_pro.Name = "txtName_pro";
            this.txtName_pro.Size = new System.Drawing.Size(352, 30);
            this.txtName_pro.TabIndex = 11;
            // 
            // tabTeam
            // 
            this.tabTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.tabTeam.Controls.Add(this.txtName_Team);
            this.tabTeam.Controls.Add(this.labelName_team);
            //this.tabTeam.Controls.Add(this.dataGridView1);
            this.tabTeam.Controls.Add(this.btnBack_team);
            this.tabTeam.Controls.Add(this.btnNext_team);
            this.tabTeam.Controls.Add(this.gboxMember);
            this.tabTeam.Location = new System.Drawing.Point(4, 34);
            this.tabTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTeam.Name = "tabTeam";
            this.tabTeam.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTeam.Size = new System.Drawing.Size(1138, 517);
            this.tabTeam.TabIndex = 1;
            this.tabTeam.Text = "Team";
            // 
            // txtName_Team
            // 
            this.txtName_Team.Location = new System.Drawing.Point(713, 69);
            this.txtName_Team.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName_Team.Name = "txtName_Team";
            this.txtName_Team.Size = new System.Drawing.Size(415, 30);
            this.txtName_Team.TabIndex = 26;
            // 
            // labelName_team
            // 
            this.labelName_team.AutoSize = true;
            this.labelName_team.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName_team.Location = new System.Drawing.Point(713, 46);
            this.labelName_team.Name = "labelName_team";
            this.labelName_team.Size = new System.Drawing.Size(114, 25);
            this.labelName_team.TabIndex = 25;
            this.labelName_team.Text = "Name Team";
            // 
            // dataGridView1
            // 
            //this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            //this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            //this.dataGridView1.Name = "dataGridView1";
            //this.dataGridView1.RowHeadersWidth = 51;
            //this.dataGridView1.RowTemplate.Height = 24;
            //this.dataGridView1.Size = new System.Drawing.Size(700, 508);
            //this.dataGridView1.TabIndex = 22;
            // 
            // btnBack_team
            // 
            this.btnBack_team.Location = new System.Drawing.Point(854, 456);
            this.btnBack_team.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack_team.Name = "btnBack_team";
            this.btnBack_team.Size = new System.Drawing.Size(134, 59);
            this.btnBack_team.TabIndex = 21;
            this.btnBack_team.Text = "Back";
            this.btnBack_team.UseVisualStyleBackColor = true;
            // 
            // btnNext_team
            // 
            this.btnNext_team.Location = new System.Drawing.Point(994, 456);
            this.btnNext_team.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext_team.Name = "btnNext_team";
            this.btnNext_team.Size = new System.Drawing.Size(134, 59);
            this.btnNext_team.TabIndex = 20;
            this.btnNext_team.Text = "Next";
            this.btnNext_team.UseVisualStyleBackColor = true;
            // 
            // gboxMember
            // 
            this.gboxMember.Controls.Add(this.btnDelmember);
            this.gboxMember.Controls.Add(this.labelEmail);
            this.gboxMember.Controls.Add(this.textBox1);
            this.gboxMember.Controls.Add(this.btnAddmemer);
            this.gboxMember.Controls.Add(this.txtAddrole);
            this.gboxMember.Controls.Add(this.btnAddrole);
            this.gboxMember.Controls.Add(this.labelName_mem);
            this.gboxMember.Controls.Add(this.comboBox1);
            this.gboxMember.Controls.Add(this.labelRole);
            this.gboxMember.Controls.Add(this.txtMember);
            this.gboxMember.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gboxMember.Location = new System.Drawing.Point(713, 129);
            this.gboxMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxMember.Name = "gboxMember";
            this.gboxMember.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxMember.Size = new System.Drawing.Size(415, 319);
            this.gboxMember.TabIndex = 19;
            this.gboxMember.TabStop = false;
            this.gboxMember.Text = "Member";
            // 
            // btnDelmember
            // 
            this.btnDelmember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelmember.Location = new System.Drawing.Point(112, 273);
            this.btnDelmember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelmember.Name = "btnDelmember";
            this.btnDelmember.Size = new System.Drawing.Size(124, 27);
            this.btnDelmember.TabIndex = 24;
            this.btnDelmember.Text = "Delete Member";
            this.btnDelmember.UseVisualStyleBackColor = true;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEmail.Location = new System.Drawing.Point(22, 107);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(134, 25);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email Member";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 129);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 30);
            this.textBox1.TabIndex = 23;
            // 
            // btnAddmemer
            // 
            this.btnAddmemer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddmemer.Location = new System.Drawing.Point(254, 273);
            this.btnAddmemer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddmemer.Name = "btnAddmemer";
            this.btnAddmemer.Size = new System.Drawing.Size(124, 27);
            this.btnAddmemer.TabIndex = 21;
            this.btnAddmemer.Text = "Add Member";
            this.btnAddmemer.UseVisualStyleBackColor = true;
            // 
            // txtAddrole
            // 
            this.txtAddrole.Location = new System.Drawing.Point(169, 201);
            this.txtAddrole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddrole.Name = "txtAddrole";
            this.txtAddrole.Size = new System.Drawing.Size(112, 30);
            this.txtAddrole.TabIndex = 20;
            this.txtAddrole.Visible = false;
            // 
            // btnAddrole
            // 
            this.btnAddrole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddrole.Location = new System.Drawing.Point(169, 198);
            this.btnAddrole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddrole.Name = "btnAddrole";
            this.btnAddrole.Size = new System.Drawing.Size(25, 27);
            this.btnAddrole.TabIndex = 19;
            this.btnAddrole.Text = "+";
            this.btnAddrole.UseVisualStyleBackColor = true;
            // 
            // labelName_mem
            // 
            this.labelName_mem.AutoSize = true;
            this.labelName_mem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName_mem.Location = new System.Drawing.Point(22, 39);
            this.labelName_mem.Name = "labelName_mem";
            this.labelName_mem.Size = new System.Drawing.Size(190, 25);
            this.labelName_mem.TabIndex = 0;
            this.labelName_mem.Text = "Team Member Name";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lead",
            "Developer",
            "Tester",
            "Designer"});
            this.comboBox1.Location = new System.Drawing.Point(26, 198);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 33);
            this.comboBox1.TabIndex = 18;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRole.Location = new System.Drawing.Point(22, 176);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(152, 25);
            this.labelRole.TabIndex = 16;
            this.labelRole.Text = "Role assignment\r\n";
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(26, 62);
            this.txtMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(352, 30);
            this.txtMember.TabIndex = 15;
            // 
            // tabTask
            // 
            this.tabTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.tabTask.Controls.Add(this.groupBox1);
            this.tabTask.Controls.Add(this.button5);
            this.tabTask.Controls.Add(this.button4);
            this.tabTask.Controls.Add(this.dataGridView2);
            this.tabTask.Controls.Add(this.labelLevelShow);
            this.tabTask.Controls.Add(this.comboBox4);
            this.tabTask.Location = new System.Drawing.Point(4, 34);
            this.tabTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTask.Name = "tabTask";
            this.tabTask.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTask.Size = new System.Drawing.Size(1138, 517);
            this.tabTask.TabIndex = 2;
            this.tabTask.Text = "Task";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelprocessing);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelTaskTitle);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
//            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.labelLevel);
            this.groupBox1.Controls.Add(this.labelTaskDis);
            this.groupBox1.Controls.Add(this.labelAssignee);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(395, 506);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task info";
            // 
            // labelprocessing
            // 
            this.labelprocessing.AutoSize = true;
            this.labelprocessing.Location = new System.Drawing.Point(17, 381);
            this.labelprocessing.Name = "labelprocessing";
            this.labelprocessing.Size = new System.Drawing.Size(103, 25);
            this.labelprocessing.TabIndex = 8;
            this.labelprocessing.Text = "processing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "End";
            // 
            // labelTaskTitle
            // 
            this.labelTaskTitle.AutoSize = true;
            this.labelTaskTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTaskTitle.Location = new System.Drawing.Point(17, 237);
            this.labelTaskTitle.Name = "labelTaskTitle";
            this.labelTaskTitle.Size = new System.Drawing.Size(89, 25);
            this.labelTaskTitle.TabIndex = 2;
            this.labelTaskTitle.Text = "TaskTitel";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(168, 55);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(183, 33);
            this.comboBox3.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Pending",
            " InProgress",
            "Done"});
            this.comboBox2.Location = new System.Drawing.Point(22, 411);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(98, 33);
            this.comboBox2.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(14, 190);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(273, 30);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // label2
            // 
            //this.label2.AutoSize = true;
            //this.label2.Location = new System.Drawing.Point(8, 97);
            //this.label2.Name = "label2";
            //this.label2.Size = new System.Drawing.Size(51, 25);
            //this.label2.TabIndex = 13;
            //this.label2.Text = "start";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(14, 57);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(118, 30);
            this.numericUpDown1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 339);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(266, 25);
            this.textBox3.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 126);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 30);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 266);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(267, 30);
            this.textBox2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(258, 450);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 49);
            this.button3.TabIndex = 9;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLevel.Location = new System.Drawing.Point(10, 28);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(100, 25);
            this.labelLevel.TabIndex = 1;
            this.labelLevel.Text = "Task Level";
            // 
            // labelTaskDis
            // 
            this.labelTaskDis.AutoSize = true;
            this.labelTaskDis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTaskDis.Location = new System.Drawing.Point(17, 310);
            this.labelTaskDis.Name = "labelTaskDis";
            this.labelTaskDis.Size = new System.Drawing.Size(153, 25);
            this.labelTaskDis.TabIndex = 4;
            this.labelTaskDis.Text = "Task Description";
            // 
            // labelAssignee
            // 
            this.labelAssignee.AutoSize = true;
            this.labelAssignee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAssignee.Location = new System.Drawing.Point(164, 32);
            this.labelAssignee.Name = "labelAssignee";
            this.labelAssignee.Size = new System.Drawing.Size(88, 25);
            this.labelAssignee.TabIndex = 9;
            this.labelAssignee.Text = "Assignee";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(987, 457);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 59);
            this.button5.TabIndex = 15;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(848, 50);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 33);
            this.button4.TabIndex = 14;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(408, 86);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(709, 365);
            this.dataGridView2.TabIndex = 13;
            // 
            // labelLevelShow
            // 
            this.labelLevelShow.AutoSize = true;
            this.labelLevelShow.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.labelLevelShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLevelShow.Location = new System.Drawing.Point(408, 21);
            this.labelLevelShow.Name = "labelLevelShow";
            this.labelLevelShow.Size = new System.Drawing.Size(56, 25);
            this.labelLevelShow.TabIndex = 11;
            this.labelLevelShow.Text = "Level";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(412, 50);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(430, 33);
            this.comboBox4.TabIndex = 11;
            // 
            // tabLoad
            // 
            this.tabLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.tabLoad.Location = new System.Drawing.Point(4, 34);
            this.tabLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabLoad.Name = "tabLoad";
            this.tabLoad.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabLoad.Size = new System.Drawing.Size(1163, 566);
            this.tabLoad.TabIndex = 1;
            this.tabLoad.Text = "Load";
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1174, 620);
            this.ControlBox = false;
            this.Controls.Add(this.tabProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormProject";
            this.Text = "FormProject";
            this.tabProject.ResumeLayout(false);
            this.tabNewpro.ResumeLayout(false);
            this.tabNew.ResumeLayout(false);
            this.tabInfoProject.ResumeLayout(false);
            this.tabInfoProject.PerformLayout();
            this.tabTeam.ResumeLayout(false);
            this.tabTeam.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gboxMember.ResumeLayout(false);
            this.gboxMember.PerformLayout();
            this.tabTask.ResumeLayout(false);
            this.tabTask.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProject;
        private System.Windows.Forms.TabPage tabNewpro;
        private System.Windows.Forms.TabControl tabNew;
        private System.Windows.Forms.TabPage tabInfoProject;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.Button btnBack_team;
        private System.Windows.Forms.Button btnNext_team;
        private System.Windows.Forms.GroupBox gboxMember;
        private System.Windows.Forms.Button btnDelmember;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddmemer;
        private System.Windows.Forms.TextBox txtAddrole;
        private System.Windows.Forms.Button btnAddrole;
        private System.Windows.Forms.Label labelName_mem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.TabPage tabTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelprocessing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTaskTitle;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelTaskDis;
        private System.Windows.Forms.Label labelAssignee;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelLevelShow;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TabPage tabLoad;
    }
}
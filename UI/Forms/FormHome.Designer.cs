namespace UI
{
    partial class FormHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabstatus = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pboxCompleted = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pboxReamaining = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMembers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pboxTotalMember = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalTasks = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pboxTotalTask = new System.Windows.Forms.PictureBox();
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mangDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mangDataSet = new UI.mangDataSet();
            this.membersTableAdapter = new UI.mangDataSetTableAdapters.membersTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabstatus.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCompleted)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxReamaining)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTotalMember)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTotalTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabstatus);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1253, 626);
            this.tabControl1.TabIndex = 0;
            // 
            // tabstatus
            // 
            this.tabstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.tabstatus.Controls.Add(this.panel4);
            this.tabstatus.Controls.Add(this.panel3);
            this.tabstatus.Controls.Add(this.panel2);
            this.tabstatus.Controls.Add(this.panel1);
            this.tabstatus.Controls.Add(this.dgvStatus);
            this.tabstatus.Controls.Add(this.cartesianChart1);
            this.tabstatus.Controls.Add(this.pieChart1);
            this.tabstatus.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabstatus.Location = new System.Drawing.Point(4, 34);
            this.tabstatus.Name = "tabstatus";
            this.tabstatus.Padding = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.tabstatus.Size = new System.Drawing.Size(1245, 588);
            this.tabstatus.TabIndex = 0;
            this.tabstatus.Text = "Status";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.panel4.Controls.Add(this.lblCompleted);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.pboxCompleted);
            this.panel4.Location = new System.Drawing.Point(36, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 85);
            this.panel4.TabIndex = 3;
            // 
            // lblCompleted
            // 
            this.lblCompleted.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCompleted.Location = new System.Drawing.Point(112, 46);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(51, 21);
            this.lblCompleted.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(70, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "Completed";
            // 
            // pboxCompleted
            // 
            this.pboxCompleted.Image = global::UI.Properties.Resources.clipboard_check_1_;
            this.pboxCompleted.Location = new System.Drawing.Point(8, 17);
            this.pboxCompleted.Name = "pboxCompleted";
            this.pboxCompleted.Size = new System.Drawing.Size(56, 50);
            this.pboxCompleted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCompleted.TabIndex = 0;
            this.pboxCompleted.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.lblRemaining);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pboxReamaining);
            this.panel3.Location = new System.Drawing.Point(287, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 85);
            this.panel3.TabIndex = 3;
            // 
            // lblRemaining
            // 
            this.lblRemaining.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRemaining.Location = new System.Drawing.Point(112, 46);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(51, 21);
            this.lblRemaining.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(70, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Reamaining";
            // 
            // pboxReamaining
            // 
            this.pboxReamaining.Image = global::UI.Properties.Resources.time_fast;
            this.pboxReamaining.Location = new System.Drawing.Point(8, 17);
            this.pboxReamaining.Name = "pboxReamaining";
            this.pboxReamaining.Size = new System.Drawing.Size(56, 50);
            this.pboxReamaining.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxReamaining.TabIndex = 0;
            this.pboxReamaining.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.lblMembers);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pboxTotalMember);
            this.panel2.Location = new System.Drawing.Point(287, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 85);
            this.panel2.TabIndex = 3;
            // 
            // lblMembers
            // 
            this.lblMembers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMembers.Location = new System.Drawing.Point(117, 46);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(51, 21);
            this.lblMembers.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(65, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Member";
            // 
            // pboxTotalMember
            // 
            this.pboxTotalMember.Image = global::UI.Properties.Resources.team_check_1_;
            this.pboxTotalMember.Location = new System.Drawing.Point(3, 17);
            this.pboxTotalMember.Name = "pboxTotalMember";
            this.pboxTotalMember.Size = new System.Drawing.Size(70, 65);
            this.pboxTotalMember.TabIndex = 0;
            this.pboxTotalMember.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.lblTotalTasks);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pboxTotalTask);
            this.panel1.Location = new System.Drawing.Point(36, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 85);
            this.panel1.TabIndex = 3;
            // 
            // lblTotalTasks
            // 
            this.lblTotalTasks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTasks.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalTasks.Location = new System.Drawing.Point(112, 46);
            this.lblTotalTasks.Name = "lblTotalTasks";
            this.lblTotalTasks.Size = new System.Drawing.Size(51, 21);
            this.lblTotalTasks.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(70, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Tasks";
            // 
            // pboxTotalTask
            // 
            this.pboxTotalTask.Image = global::UI.Properties.Resources.task_checklist_3_;
            this.pboxTotalTask.Location = new System.Drawing.Point(8, 17);
            this.pboxTotalTask.Name = "pboxTotalTask";
            this.pboxTotalTask.Size = new System.Drawing.Size(56, 50);
            this.pboxTotalTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxTotalTask.TabIndex = 0;
            this.pboxTotalTask.TabStop = false;
            // 
            // dgvStatus
            // 
            this.dgvStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStatus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStatus.EnableHeadersVisualStyles = false;
            this.dgvStatus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvStatus.Location = new System.Drawing.Point(475, 351);
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.RowHeadersWidth = 62;
            this.dgvStatus.RowTemplate.Height = 29;
            this.dgvStatus.Size = new System.Drawing.Size(741, 207);
            this.dgvStatus.TabIndex = 2;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(665, 3);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(528, 317);
            this.cartesianChart1.TabIndex = 1;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(15, 246);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(345, 324);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1245, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Team";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1245, 588);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Tasks";
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "members";
            this.membersBindingSource.DataSource = this.mangDataSetBindingSource;
            // 
            // mangDataSetBindingSource
            // 
            this.mangDataSetBindingSource.DataSource = this.mangDataSet;
            this.mangDataSetBindingSource.Position = 0;
            // 
            // mangDataSet
            // 
            this.mangDataSet.DataSetName = "mangDataSet";
            this.mangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1253, 626);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabstatus.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCompleted)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxReamaining)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxTotalMember)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxTotalTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabstatus;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.BindingSource mangDataSetBindingSource;
        private mangDataSet mangDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private mangDataSetTableAdapters.membersTableAdapter membersTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pboxTotalTask;
        private System.Windows.Forms.Label lblTotalTasks;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pboxCompleted;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pboxReamaining;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pboxTotalMember;
    }
}
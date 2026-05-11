namespace UI
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
            this.panelbtn = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSitting = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnProject = new System.Windows.Forms.Button();
            this.panelhome = new System.Windows.Forms.Panel();
            this.minimizedbox = new System.Windows.Forms.PictureBox();
            this.Closebox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelcont = new System.Windows.Forms.Panel();
            this.panelbtn.SuspendLayout();
            this.panelhome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizedbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closebox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelbtn
            // 
            this.panelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panelbtn.Controls.Add(this.btnHome);
            this.panelbtn.Controls.Add(this.panel2);
            this.panelbtn.Controls.Add(this.btnSitting);
            this.panelbtn.Controls.Add(this.btnEdit);
            this.panelbtn.Controls.Add(this.btnProject);
            this.panelbtn.Location = new System.Drawing.Point(0, 99);
            this.panelbtn.Name = "panelbtn";
            this.panelbtn.Size = new System.Drawing.Size(234, 626);
            this.panelbtn.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btnHome.Image = global::UI.Properties.Resources.master_plan;
            this.btnHome.Location = new System.Drawing.Point(-7, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(244, 68);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Project";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(243, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1247, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnSitting
            // 
            this.btnSitting.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSitting.FlatAppearance.BorderSize = 0;
            this.btnSitting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSitting.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.btnSitting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btnSitting.Image = global::UI.Properties.Resources.settings_1_;
            this.btnSitting.Location = new System.Drawing.Point(-7, 181);
            this.btnSitting.Name = "btnSitting";
            this.btnSitting.Size = new System.Drawing.Size(244, 68);
            this.btnSitting.TabIndex = 1;
            this.btnSitting.Text = "Sittings";
            this.btnSitting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSitting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSitting.UseVisualStyleBackColor = true;
            this.btnSitting.Click += new System.EventHandler(this.btnSitting_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btnEdit.Image = global::UI.Properties.Resources.square_pen;
            this.btnEdit.Location = new System.Drawing.Point(-7, 120);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(244, 65);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnProject
            // 
            this.btnProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProject.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnProject.FlatAppearance.BorderSize = 0;
            this.btnProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProject.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btnProject.Image = global::UI.Properties.Resources.home;
            this.btnProject.Location = new System.Drawing.Point(-7, 61);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(244, 67);
            this.btnProject.TabIndex = 1;
            this.btnProject.Text = "Home";
            this.btnProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // panelhome
            // 
            this.panelhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panelhome.Controls.Add(this.minimizedbox);
            this.panelhome.Controls.Add(this.Closebox);
            this.panelhome.Controls.Add(this.label1);
            this.panelhome.Location = new System.Drawing.Point(237, 0);
            this.panelhome.Name = "panelhome";
            this.panelhome.Size = new System.Drawing.Size(1253, 100);
            this.panelhome.TabIndex = 1;
            this.panelhome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelhome_MouseDown);
            // 
            // minimizedbox
            // 
            this.minimizedbox.Image = global::UI.Properties.Resources.minimize;
            this.minimizedbox.Location = new System.Drawing.Point(1096, 3);
            this.minimizedbox.Name = "minimizedbox";
            this.minimizedbox.Size = new System.Drawing.Size(67, 63);
            this.minimizedbox.TabIndex = 1;
            this.minimizedbox.TabStop = false;
            this.minimizedbox.Click += new System.EventHandler(this.minimizedbox_Click);
            this.minimizedbox.MouseEnter += new System.EventHandler(this.minimizedbox_MouseEnter);
            this.minimizedbox.MouseLeave += new System.EventHandler(this.minimizedbox_MouseLeave);
            // 
            // Closebox
            // 
            this.Closebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.Closebox.Image = global::UI.Properties.Resources.rectangle_xmark_1_;
            this.Closebox.Location = new System.Drawing.Point(1184, 3);
            this.Closebox.Name = "Closebox";
            this.Closebox.Size = new System.Drawing.Size(66, 63);
            this.Closebox.TabIndex = 1;
            this.Closebox.TabStop = false;
            this.Closebox.Click += new System.EventHandler(this.Closebox_Click);
            this.Closebox.MouseEnter += new System.EventHandler(this.Closebox_MouseEnter);
            this.Closebox.MouseLeave += new System.EventHandler(this.Closebox_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(519, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 36);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(84)))), ((int)(((byte)(22)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 100);
            this.panel1.TabIndex = 2;
            // 
            // panelcont
            // 
            this.panelcont.Location = new System.Drawing.Point(237, 99);
            this.panelcont.Name = "panelcont";
            this.panelcont.Size = new System.Drawing.Size(1253, 626);
            this.panelcont.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1488, 725);
            this.ControlBox = false;
            this.Controls.Add(this.panelcont);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelhome);
            this.Controls.Add(this.panelbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelbtn.ResumeLayout(false);
            this.panelhome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizedbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSitting;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Panel panelhome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelcont;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox Closebox;
        private System.Windows.Forms.PictureBox minimizedbox;
    }
}


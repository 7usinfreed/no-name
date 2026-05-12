using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{

    public partial class FormProject : Form
    {
        // 1. تنشئ دالة خاصة بترتيب حالة الواجهة عند البداية
        private void InitializeWizardState()
        {
            // إقفال حقول صفحة الفريق (Team) 
            txtName_Team.ReadOnly = true;
            gboxMember.Enabled = false;
            dgvTeam.Enabled = false;

            // إقفال حقول صفحة المهام (Task) 

            dgvTasks.Enabled = false;

            // إقفال زر الحفظ النهائي
            btnTaskEnd.Enabled = false;
            btnNextTeam.Enabled = false;
            btnBackTeam.Enabled = false;
            btnBackTask.Enabled = false;
        }

        // 2. في حدث التحميل، تقوم فقط باستدعاء الدالة
        private void FormProject_Load(object sender, EventArgs e)
        {
            InitializeWizardState(); // سطر واحد فقط يجعل الكود أنيقاً ومقروءاً
        }
        public FormProject()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabNew_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnNextInfo_Click(object sender, EventArgs e)
        {

            // 1. التحقق من أن المستخدم أدخل اسم المشروع (لأنه NOT NULL في قاعدة البيانات)
            if (string.IsNullOrWhiteSpace(txtName_pro.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم المشروع أولاً.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName_pro.Focus();
                return;
            }

            // التحقق من أن تاريخ الانتهاء ليس قبل تاريخ البدء
            if (dtpDead_line.Value.Date < dtpStart.Value.Date)
            {
                MessageBox.Show("لا يمكن أن يكون تاريخ الانتهاء قبل تاريخ البدء!", "خطأ في التاريخ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // التحقق من أن المشروع يستمر ليوم واحد على الأقل (التاريخان غير متساويين)
            else if (dtpDead_line.Value.Date == dtpStart.Value.Date)
            {
                MessageBox.Show("يجب أن تكون مدة المشروع يوم واحد على الأقل. لا يمكن أن يبدأ وينتهي في نفس اليوم!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // 2. إقفال (تجميد) الحقول حتى لا يتمكن المستخدم من تعديلها
            txtName_pro.ReadOnly = true;     // جعل الحقل للقراءة فقط
            txtDis_pro.ReadOnly = true;      // جعل الوصف للقراءة فقط
            dtpStart.Enabled = false;        // تعطيل اختيار التاريخ
            dtpDead_line.Enabled = false;    // تعطيل اختيار التاريخ

            // إخفاء زر Next لكي لا يضغط عليه مرة أخرى وهو مقفل (اختياري ولمسة احترافية)
            btnNextInfo.Enabled = false;
            btnNextTeam.Enabled = true; // تفعيل زر Next الخاص بصفحة الفريق
            btnBackTeam.Enabled = true; // تفعيل زر Back الخاص بصفحة المهام

            txtName_Team.ReadOnly = false;
            gboxMember.Enabled = true;
            dgvTeam.ReadOnly = false;
            dgvTeam.AllowUserToDeleteRows = true;

            // 3. الانتقال تلقائياً إلى صفحة الفريق (Team)
            tabNew.SelectedTab = tabTeam;
        }

        private void btnBackTeam_Click(object sender, EventArgs e)
        {
            // 1. فك القفل عن الحقول في صفحة المعلومات
            txtName_pro.ReadOnly = false;
            txtDis_pro.ReadOnly = false;
            dtpStart.Enabled = true;
            dtpDead_line.Enabled = true;

            // إعادة تفعيل زر Next
            btnNextInfo.Enabled = true;
            btnBackTeam.Enabled = false;
            btnNextTeam.Enabled = false; // تعطيل زر Next الخاص بصفحة الفريق حتى لا يتم الضغط عليه وهو مقفل

            // 2. الرجوع تلقائياً إلى صفحة المعلومات (Information)
            tabNew.SelectedTab = tabInfoProject;
        }

        private void btnNextTeam_Click(object sender, EventArgs e)
        {
            // 1. التحقق من إدخال اسم الفريق
            if (string.IsNullOrWhiteSpace(txtName_Team.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم الفريق أولاً.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName_Team.Focus();
                return;
            }

            // 2. التحقق من إضافة عضو واحد على الأقل في الجدول
            // ملاحظة: تأكد أنك قمت بتغيير اسم dataGridView1 إلى dgvTeam
            if (dgvTeam.Rows.Count == 0 || (dgvTeam.Rows.Count == 1 && dgvTeam.Rows[0].IsNewRow))
            {
                MessageBox.Show("الرجاء إضافة عضو واحد على الأقل للفريق قبل الانتقال لتوزيع المهام.", "الفريق فارغ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. إقفال (تجميد) الحقول لمنع التعديل العشوائي
            txtName_Team.ReadOnly = true;
            gboxMember.Enabled = false; // تجميد مربع إضافة الأعضاء بالكامل (النصوص والأزرار)
            dgvTeam.ReadOnly = true;    // منع التعديل اليدوي داخل خلايا الجدول
            dgvTeam.AllowUserToDeleteRows = false; // منع المستخدم من حذف صف من الجدول بلوحة المفاتيح

            // إخفاء/تعطيل زر back و Next لكي لا يُضغط مرتين
            btnNextTeam.Enabled = false;
            btnBackTeam.Enabled= false;


            // 4. الانتقال تلقائياً إلى صفحة المهام (Task)
            btnBackTask.Enabled = true; 
            btnTaskEnd.Enabled = true;
            gboxShowTask.Enabled = true; 

            tabNew.SelectedTab = tabTask;

        }

        private void btnBackTask_Click(object sender, EventArgs e)
        {
            // 1. فك القفل عن حقول صفحة الفريق
            txtName_Team.ReadOnly = false;
            gboxMember.Enabled = true; // إعادة تفعيل مربع إضافة الأعضاء بالكامل
            dgvTeam.ReadOnly = false;  // السماح بالتعديل على الجدول مجدداً
            dgvTeam.AllowUserToDeleteRows = true;

            // إعادة تفعيل زر Next الخاص بصفحة الفريق
            btnNextTeam.Enabled = true;
            btnBackTeam.Enabled = true; // تفعيل زر Back الخاص بصفحة الفريق 
            btnBackTask.Enabled = false; // تعطيل زر Back الخاص بصفحة المهام حتى لا يتم الضغط عليه وهو مقفل
            btnTaskEnd.Enabled = false; // تعطيل زر الحفظ النهائي حتى لا يتم الضغط عليه وهو مقفل
            gboxShowTask.Enabled = false; // تعطيل عرض المهام حتى لا يتم الضغط عليه وهو مقفل

            // 2. الرجوع تلقائياً لصفحة الفريق (Team)
            tabNew.SelectedTab = tabTeam;
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            // 1. التحقق من البيانات الأساسية
            if (string.IsNullOrWhiteSpace(txtTaskTitle.Text) || string.IsNullOrWhiteSpace(cmbAssignee.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم المهمة واختيار العضو المسؤول عنها.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpTaskEnd.Value.Date < dtpTaskStart.Value.Date)
            {
                MessageBox.Show("تاريخ انتهاء المهمة لا يمكن أن يكون قبل تاريخ البدء!", "خطأ في التاريخ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. تجهيز أعمدة جدول المهام (مع إضافة أعمدة التواريخ الجديدة)
            if (dgvTasks.Columns.Count == 0)
            {
                dgvTasks.Columns.Add("Title", "اسم المهمة");
                dgvTasks.Columns.Add("Description", "الوصف");
                dgvTasks.Columns.Add("Status", "الحالة");
                dgvTasks.Columns.Add("AssignedTo", "المسؤول");
                dgvTasks.Columns.Add("StartDate", "تاريخ البداية"); // عمود البداية الجديد
                dgvTasks.Columns.Add("EndDate", "تاريخ النهاية");   // عمود النهاية الجديد
            }

           

            // 3. إضافة سطر المهمة إلى الجدول (الآن نرسل 6 بيانات بدلاً من 4)
            dgvTasks.Rows.Add(
                txtTaskTitle.Text,
                txtTaskDesc.Text,
                cmbAssignee.Text,
                dtpTaskStart.Value.Date.ToString("yyyy-MM-dd"), // إرسال تاريخ البداية
                dtpTaskEnd.Value.Date.ToString("yyyy-MM-dd")    // إرسال تاريخ النهاية
            );

            // 4. تفريغ الحقول ليستعد المستخدم لإدخال المهمة التالية
            txtTaskTitle.Clear();
            txtTaskDesc.Clear();
            
            txtTaskTitle.Focus();
        }

        private void tabTask_Click(object sender, EventArgs e)
        {

        }

        private void btnAddmemer_Click(object sender, EventArgs e)
        {
            // 1. التحقق من إدخال البيانات الأساسية (الاسم والدور)
            // بافتراض أن: الاسم (txtMember) والإيميل (textBox1) والدور (comboBox1)
            if (string.IsNullOrWhiteSpace(txtMember.Text) || string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم العضو واختيار الدور الخاص به.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. تجهيز أعمدة جدول الفريق (تُنفذ مرة واحدة فقط لو لم تنشئها من التصميم)
            if (dgvTeam.Columns.Count == 0)
            {
                dgvTeam.Columns.Add("Name", "Name");
                dgvTeam.Columns.Add("Email", "Email");
                dgvTeam.Columns.Add("Role", "Role");
            }

            // 3. حماية إضافية: التأكد من أن العضو لم تتم إضافته مسبقاً (تمنع التكرار)
            foreach (DataGridViewRow row in dgvTeam.Rows)
            {
                if (row.Cells["Name"].Value != null && row.Cells["Name"].Value.ToString() == txtMember.Text)
                {
                    MessageBox.Show("هذا العضو تمت إضافته مسبقاً إلى الفريق!", "عضو مكرر", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // 4. إضافة العضو إلى الجدول (للعرض)
            dgvTeam.Rows.Add(txtMember.Text, txtEmail.Text, cmbRole.Text);

            // ==============================================================
            // 5. الخطوة الأهم: إضافة اسم العضو فوراً إلى قائمة المهام (cmbAssignee)
            // ==============================================================
            cmbAssignee.Items.Add(txtMember.Text);

            // 6. تفريغ الحقول لكي يدخل المستخدم العضو الذي بعده بسرعة
            txtMember.Clear();
            txtEmail.Clear();
            cmbRole.SelectedIndex = -1;
            txtMember.Focus(); // وضع مؤشر الكتابة في خانة الاسم تلقائياً
        }

        private void btnDelmember_Click(object sender, EventArgs e)
        {
            // التأكد من أن المستخدم قد حدد صفاً فعلياً للحذف
            if (dgvTeam.CurrentRow != null && !dgvTeam.CurrentRow.IsNewRow)
            {
                // 1. أخذ اسم العضو قبل أن نحذفه من الجدول
                string memberNameToDelete = dgvTeam.CurrentRow.Cells["Name"].Value.ToString();

                // 2. حذف العضو من الجدول (dgvTeam)
                dgvTeam.Rows.Remove(dgvTeam.CurrentRow);

                // 3. حذفه من قائمة المسؤولين (cmbAssignee) في صفحة المهام
                if (cmbAssignee.Items.Contains(memberNameToDelete))
                {
                    cmbAssignee.Items.Remove(memberNameToDelete);
                }
            }
            else
            {
                MessageBox.Show("الرجاء تحديد عضو من الجدول أولاً للقيام بحذفه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvTeam_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvTeam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAddrole_Click(object sender, EventArgs e)
        {
            // 1. أخذ النص المكتوب في القائمة المنسدلة
            string newRole = cmbRole.Text.Trim();

            if (string.IsNullOrWhiteSpace(newRole))
            {
                MessageBox.Show("الرجاء كتابة اسم الدور الجديد في الخانة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. التحقق مما إذا كان الدور موجوداً مسبقاً في القائمة المنسدلة (لتجنب التكرار في الواجهة)
            if (cmbRole.Items.Contains(newRole))
            {
                MessageBox.Show("هذا الدور موجود مسبقاً في القائمة!", "تكرار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // 3. الاتصال بقاعدة البيانات وحفظ الدور الجديد
                string connectionString = @"Server=ABOODI\MASSQLSERVER; Database=Mangment; Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // نستخدم IF NOT EXISTS لحماية قاعدة البيانات من خطأ التكرار (Primary Key)
                    string query = @"IF NOT EXISTS (SELECT 1 FROM roles WHERE role_name = @role)
                             INSERT INTO roles (role_name, description) VALUES (@role, 'تمت إضافته من الواجهة');";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@role", newRole);
                        cmd.ExecuteNonQuery();
                    }
                }

                // 4. إضافة الدور للقائمة المنسدلة في الواجهة لكي يتمكن من اختياره فوراً
                cmbRole.Items.Add(newRole);

                MessageBox.Show("تمت إضافة الدور الجديد بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حفظ الدور في قاعدة البيانات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaskEnd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل أنت متأكد من إنهاء إعداد المشروع وحفظ جميع البيانات؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            // نص الاتصال بقاعدة البيانات
            string connString = @"Server=ABOODI\MASSQLSERVER; Database=Mangment; Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction(); // بدء عملية الحفظ المترابطة

                try
                {
                    // ==========================================
                    // 1. حفظ اسم الفريق وجلب رقمه (tm_id)
                    // ==========================================
                    string qTeam = "INSERT INTO teams (tm_name) OUTPUT INSERTED.tm_id VALUES (@tmName);";
                    SqlCommand cmdTeam = new SqlCommand(qTeam, conn, transaction);
                    cmdTeam.Parameters.AddWithValue("@tmName", txtName_Team.Text);
                    int newTeamId = (int)cmdTeam.ExecuteScalar();

                    // ==========================================
                    // 2. حفظ المشروع وربطه بالفريق
                    // ==========================================
                    string qProject = @"INSERT INTO projects (project_name, description, status, start_date, deadline_date, team_id) 
                                OUTPUT INSERTED.project_id 
                                VALUES (@pName, @pDesc, 'Planning', @start, @dead, @teamId);";
                    SqlCommand cmdProject = new SqlCommand(qProject, conn, transaction);
                    cmdProject.Parameters.AddWithValue("@pName", txtName_pro.Text);
                    cmdProject.Parameters.AddWithValue("@pDesc", txtDis_pro.Text);
                    cmdProject.Parameters.AddWithValue("@start", dtpStart.Value.Date);
                    cmdProject.Parameters.AddWithValue("@dead", dtpDead_line.Value.Date);
                    cmdProject.Parameters.AddWithValue("@teamId", newTeamId);
                    int newProjectId = (int)cmdProject.ExecuteScalar();

                    // ==========================================
                    // 3. حفظ الأدوار والأعضاء وربطهم بالمشروع
                    // ==========================================
                    Dictionary<string, int> memberMap = new Dictionary<string, int>();
                    foreach (DataGridViewRow row in dgvTeam.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string mName = row.Cells[0].Value.ToString();
                        string mEmail = row.Cells[1].Value?.ToString() ?? (mName.Replace(" ", "") + "@team.com");
                        string mRole = row.Cells[2].Value.ToString();

                        // --- حل مشكلة الفورين كي (Foreign Key): التأكد من وجود الدور وإنشائه إن لم يكن موجوداً ---
                        string qCheckRole = @"IF NOT EXISTS (SELECT 1 FROM roles WHERE role_name = @rName)
                                      INSERT INTO roles (role_name, description) VALUES (@rName, 'تمت إضافته تلقائياً وقت الحفظ');";
                        SqlCommand cmdCheckRole = new SqlCommand(qCheckRole, conn, transaction);
                        cmdCheckRole.Parameters.AddWithValue("@rName", mRole);
                        cmdCheckRole.ExecuteNonQuery();

                        // حفظ العضو
                        string qMember = @"IF NOT EXISTS (SELECT 1 FROM members WHERE email = @email)
                                   INSERT INTO members (m_name, email) VALUES (@name, @email);
                                   SELECT m_id FROM members WHERE email = @email;";
                        SqlCommand cmdMember = new SqlCommand(qMember, conn, transaction);
                        cmdMember.Parameters.AddWithValue("@name", mName);
                        cmdMember.Parameters.AddWithValue("@email", mEmail);
                        int mId = (int)cmdMember.ExecuteScalar();

                        memberMap[mName] = mId; // حفظ رقم العضو في الذاكرة لربطه بمهامه

                        // ربط العضو بالمشروع الحالي في جدول project_members
                        string qPM = "INSERT INTO project_members (project_id, m_id, role_name) VALUES (@pId, @mId, @rName);";
                        SqlCommand cmdPM = new SqlCommand(qPM, conn, transaction);
                        cmdPM.Parameters.AddWithValue("@pId", newProjectId);
                        cmdPM.Parameters.AddWithValue("@mId", mId);
                        cmdPM.Parameters.AddWithValue("@rName", mRole);
                        cmdPM.ExecuteNonQuery();
                    }

                    // ==========================================
                    // 4. حفظ المهام (شاملة تواريخ البداية والنهاية)
                    // ==========================================
                    foreach (DataGridViewRow row in dgvTasks.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string tTitle = row.Cells[0].Value.ToString();
                        string tDesc = row.Cells[1].Value?.ToString() ?? "";
                        string tStatus = row.Cells[2].Value.ToString();
                        string tAssignee = row.Cells[3].Value.ToString();

                        // جلب التواريخ
                        DateTime tStart = Convert.ToDateTime(row.Cells[4].Value);
                        DateTime tEnd = Convert.ToDateTime(row.Cells[5].Value);

                        int assignId = memberMap.ContainsKey(tAssignee) ? memberMap[tAssignee] : memberMap.Values.First();

                        string qTask = @"INSERT INTO tasks (tk_name, description, status, project_id, assigned_to, start_date_task, end_date_task) 
                                 VALUES (@tkName, @tkDesc, @status, @pId, @assignId, @tStart, @tEnd);";

                        SqlCommand cmdTask = new SqlCommand(qTask, conn, transaction);
                        cmdTask.Parameters.AddWithValue("@tkName", tTitle);
                        cmdTask.Parameters.AddWithValue("@tkDesc", tDesc);
                        cmdTask.Parameters.AddWithValue("@status", tStatus);
                        cmdTask.Parameters.AddWithValue("@pId", newProjectId);
                        cmdTask.Parameters.AddWithValue("@assignId", assignId);
                        cmdTask.Parameters.AddWithValue("@tStart", tStart);
                        cmdTask.Parameters.AddWithValue("@tEnd", tEnd);
                        cmdTask.ExecuteNonQuery();
                    }

                    // ==========================================
                    // 5. تأكيد الحفظ!
                    // ==========================================
                    transaction.Commit();
                    MessageBox.Show("تم إنشاء المشروع وحفظ جميع البيانات في قاعدة البيانات بنجاح!", "إنجاز", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // إغلاق الشاشة للعودة للرئيسية
                    this.Close();
                }
                catch (Exception ex)
                {
                    // التراجع عن كل شيء لو حدث أي خطأ
                    transaction.Rollback();
                    MessageBox.Show("حدث خطأ أثناء الحفظ في قاعدة البيانات:\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            // 1. التأكد من أن المستخدم قد حدد صفاً فعلياً من جدول المهام
            // (dgvTasks هو اسم جدول المهام، إذا كان اسمه عندك dataGridView2 قم بتغييره في الكود)
            if (dgvTasks.CurrentRow != null && !dgvTasks.CurrentRow.IsNewRow)
            {
                // 2. رسالة تأكيد صغيرة (اختيارية، لزيادة الاحترافية حتى لا يحذف مهمة بالخطأ)
                string taskName = dgvTasks.CurrentRow.Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show($"هل أنت متأكد من حذف المهمة: '{taskName}'؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // 3. حذف المهمة المحددة من الجدول
                    dgvTasks.Rows.Remove(dgvTasks.CurrentRow);
                }
            }
            else
            {
                // تنبيه إذا ضغط على الزر وهو لم يحدد أي مهمة
                MessageBox.Show("الرجاء تحديد مهمة من الجدول أولاً للقيام بحذفها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

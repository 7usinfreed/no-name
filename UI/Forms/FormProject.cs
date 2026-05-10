using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            groupBox1.Enabled = false;
            dgvTasks.Enabled = false;
            cmbFilterLevel.Enabled = false;
            btnShowTasks.Enabled = false;

            // إقفال زر الحفظ النهائي
            btnEnd.Enabled = false;
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

            // إخفاء/تعطيل زر Next لكي لا يُضغط مرتين
            btnNextTeam.Enabled = false;

            // 4. الانتقال تلقائياً إلى صفحة المهام (Task)
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
            btnBackTask.Enabled = false; // تعطيل زر Back الخاص بصفحة المهام حتى لا يتم الضغط عليه وهو مقفل
            btnEnd.Enabled = false; // تعطيل زر الحفظ النهائي حتى لا يتم الضغط عليه وهو مقفل

            // 2. الرجوع تلقائياً لصفحة الفريق (Team)
            tabNew.SelectedTab = tabTeam;
        }
    }
}

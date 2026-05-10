using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public static class DataGridView_Design
    {
        public static void ApplyDarkTheme(DataGridView dgv)
        {
            // تعطيل الستايل الافتراضي للويندوز
            dgv.EnableHeadersVisualStyles = false;

            // ألوان الخلفية والشبكة
            dgv.BackgroundColor = System.Drawing.Color.FromArgb(30, 30, 30);
            dgv.GridColor = System.Drawing.Color.FromArgb(45, 45, 48);
            dgv.BorderStyle = BorderStyle.None;

            // تنسيق العناوين
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            dgv.ColumnHeadersHeight = 40;

            // تنسيق الصفوف
            dgv.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            dgv.RowTemplate.Height = 35;

            // إخفاء الأعمدة والصفوف الإضافية غير المهمة
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
    


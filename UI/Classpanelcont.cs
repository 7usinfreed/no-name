using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    
        

public static class Classpanelcont
    {
        // دالة لفتح أي فورم داخل بانل معين
        public static void OpenChildForm(Panel container, Form childForm)
        {
            // 1. تنظيف الحاوية من أي فورم سابق
            if (container.Controls.Count > 0)
                container.Controls.Clear();

            // 2. ضبط خصائص الفورم الجديد
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // 3. إضافة الفورم للبانل وإظهاره
            container.Controls.Add(childForm);
            childForm.Tag = childForm;
            childForm.Show();
            childForm.BringToFront();
        }
    }
}


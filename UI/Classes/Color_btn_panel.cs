using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  using System.Drawing;
    using System.Windows.Forms;

namespace UI
{
  

    public static class Color_btn_panel
    {
        // ألوان موحدة للبرنامج بالكامل
        public static Color DefaultColor = Color.FromArgb(230, 126, 34);
        public static Color HoverColor = Color.FromArgb(41, 128, 185);
        
        


        public static void SetupSideMenu(Panel menuPanel)
        {
            foreach (Control ctrl in menuPanel.Controls)
            {
                if (ctrl is Button btn)
                {
                    // 1. تنسيق شكل الزر الموحد
                    btn.BackColor = DefaultColor;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    // 2. إضافة التأثيرات
                    btn.MouseEnter += (s, e) => btn.BackColor = HoverColor;
                    btn.MouseLeave += (s, e) => btn.BackColor = DefaultColor;
                }
            }
        }

        
        }

    
}

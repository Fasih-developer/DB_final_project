using System.Drawing;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public static class ThemeManager
    {
        // Dark theme colours - fixed, no toggling
        public static Color Bg        => Color.FromArgb(44, 49, 49);
        public static Color Panel     => Color.FromArgb(68, 72, 71);
        public static Color Card      => Color.FromArgb(56, 60, 60);
        public static Color Text      => Color.White;
        public static Color SubText   => Color.FromArgb(180, 180, 180);
        public static Color Muted     => Color.FromArgb(120, 120, 120);
        public static Color Input     => Color.FromArgb(44, 49, 49);
        public static Color Accent    => Color.FromArgb(52, 193, 164);
        public static Color AccentBlue => Color.FromArgb(52, 130, 193);
        public static Color NavActive => Color.FromArgb(52, 193, 164);
        public static Color NavBtn    => Color.FromArgb(68, 72, 71);
        public static Color NavText   => Color.White;

        /// <summary>Applies dark theme to a form and all its controls.</summary>
        public static void Apply(Form form)
        {
            form.BackColor = Bg;
            ApplyToControls(form.Controls);
        }

        private static void ApplyToControls(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is Panel p)
                {
                    p.BackColor = Panel;
                    ApplyToControls(p.Controls);
                }
                else if (c is Label lbl)
                {
                    if (lbl.ForeColor != Accent)
                        lbl.ForeColor = Text;
                }
                else if (c is TextBox tb)
                {
                    tb.BackColor = Input;
                    tb.ForeColor = Text;
                }
                else if (c is Button btn)
                {
                    if (btn.BackColor == Color.FromArgb(68, 72, 71) ||
                        btn.BackColor == Color.FromArgb(44, 49, 49))
                    {
                        btn.BackColor = NavBtn;
                        btn.ForeColor = NavText;
                    }
                }
                else if (c is FlowLayoutPanel fl)
                {
                    fl.BackColor = Bg;
                    ApplyToControls(fl.Controls);
                }
                else if (c is ComboBox cb)
                {
                    cb.BackColor = Input;
                    cb.ForeColor = Text;
                }

                if (c.HasChildren)
                    ApplyToControls(c.Controls);
            }
        }
    }
}

using System.Drawing;
using System.Windows.Forms;

namespace CampusConnect.Forms
{
    public static class ThemeManager
    {
        public static bool IsDark { get; private set; } = true;

        // Dark palette
        public static Color DarkBg        => Color.FromArgb(44, 49, 49);
        public static Color DarkPanel     => Color.FromArgb(68, 72, 71);
        public static Color DarkCard      => Color.FromArgb(56, 60, 60);
        public static Color DarkText      => Color.White;
        public static Color DarkSubText   => Color.FromArgb(180, 180, 180);
        public static Color DarkMuted     => Color.FromArgb(120, 120, 120);
        public static Color DarkInput     => Color.FromArgb(44, 49, 49);
        public static Color Accent        => Color.FromArgb(52, 193, 164);
        public static Color AccentBlue    => Color.FromArgb(52, 130, 193);

        // Light palette
        public static Color LightBg       => Color.FromArgb(240, 242, 245);
        public static Color LightPanel    => Color.White;
        public static Color LightCard     => Color.FromArgb(228, 232, 240);
        public static Color LightText     => Color.FromArgb(30, 30, 30);
        public static Color LightSubText  => Color.FromArgb(80, 80, 80);
        public static Color LightMuted    => Color.FromArgb(140, 140, 140);
        public static Color LightInput    => Color.FromArgb(248, 249, 252);
        public static Color LightAccent   => Color.FromArgb(37, 99, 235);   // blue
        public static Color LightNavAct   => Color.FromArgb(37, 99, 235);

        // Current theme getters
        public static Color Bg        => IsDark ? DarkBg      : LightBg;
        public static Color Panel     => IsDark ? DarkPanel   : LightPanel;
        public static Color Card      => IsDark ? DarkCard     : LightCard;
        public static Color Text      => IsDark ? DarkText     : LightText;
        public static Color SubText   => IsDark ? DarkSubText  : LightSubText;
        public static Color Muted     => IsDark ? DarkMuted    : LightMuted;
        public static Color Input     => IsDark ? DarkInput    : LightInput;
        public static Color NavActive => IsDark ? Accent       : LightNavAct;
        public static Color NavBtn    => IsDark ? DarkPanel    : LightPanel;
        public static Color NavText   => IsDark ? DarkText     : LightText;

        public static void Toggle()
        {
            IsDark = !IsDark;
        }

        /// <summary>
        /// Applies the current theme to a form and all its controls recursively.
        /// Call this from every form's ApplyTheme() method.
        /// </summary>
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
                    // Nav panel keeps its own colour set
                    if (p.Name == "panelNav" || p.Name == "panelSidebar")
                        p.BackColor = Panel;
                    else
                        p.BackColor = Panel;
                    ApplyToControls(p.Controls);
                }
                else if (c is Label lbl)
                {
                    // Don't override green accent labels (nav title)
                    if (lbl.ForeColor != Accent && lbl.ForeColor != (IsDark ? Accent : LightNavAct))
                        lbl.ForeColor = Text;
                }
                else if (c is TextBox tb)
                {
                    tb.BackColor = Input;
                    tb.ForeColor = Text;
                }
                else if (c is Button btn)
                {
                    // Keep red/green/accent buttons as-is; only retheme neutral nav buttons
                    if (btn.BackColor == DarkPanel || btn.BackColor == LightPanel ||
                        btn.BackColor == DarkBg    || btn.BackColor == LightBg)
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

        public static string ToggleButtonLabel => IsDark ? "☀ Light" : "🌙 Dark";
    }
}

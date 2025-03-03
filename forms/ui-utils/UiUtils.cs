using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace CourseWorkIT.forms.ui_utils
{
    static class UiUtils
    {
        public static void ButtonHoverHandler(Label button, string iconName, string hoverIconName)
        {
            string projectRoot = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string iconPath = Path.Combine(projectRoot, "icons", iconName + ".png");
            string hoverIconPath = Path.Combine(projectRoot, "icons", hoverIconName + ".png");

            button.MouseEnter += (s, e) =>
            {
                button.Image = Image.FromFile(hoverIconPath);
            };
            button.MouseLeave += (s, e) =>
            {
                button.Image = Image.FromFile(iconPath);
            };
        }

        public static void SwitchForms(Form current, Form next)
        {
            next.Visible = true;
            current.Visible = false;
        }

        public static void AddFormToContainer(Form form, Form container)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            form.Show();
        }

    }
}

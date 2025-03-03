using System;
using System.Drawing;
using System.Windows.Forms;
using CourseWorkIT.consts;
using CourseWorkIT.forms.ui_utils;
using CourseWorkIT.stores;

namespace CourseWorkIT.forms
{
    public partial class Settings : Form
    {
        private FramesStore framesStore;
        private SettingsStore settingsStore;

        public Settings(FramesStore framesStore, SettingsStore settingsStore)
        {
            InitializeComponent();

            this.framesStore = framesStore;
            this.settingsStore = settingsStore;

            delay_input.Text = this.settingsStore.delayBetweenImages.ToString();
            width_input.Text = this.settingsStore.width.ToString();
            height_input.Text = this.settingsStore.height.ToString();
            UiUtils.ButtonHoverHandler(back_button, "back", "back_hover");
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            framesStore.PrevFrame();
        }

        private void delay_input_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(delay_input.Text, out var delay))
            {
                settingsStore.delayBetweenImages = delay;
            }
            else
            {
                settingsStore.delayBetweenImages = Consts.DEFAULT_FRAME_DELAY;
            }
        }

        private void width_input_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(width_input.Text, out var width))
            {
                settingsStore.width = width;
            }
            else
            {
                settingsStore.width = Consts.DEFAULT_GIF_WIDTH;
            }
        }

        private void height_input_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(height_input.Text, out var height))
            {
                settingsStore.height = height;
            }
            else
            {
                settingsStore.height = Consts.DEFAULT_GIF_HEIGHT;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                framesStore.Position = new Point
                {
                    X = framesStore.Position.X + e.X - framesStore.lastPosition.X,
                    Y = framesStore.Position.Y + e.Y - framesStore.lastPosition.Y
                };
            }
        }

        private void title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                framesStore.Position = new Point
                {
                    X = framesStore.Position.X + e.X - framesStore.lastPosition.X,
                    Y = framesStore.Position.Y + e.Y - framesStore.lastPosition.Y
                };
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            framesStore.lastPosition = new Point(e.X, e.Y);
        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            framesStore.lastPosition = new Point(e.X, e.Y);
        }
    }
}

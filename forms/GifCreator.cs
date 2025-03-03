using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using CourseWorkIT.consts;
using CourseWorkIT.forms.ui_utils;
using CourseWorkIT.services;
using CourseWorkIT.store;
using CourseWorkIT.stores;

namespace CourseWorkIT.forms
{
    public partial class GifCreator : Form
    {
        private GifStore gifStore;
        private readonly FramesStore framesStore;
        private readonly SettingsStore settingsStore;

        public GifCreator(GifStore store, FramesStore framesStore, SettingsStore settingsStore)
        {
            InitializeComponent();

            this.gifStore = store;
            this.gifStore.SetChangeHandler(OnImagesChanged);
            this.framesStore = framesStore;
            this.settingsStore = settingsStore;

            UiUtils.ButtonHoverHandler(close_button, "cross", "cross_hover");
            UiUtils.ButtonHoverHandler(settings_button, "settings", "settings_hover");
        }

        private void OnImagesChanged()
        {
            CreateGifButtonVisibility();
            ShowFilenames();
            notify.Text = "";
        }

        private void CreateGifButtonVisibility()
        {
            if (this.gifStore.filenames.Count > 0)
            {
                create_gif.Visible = true;
            }
            else
            {
                create_gif.Visible = false;
            }
        }

        private void ShowFilenames()
        {
            file_names.Items.Clear();
            foreach (var filename in this.gifStore.filenames)
            {
                file_names.Items.Add(filename);
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void add_images_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = Consts.ALLOWED_FILE_EXTENSIONS;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    gifStore.AddImages(openFileDialog.FileNames);
                }
            }
        }

        private void create_gif_Click(object sender, EventArgs e)
        {
            ObservableCollection<Image> images = gifStore.GetImages();
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = Consts.SAVE_FILE_EXTENSION;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    GifService.SaveGif(saveFileDialog.FileName, settingsStore.delayBetweenImages, settingsStore.width, settingsStore.height, gifStore.filenames, images);
                    gifStore.ClearStore();
                    notify.Text = Consts.GIF_SUCCESSFUL;
                }
            }
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            framesStore.SwitchFrame(typeof(Settings));
        }
    }
}

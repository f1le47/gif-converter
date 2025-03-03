using System.Collections.Generic;
using System.Windows.Forms;
using CourseWorkIT.store;
using CourseWorkIT.stores;
using System.Drawing;

namespace CourseWorkIT.forms
{
    public partial class FrameContainer : Form
    {
        private static GifStore gifStore;
        private static FramesStore framesStore;
        private static SettingsStore settingsStore;

        public FrameContainer()
        {
            InitializeComponent();

            gifStore = new GifStore();
            framesStore = new FramesStore();
            settingsStore = new SettingsStore();

            Form gifCreator = new GifCreator(gifStore, framesStore, settingsStore);
            Form settings = new Settings(framesStore, settingsStore);

            Form firstFrame = framesStore.InitilizeFrameStore(new List<Form> { gifCreator, settings }, this);
            firstFrame.Visible = true;

            framesStore.PositionChanged += ChangePosition;
        }

        private void ChangePosition(object sender, Point newPosition)
        {
            this.Left = newPosition.X;
            this.Top = newPosition.Y;
        }
    }
}

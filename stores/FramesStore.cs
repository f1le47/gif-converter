using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using CourseWorkIT.forms.ui_utils;
using System.Drawing;

namespace CourseWorkIT.stores
{
    public class FramesStore
    {
        private List<Form> _frames = new List<Form>();
        private Type _prevFrame = null;
        private Type _currentFrame = null;
        private Point _position = new Point();
        public Point lastPosition = new Point();

        public event EventHandler<Point> PositionChanged;

        protected virtual void OnPositionChanged(Point newPosition)
        {
            PositionChanged?.Invoke(this, newPosition);
        }

        public Form InitilizeFrameStore(List<Form> frames, Form container)
        {
            _frames = frames;
            foreach (var frame in frames)
            {
                UiUtils.AddFormToContainer(frame, container);
                frame.Visible = false;
            }

            _currentFrame = frames[0].GetType();
            return frames[0];
        }

        public void SwitchFrame(Type nextFrameType)
        {
            Form currentFrame = FramesStore.GetFrameByType(_currentFrame, _frames);
            Form nextFrame = FramesStore.GetFrameByType(nextFrameType, _frames);

            UiUtils.SwitchForms(currentFrame, nextFrame);

            _prevFrame = _currentFrame;
            _currentFrame = nextFrameType;
        }
        
        public void PrevFrame()
        {
            Form prevFrame = FramesStore.GetFrameByType(_prevFrame, _frames);
            Form currentFrame = FramesStore.GetFrameByType(_currentFrame, _frames);

            UiUtils.SwitchForms(currentFrame, prevFrame);

            _currentFrame = _prevFrame;
            _prevFrame = null;
        }

        public static Form GetFrameByType(Type frameType, List<Form> frames)
        {
            return frames.FirstOrDefault(frame => frame.GetType() == frameType);
        }

        public Point Position
        {
            get => _position;
            set
            {
                if (_position != value)
                {
                    _position = value;
                    OnPositionChanged(_position);
                }
            }
        }
    }
}

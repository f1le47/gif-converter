using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;

namespace CourseWorkIT.store
{
    public class GifStore
    {
        private ObservableCollection<Image> _images = new ObservableCollection<Image>();
        public List<string> filenames = new List<string>();
        private Action changeHandler;

        public GifStore()
        {
            _images.CollectionChanged += OnImagesChanged;
        }

        private void OnImagesChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            changeHandler?.Invoke();
        }
        
        public void SetChangeHandler(Action handler)
        {
            changeHandler = handler;
        }

        public void AddImages(string[] filePaths)
        {
            foreach (string filePath in filePaths)
            {
                filenames.Add(System.IO.Path.GetFileName(filePath));
                _images.Add(Image.FromFile(filePath));
            }
        }
        
        public ObservableCollection<Image> GetImages() { return _images; }

        public void ClearStore()
        {
            filenames.Clear();
            _images.Clear();
        }
    }
}

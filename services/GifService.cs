using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Collections.ObjectModel;

namespace CourseWorkIT.services
{
    static class GifService
    {
        public static void SaveGif(string filePath, int frameDelay, int width, int height, List<string> filenames, ObservableCollection<Image> images)
        {
            if (images.Count == 0) return;

            ImageCodecInfo gifEncoder = GetEncoder(ImageFormat.Gif);
            EncoderParameters encoderParams = new EncoderParameters(1);

            int delay = frameDelay * 100;

            using (Bitmap firstImage = ResizeImage(images[0], width, height))
            {
                firstImage.SetPropertyItem(CreateFrameDelayProperty(delay, images.Count));

                encoderParams.Param[0] = new EncoderParameter(Encoder.SaveFlag, (long)EncoderValue.MultiFrame);
                firstImage.Save(filePath, gifEncoder, encoderParams);

                encoderParams.Param[0] = new EncoderParameter(Encoder.SaveFlag, (long)EncoderValue.FrameDimensionTime);

                foreach (var img in images.Skip(1))
                {
                    using (Bitmap frame = ResizeImage(img, width, height))
                    {
                        frame.SetPropertyItem(CreateFrameDelayProperty(delay, images.Count));
                        firstImage.SaveAdd(frame, encoderParams);
                    }
                }

                encoderParams.Param[0] = new EncoderParameter(Encoder.SaveFlag, (long)EncoderValue.Flush);
                firstImage.SaveAdd(encoderParams);
            }
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().FirstOrDefault(codec => codec.FormatID == format.Guid);
        }

        private static PropertyItem CreateFrameDelayProperty(int delay, int frameCount)
        {
            PropertyItem prop = (PropertyItem)typeof(PropertyItem)
                .GetConstructor(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance,
                                null, new System.Type[0], null).Invoke(null);

            prop.Id = 0x5100;
            prop.Type = 4;
            prop.Len = frameCount * 4;
            prop.Value = new byte[frameCount * 4];

            for (int i = 0; i < frameCount; i++)
            {
                prop.Value[i * 4] = (byte)(delay & 0xFF);
                prop.Value[i * 4 + 1] = (byte)((delay >> 8) & 0xFF);
                prop.Value[i * 4 + 2] = 0;
                prop.Value[i * 4 + 3] = 0;
            }

            return prop;
        }

        private static Bitmap ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }
    }
}

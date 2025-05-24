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

            // Получение кодека для формата GIF
            ImageCodecInfo gifEncoder = GetEncoder(ImageFormat.Gif);
            EncoderParameters encoderParams = new EncoderParameters(1);

            int delay = frameDelay * 100;

            // Подготовка первого кадра
            using (Bitmap firstImage = ResizeImage(images[0], width, height))
            {
                // Установка задержки для всех кадров
                firstImage.SetPropertyItem(CreateFrameDelayProperty(delay, images.Count));

                // Установка параметра — создание нового мультикадрового GIF
                encoderParams.Param[0] = new EncoderParameter(Encoder.SaveFlag, (long)EncoderValue.MultiFrame);
                firstImage.Save(filePath, gifEncoder, encoderParams);

                // Установка параметра — добавление последующих кадров
                encoderParams.Param[0] = new EncoderParameter(Encoder.SaveFlag, (long)EncoderValue.FrameDimensionTime);

                // Добавление оставшихся кадров
                foreach (var img in images.Skip(1))
                {
                    using (Bitmap frame = ResizeImage(img, width, height))
                    {
                        frame.SetPropertyItem(CreateFrameDelayProperty(delay, images.Count));
                        firstImage.SaveAdd(frame, encoderParams);
                    }
                }

                // Завершение сохранения GIF
                encoderParams.Param[0] = new EncoderParameter(Encoder.SaveFlag, (long)EncoderValue.Flush);
                firstImage.SaveAdd(encoderParams);
            }
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().FirstOrDefault(codec => codec.FormatID == format.Guid); // Получает кодек по заданному формату изображения.
        }

        private static PropertyItem CreateFrameDelayProperty(int delay, int frameCount)
        {
            // Получение нового экземпляра PropertyItem (через рефлексию, так как у него нет публичного конструктора)
            PropertyItem prop = (PropertyItem)typeof(PropertyItem)
                .GetConstructor(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance,
                                null, new System.Type[0], null).Invoke(null);

            prop.Id = 0x5100; // ID свойства FrameDelay
            prop.Type = 4; // Тип — Long (32-битное целое)
            prop.Len = frameCount * 4; // Длина массива: по 4 байта на кадр
            prop.Value = new byte[frameCount * 4];

            // Установка задержки для каждого кадра
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
                // Настройки качества при масштабировании
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }
    }
}

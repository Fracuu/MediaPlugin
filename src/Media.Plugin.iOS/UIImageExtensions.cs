using CoreGraphics;
using System;
using System.Drawing;
using UIKit;
using CoreImage;

namespace Plugin.Media
{
    /// <summary>
    /// Static mathods for UIImage
    /// </summary>
    public static class UIImageExtensions
    {
        public static UIImage ResizeImageWithAspectRatio(this UIImage imageSource, float scale)
        {
            if (scale > 1.0f)
                return imageSource;
			
            using (CIContext c = CIContext.Create())
            {
                var sourceImage = CIImage.FromCGImage(imageSource.CGImage);

                var f = new CILanczosScaleTransform
                {
                    Scale = scale,
                    Image = sourceImage,
                    AspectRatio = 1.0f
                };


                var output = f.OutputImage;

                var cgi = c.CreateCGImage(output, output.Extent);
                return UIImage.FromImage(cgi, 1.0f, imageSource.Orientation);
            }
        }

        /// <summary>
        /// Resize image to maximum size
        /// keeping the aspect ratio
        /// </summary>
        public static UIImage ResizeImageWithAspectRatio(this UIImage sourceImage, float maxWidth, float maxHeight)
        {
			

            var sourceSize = sourceImage.Size;
            var maxResizeFactor = Math.Max(maxWidth / sourceSize.Width, maxHeight / sourceSize.Height);
            if (maxResizeFactor > 1) 
                return sourceImage;
            var width = maxResizeFactor * sourceSize.Width;
            var height = maxResizeFactor * sourceSize.Height;
            UIGraphics.BeginImageContext(new CGSize(width, height));
            sourceImage.Draw(new CGRect(0, 0, width, height));
            var resultImage = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();
            return resultImage;
        }

        /// <summary>
        /// Resize image, but ignore the aspect ratio
        /// </summary>
        /// <param name="sourceImage"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static UIImage ResizeImage(this UIImage sourceImage, float width, float height)
        {
            UIGraphics.BeginImageContext(new SizeF(width, height));
            sourceImage.Draw(new RectangleF(0, 0, width, height));
            var resultImage = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();
            return resultImage;
        }

        /// <summary>
        /// Crop image to specitic size and at specific coordinates
        /// </summary>
        /// <param name="sourceImage"></param>
        /// <param name="crop_x"></param>
        /// <param name="crop_y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static UIImage CropImage(this UIImage sourceImage, int crop_x, int crop_y, int width, int height)
        {
            var imgSize = sourceImage.Size;
            UIGraphics.BeginImageContext(new SizeF(width, height));
            var context = UIGraphics.GetCurrentContext();
            var clippedRect = new RectangleF(0, 0, width, height);
            context.ClipToRect(clippedRect);
            var drawRect = new CGRect(-crop_x, -crop_y, imgSize.Width, imgSize.Height);
            sourceImage.Draw(drawRect);
            var modifiedImage = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();
            return modifiedImage;
        }
        
        public static UIImage ScaleImage(this UIImage sourceImage, float scale)
        {
            if (scale >= 0.999f)
                return sourceImage;

            UIImage resultImage;
            float width = (float)(sourceImage.Size.Width * scale);
            float height = (float)(sourceImage.Size.Height * scale);

            if (sourceImage.Orientation == UIImageOrientation.Left || sourceImage.Orientation == UIImageOrientation.Right 
                || sourceImage.Orientation == UIImageOrientation.LeftMirrored || sourceImage.Orientation == UIImageOrientation.RightMirrored) {
                var w = width;
                width = height;
                height = w;
            }
            using (CGImage image = sourceImage.CGImage)
            {
                CGImageAlphaInfo alpha = image.AlphaInfo == CGImageAlphaInfo.None ? CGImageAlphaInfo.NoneSkipLast : image.AlphaInfo;
                CGColorSpace color = CGColorSpace.CreateDeviceRGB();
                var bitmap = new CGBitmapContext(IntPtr.Zero, (int)width, (int)height, image.BitsPerComponent, image.BytesPerRow, color, alpha);
                bitmap.DrawImage(new CGRect(0, 0, (int)width, (int)height), image);
                resultImage = UIImage.FromImage(bitmap.ToImage(), 1.0f, sourceImage.Orientation);
            }

            return resultImage;
        }
    }
}
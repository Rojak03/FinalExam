using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

/// <summary>
/// Summary description for imageResize
/// </summary>
public class imageResize
{
    public static void ResizeImage(int width, Stream fromStream, Stream toStream)
    {
        //Propertionelt AspectRation 
        float originalAspectRatio = (float)Image.FromStream(fromStream).Width / (float)Image.FromStream(fromStream).Height;
        var image = Image.FromStream(fromStream);

        //Hvis det billede der uploades er mindre end "resize" - bliver det ikke scaleret op.
        //Dette er for ikke at "pixelere" billederne
        if (width < (float)Image.FromStream(fromStream).Width)
        {
            float newWidth = width;
            float newHeight = (float)width / (float)originalAspectRatio;
            Debug.Write("ASPECT: = " + newHeight);

            var thumpnailBitmap = new Bitmap((int)newWidth, (int)newHeight);

            var thumpnailGraph = Graphics.FromImage(thumpnailBitmap);
            thumpnailGraph.CompositingQuality = CompositingQuality.HighQuality;
            thumpnailGraph.SmoothingMode = SmoothingMode.HighQuality;
            thumpnailGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
            var imageRectangle = new Rectangle(0, 0, (int)newWidth, (int)newHeight);
            thumpnailGraph.DrawImage(image, imageRectangle);
            thumpnailBitmap.Save(toStream, image.RawFormat);
            thumpnailGraph.Dispose();
            thumpnailBitmap.Dispose();
            image.Dispose();
        }
        else
        {
            float newWidth = (float)Image.FromStream(fromStream).Width;
            float newHeight = (float)Image.FromStream(fromStream).Height;
            Debug.Write("ASPECT: = " + newHeight);
            var thumpnailBitmap = new Bitmap((int)newWidth, (int)newHeight);
            var thumpnailGraph = Graphics.FromImage(thumpnailBitmap);
            thumpnailGraph.CompositingQuality = CompositingQuality.HighQuality;
            thumpnailGraph.SmoothingMode = SmoothingMode.HighQuality;
            thumpnailGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
            var imageRectangle = new Rectangle(0, 0, (int)newWidth, (int)newHeight);
            thumpnailGraph.DrawImage(image, imageRectangle);
            thumpnailBitmap.Save(toStream, image.RawFormat);
            thumpnailGraph.Dispose();
            thumpnailBitmap.Dispose();
            image.Dispose();
        }

    }
}
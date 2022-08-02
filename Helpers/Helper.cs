using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace ClockiFyAMS
{
    public static class Helper
    {
        public static BitmapImage QRGenerator(string plainText)
        {
            var codeWriter = new BarcodeWriter();
            var encodingOptions = new EncodingOptions { Width = 200, Height = 200, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            codeWriter.Renderer = new BitmapRenderer();
            codeWriter.Options = encodingOptions;
            codeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = codeWriter.Write(plainText);
            //Bitmap overlay = new Bitmap(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/sad_ghost_50px.png");
            //Graphics graphics = Graphics.FromImage(bitmap);
            //graphics.DrawImage(overlay, new System.Drawing.Point((bitmap.Width - overlay.Width) / 2, (bitmap.Height - overlay.Height) / 2));
            return BitmapHelper.ConvertToBI(bitmap);
        }
    }
}

using BarcodeLib;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeGenerator.Business
{
    public class BarcodeManager
    {


        public static Barcode CreateBarcode(string value, string path)
        {
            // Code 39 barkodunu oluşturmak için BarcodeLib sınıfını kullan
           // Barcode barcode = new Barcode();
            BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
            barcode.IncludeLabel = true;

            if (Control(value)==false)
            {
                Console.WriteLine("Hatalı barkod verisi girdiniz.");
                Console.ReadLine();
            }

            // Barkod türünü belirle
            barcode.Encode(BarcodeLib.TYPE.CODE39Extended, value, Color.Black, Color.White, 300, 100);

            // Barkod resmini kaydet
           barcode.SaveImage("C:\\Users\\hilal\\OneDrive\\Masaüstü\\"+path +".png", SaveTypes.JPG);

           

            Console.WriteLine("Code 39 barkodu oluşturuldu.");

            return barcode;
        }

        public static bool Control(string value)
        {
            char[] chracters = new[] { 'i', 'ü', 'ö', 'ç', 'ğ', 'ş' };

            for (int i = 0; i < chracters.Length; i++)
            {
                if (value.Contains(chracters[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static Image GetBarcode(string path)
        {
            
            Image barcodeImage = Image.FromFile(path);

            return barcodeImage;
        }
    }
}

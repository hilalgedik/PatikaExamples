using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtmProject.Entity;
using Process = AtmProject.Entity.Process;

namespace AtmProject.Business
{
    public class LogManager
    {
       


       public static string CreateTxt()
        {
            string filePath = "C:\\Users\\hilal\\OneDrive\\Masaüstü\\" + DateTime.Today.Day.ToString()+ DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString() + ".txt";

            //‪C:\Users\hilal\OneDrive\Masaüstü\Migrations işlemleri.txt

            if (!File.Exists(filePath))// = if (File.Exists(dosya_full_yol) == false)
            {
                File.Create(filePath);
            }
            StreamReader Kayit = new StreamReader(filePath);
            Kayit.Close();
            Console.WriteLine("Dosya oluşturuldu: " + filePath);
            return filePath;
        }

        public static bool WriteFile(Process process, string filePath)
        {
            string text = process.Id.ToString() + " " + process.ProcessName + " " + process.ProcessTime.ToString();

            File.WriteAllText(filePath, text);

            return true;
        }
    }
}

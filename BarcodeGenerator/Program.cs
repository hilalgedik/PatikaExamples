// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Drawing;
using BarcodeGenerator.Business;
using BarcodeLib;

//BARKOD OLUŞTURMAK İÇİN!
//Console.WriteLine("Barcode içeriği:");
//string value;
//value=Console.ReadLine();
//Console.WriteLine("Barcode nereye kayıt edilsin:");
//string path;
//path = Console.ReadLine();
//Barcode barcode;
//barcode =BarcodeManager.CreateBarcode(value,path);

//Console.WriteLine(barcode.EncodedValue);

//BARKOD UZANTISI VERİP BARKODU GÖRÜNTÜLEMEK İÇİN'
Console.WriteLine("Barkod yolu:");
string path;
path=Console.ReadLine();



Process process = new Process();
process.StartInfo.FileName = "mspaint.exe";
process.StartInfo.Arguments = path;
process.Start();




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeGenerator.Entity
{
    public class Barcode
    {
        public int Id { get; set; }
        //public string BarcodeName { get; set; }
        public string BarcodeValue { get; set; }
        public string BarcodePath { get; set; }
    }
}

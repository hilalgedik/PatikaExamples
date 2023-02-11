using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmProject.Entity
{
    public class Process
    {
        public int Id { get; set; } 
        public string ProcessName { get; set; }

        public DateTime ProcessTime { get; set; }

    }
}

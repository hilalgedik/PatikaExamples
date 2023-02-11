using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginForm.Entities
{
    public class Category:IEntity
    {
        public string CategoryName { get; set; }
        public int Vote { get; set; }

    }
}

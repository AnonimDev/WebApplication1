using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
    public class Car
    {
        public int id { set; get; }
        public string name { set; get; }
        public virtual Category Category { set; get; }
    }
}

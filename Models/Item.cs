using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testRest1.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ItemQuality { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

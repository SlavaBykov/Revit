using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeManager.Entity
{
    class Paint
    {
        public string Name { get; set; }
        public string GOST { get; set; }
        public double Count { get; set; }
        


        public Paint(string name = "ПФ-115 ГОСТ", string gost = "ГОСТ 6465-75", double count = 0) {
            Name = name;
            GOST = gost;
            Count = count;
            
        }
    }
}

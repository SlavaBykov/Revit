using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeManager.Entity
{
     struct Pipe
    {
        public double Diametr { get; set; }
        public double Length { get; set; }
        public double Area { get; set; }
        public string TypeIzol { get; set; }

        public Pipe(double diametr, double length, double area ,string typeIzol)
        {
            Diametr = diametr;
            Length = length;
            Area = area;
            TypeIzol = typeIzol;
        }
    }
}

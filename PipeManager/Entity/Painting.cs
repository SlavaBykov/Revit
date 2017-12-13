using PipeManager.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeManager.Entity
{
    class Painting  : Work
    {
        public Painting(string name, string unit, string note, double count) : base(name, unit, count, note)
        {
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeManager.Entity
{
    abstract class Work
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Note { get; set; }
        public double Count { get; set; }
        List<Work> list;

        public Work(string name, string unit, double count, string note) {
            Name = name;
            Unit = unit;
            Note = note;
            Count = count;
        }

    }
        

       
        

    }


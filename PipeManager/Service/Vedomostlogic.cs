using PipeManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeManager.Service
{
    class Vedomostlogic
    {
        public static double AmountAreaOfPaint_Coat(List<Pipe> list) {
            double count = 0;
            foreach (Pipe pipe in list) {
                if(pipe.TypeIzol != null) {
                    count += pipe.Area;
                }
            }
            return count;
        }

        public static double AmountAreaOfPaint_DontCoat(List<Pipe> list)
        {
            double count = 0;
            foreach (Pipe pipe in list)
            {
                if (pipe.TypeIzol == null)
                {
                    count += pipe.Area;
                }
            }
            return count;
        }

        List<Work> works = new List<Work>();
        





    }
}

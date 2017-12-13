using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeManager.Service
{
    class Converter
    {
        public static double FutInMillimetr(double x) => x * 304.8d;

        public static double SQ_FutIN_SQ_Metr(double x) => x * 0.092903d;

    }
}

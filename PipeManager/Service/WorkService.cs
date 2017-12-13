using PipeManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeManager.Service
{
    interface WorkService
    {
         List<Work> AddWork(Work work);
    }
}

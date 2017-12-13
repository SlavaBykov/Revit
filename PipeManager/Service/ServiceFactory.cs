using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeManager.Service
{
    class ServiceFactory
    {
        private static ServiceFactory instance;

        private ServiceFactory() { }

        public static ServiceFactory getInstance() {
            if(instance == null)
            {
                instance = new ServiceFactory();
            }
            return instance;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZBootstrapper
{
    class Lib
    {
        public enum Download
        {            
            DLDATA = 3,
            CHECKINGDATA = 2,
            DLDONE = 4,           
            CREATINGPATH = 1,
            UNZIPPING = 5
        }
    }
}

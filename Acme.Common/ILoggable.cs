using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public interface ILoggable
    {
        string Log();
        //es publico automaticamente
        //no escribimos la implementacion en la interface
    }
}

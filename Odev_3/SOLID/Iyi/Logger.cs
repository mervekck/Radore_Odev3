using Odev_3.SOLID.Kotu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3.SOLID.Iyi
{
    public class Logger : ILog
    {
        public ILog _ilog;
        public Logger(ILog ilog)
        {
            _ilog = ilog;
        }

        public void LogKaydet(string mesaj)
        {
            _ilog.LogKaydet(mesaj);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3.SOLID.Iyi
{
    public class DbLog : ILog
    {
        public void LogKaydet(string mesaj)
        {
            Console.WriteLine(mesaj + " db ye kaydedildi");
        }
    }
}

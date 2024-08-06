using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3.SOLID.Iyi
{
    public class JsonLog : ILog
    {
        public void LogKaydet(string mesaj)
        {
            Console.WriteLine(mesaj + " json a kaydedildi");
        }
    }
}

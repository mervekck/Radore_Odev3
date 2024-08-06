using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3.SOLID.Iyi
{
    public class XmlLog : ILog
    {
        public void LogKaydet(string mesaj)
        {
            Console.WriteLine(mesaj + " xml e kaydedildi");
        }
    }
}

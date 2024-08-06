using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3.SOLID.Kotu
{
    public class LoggerK
    {
        public DbLogK dbLog;
        public XmlLogK xmlLog;
        public JsonLogK jsonLog;

        public LoggerK(DbLogK dbLog, XmlLogK xmlLog, JsonLogK jsonLog)
        {
            this.dbLog = dbLog;
            this.xmlLog = xmlLog;
            this.jsonLog = jsonLog;
        }

        public void LogKaydet(LogTypeK type, string message)
        {
            switch (type)
            {
                case LogTypeK.Xml:
                    xmlLog.xmlKayit(message);
                    break;
                case LogTypeK.Db:
                    dbLog.dbKayit(message);
                    break;
                case LogTypeK.Json:
                    jsonLog.JsonYaz(message);
                    break;
            }
        }
    }
}

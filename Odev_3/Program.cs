// See https://aka.ms/new-console-template for more information
using Odev_3.SOLID.Iyi;
using Odev_3.SOLID.Kotu;

Console.WriteLine("Solid Kötü");
Console.WriteLine("----------------------------------------------");

XmlLogK xmlLog = new XmlLogK();
DbLogK dbLog = new DbLogK();
JsonLogK jsonLog = new JsonLogK();
LoggerK logger = new LoggerK(dbLog, xmlLog, jsonLog);
logger.LogKaydet(LogTypeK.Json, "303 nolu hata kodu oluştu");

Console.WriteLine("\nSolid İyi");
Console.WriteLine("----------------------------------------------");

ILog xml = new XmlLog();
Logger log = new Logger(xml);
new Logger(xml).LogKaydet("Xml 303 nolu hata kodu oluştu");

ILog db = new DbLog();
log = new Logger(db);
log.LogKaydet("Db 303 nolu hata kodu oluştu");

ILog json = new JsonLog();
log = new Logger(json);
log.LogKaydet("Json 303 nolu hata kodu oluştu");
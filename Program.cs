using System.Xml.Linq;
using System;
using System.Linq;

namespace LinqToXml
{
class Program
{
    static void Main(string[] args)
    {
        var xmldoC = XDocument.Load(@".\example.xml");
        XNamespace nonamespace = XNamespace.None;
        var xmlProducts = xmldoC.Descendants("book").Where(x => (string)x.Element("author") == "Corets, Eva");
        foreach (var item in xmlProducts)
        {
            Console.WriteLine(item.Element("title")?.Value);
        }
        Console.ReadKey();
    }
}
}








//var doc = XDocument.Load(@".\example.xml");
//XNamespace nonamespace = XNamespace.None;
//var xmlProducts = doc.Descendants("book").Where(x => (string)x.Element("author") == "Ralls, Kim");

//            //var addresses = from address in doc.Elements("Employee")
//            //                where (string)address.Element("Address").Element("City") == "Alta"
//            //                select address;
//            foreach (var item in xmlProducts)
//            {
//                var Sku = item.Element("title").Value;
//                //var Price = item.Element(“price”).Value;
//                //var Colour = item.Element(“colour”).Value;
//                //var Quantity = item.Element(“quantity”).Value;
//            }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    class IO
    {
        public static void SpremiXML(List<Tuple<float, string>> vrijednosti, string datoteka)
        {
            XElement vr = new XElement("vrijednosti");
            foreach (var v in vrijednosti)
            {
                XElement par = new XElement("par");
                par.Add(new XElement("vrijednost", v.Item1));
                par.Add(new XElement("opis", v.Item2));
                vr.Add(par);
            }
            XDocument xdoc = new XDocument(vr);
            xdoc.Save(datoteka);
        }
    }
}

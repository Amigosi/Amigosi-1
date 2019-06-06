using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    class StupcaniGrafikon:KoordinatniGrafikon
    {
        public StupcaniGrafikon(Form f, List<Tuple<float, string>> vrijednosti): base(f, vrijednosti) { }
        public override void Prikazi()
        {
            base.PripremiPrikaz();
            _NacrtajGrafikon();
        }
        private void _NacrtajGrafikon()
        {
            int sirinaStupca = (SirinaOkvira - (LijevaMargina + MARGINA_KOORDINATA + 10)) / Vrijednosti.Count - _RAZMAK_STUPACA;
            int pozicija = LijevaMargina + MARGINA_KOORDINATA + 10;
            foreach(var v in Vrijednosti)
            {
                _NacrtajStupac(v.Item1, pozicija, sirinaStupca);
                pozicija += sirinaStupca + _RAZMAK_STUPACA;
            }
        }
        private void _NacrtajStupac(float v,int x,int sirina)
        {
            float velicinaStupca = Math.Abs(v) / AbsMax*(Baza-MinY);
            int y = (int)(v > 0 ? Baza-velicinaStupca:Baza);
            int visina = (int)Math.Abs(velicinaStupca);
            GrafickiObjekt.FillRectangle(new SolidBrush(Color.Blue), x, y, sirina, visina);
        }
        private const int _RAZMAK_STUPACA = 5;
    }
}

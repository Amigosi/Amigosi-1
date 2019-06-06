using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1 {
    class LinijskiGrafikon : KoordinatniGrafikon {
        public LinijskiGrafikon(Form f, List<Tuple<float, string>> vrijednosti) : base(f, vrijednosti) { }

        public override void Prikazi() {
            base.PripremiPrikaz();
            _NacrtajGrafikon();
        }

        //=====================================================================

        private void _NacrtajGrafikon() {
            int sirinaTocke = (SirinaOkvira - (LijevaMargina + MARGINA_KOORDINATA + 10)) / Vrijednosti.Count - _RAZMAK;
            int pozicija = LijevaMargina + MARGINA_KOORDINATA + 10 + (sirinaTocke / 2);
            for (int i = 0; i < Vrijednosti.Count - 1; i++) {
                float v1 = Vrijednosti[i].Item1;
                float v2 = Vrijednosti[i + 1].Item1;
                float visinaTocke1 = Math.Abs(v1) / AbsMax * (Baza - MinY);
                float visinaTocke2 = Math.Abs(v2) / AbsMax * (Baza - MinY);

                float x1 = pozicija;
                float y1 = 0;
                float x2 = pozicija + sirinaTocke + _RAZMAK;
                float y2 = 0;
                if (v1 >= 0 && v2 >= 0) {
                    y1 = Baza - visinaTocke1;
                    y2 = Baza - visinaTocke2;
                } else if (v1 >= 0 && v2 < 0) {
                    y1 = Baza - visinaTocke1;
                    y2 = Baza + visinaTocke2;
                } else if (v1 < 0 && v2 >= 0) {
                    y1 = Baza + visinaTocke1;
                    y2 = Baza - visinaTocke2;
                } else if (v1 < 0 && v2 < 0) {
                    y1 = Baza + visinaTocke1;
                    y2 = Baza + visinaTocke2;
                }

                GrafickiObjekt.FillRectangle(new SolidBrush(Color.Green), (int)x1 - 4, (int)y1 - 4, 8, 8);
                GrafickiObjekt.FillRectangle(new SolidBrush(Color.Green), (int)x2 - 4, (int)y2 - 4, 8, 8);
                GrafickiObjekt.DrawLine(new Pen(Color.Blue, 2), (int)x1, (int)y1, (int)x2, (int)y2);
                pozicija += sirinaTocke + _RAZMAK;
            }
        }

        private const int _RAZMAK = 5;
    }
}
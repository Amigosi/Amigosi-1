using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    abstract class Grafikon
    {
        public Grafikon(Form f)
        {
            Forma = f;
            PostaviDimenzije();
        }
        public void PostaviDimenzije() {
            LijevaMargina = 10;
            GornjaMargina = 10;
            VisinaOkvira = Forma.Height - 60;
            SirinaOkvira = ((Form1)Forma).groupBox1.Location.X - 20;

        }

        public abstract void Prikazi();

        public virtual void PripremiPrikaz()
        {
            GrafickiObjekt = Forma.CreateGraphics();
            PostaviDimenzije();
            _NacrtajOkvir();
        }


        public Graphics GrafickiObjekt;
        public Form Forma;
        public int LijevaMargina;
        public int GornjaMargina;
        public int VisinaOkvira;
        public int SirinaOkvira;

        private void _NacrtajOkvir()
        {
            GrafickiObjekt.DrawRectangle(new Pen(Color.Black, 1)
                , LijevaMargina,
                GornjaMargina,
                SirinaOkvira,
                VisinaOkvira
                );
            GrafickiObjekt.FillRectangle(new SolidBrush(Color.Beige)
                , LijevaMargina + 1,
                GornjaMargina + 1,
                SirinaOkvira - 1,
                VisinaOkvira - 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Tuple<float,string>> _ProcitajVrijednosti()
        {
            var vrijednosti = new List<Tuple<float, string>>();
            DataGridViewRowCollection retci = dataGridView1.Rows;
            foreach(DataGridViewRow redak in retci)
            {
                if (redak.Cells[0].Value == null && redak.Cells[1].Value == null)
                    break;
                float v = redak.Cells[0].Value == null ? 0 : float.Parse(redak.Cells[0].Value.ToString());
                string opis = redak.Cells[1].Value == null ? "" : redak.Cells[1].Value.ToString();
                vrijednosti.Add(Tuple.Create(v, opis));
            }
            return vrijednosti;
        }
        private void groupBox1_Enter(object sender,EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }




        private void button_test_Click(object sender, EventArgs e)
        {
            //Grafikon g = new Grafikon(this);
            //g.PostaviDimenzije();
            //g.PripremiPrikaz();
            //var v = new List<Tuple<float, string>>
           // {
             //   new Tuple<float, string>(5,""),
             //   new Tuple<float, string>(-17, ""),
             //   new Tuple<float, string>(22,""),
             //   new Tuple<float, string>(2,"")
           // };
            Grafikon k = new LinijskiGrafikon(this, _ProcitajVrijednosti());
            k.Prikazi();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vrijednosti = _ProcitajVrijednosti();
            var dlg = new SaveFileDialog();
            dlg.ShowDialog();
            if (dlg.FileName == "")
            {
                return;
            }
            switch (comboBox1.Text)
            {
                case "XML":
                    dlg.Filter = "Xml|.xml";
                    break;
                case "CSV":
                    dlg.Filter = "Csv|.csv";
                    break;
                default:
                    MessageBox.Show("Odaberite format podataka");
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

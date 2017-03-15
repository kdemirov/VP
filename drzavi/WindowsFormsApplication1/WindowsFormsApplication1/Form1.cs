using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Countries pogodi;
        int pogodeni = 0;
        int vkupno = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbCountries.Items.Add(new Countries("Makedonija", "Skopje", "MK"));
            lbCountries.Items.Add(new Countries("Bugarija", "Sofia", "BG"));
            lbCountries.Items.Add(new Countries("United States of America", "Wasington", "USA"));
            lbCountries.Items.Add(new Countries("Germanija", "Berlin", "GE"));
            lbCountries.Items.Add(new Countries("Albania", "Tirana", "AL"));
            lbCountries.Items.Add(new Countries("Srbija", "Belgrade", "SR"));
            lbCountries.Items.Add(new Countries("Croatia", "Zagreb", "CR"));
            lbCountries.Items.Add(new Countries("Turcija", "Istanbul", "TR"));

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbCountries.Items.Add(new Countries(tbCounty.Text, tbCapital.Text, tbShortName.Text));
            tbCounty.Clear();
            tbCapital.Clear();
            tbShortName.Clear();



        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbCountries.Items.RemoveAt(lbCountries.SelectedIndex);
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            btnGuess.Enabled = true;
            List<Countries> povik = new List<Countries>();
          
            foreach(object obj in lbCountries.Items)
            {
                povik.Add((Countries)obj);
               
            }
            List<Countries> vrati = hqess(povik, 3);
            int i =new Random().Next(vrati.Count);
            pogodi = vrati[i];
            btnQuestion.Text = String.Format("Glaven Grad na Drzavata {0}",pogodi.Name);
       
            rbA1.Text = vrati[0].Capital;
            rbA2.Text = vrati[1].Capital;
            rbA3.Text = vrati[2].Capital;
        }
         List<Countries> hqess(List<Countries> country, int n)
        {
            List<Countries> lista = new List<Countries>();
            HashSet<Countries> mapa = new HashSet<Countries>();
            while(lista.Count!=n)
            { 
                int random = new Random().Next(lbCountries.Items.Count);
                if (!mapa.Contains(country[random])){
                    lista.Add(country[random]);
                    mapa.Add(country[random]);
                }
            }
            return lista;

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
           
            if (rbA1.Checked == true && pogodi.Capital == rbA1.Text)
            {
                pogodeni++;
                vkupno++;
            }
            else if (rbA2.Checked == true && pogodi.Capital == rbA2.Text)
            {
                pogodeni++;
                vkupno++;
            }
            else if (rbA3.Checked == true && pogodi.Capital == rbA3.Text)
            {
                pogodeni++;
                vkupno++;
            }
            else
                vkupno++;
            laPoints.Text = String.Format("{0}/{1}", pogodeni, vkupno);
            
        }
    }
   

}

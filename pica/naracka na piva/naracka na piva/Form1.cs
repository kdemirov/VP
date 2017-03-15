using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace naracka_na_piva
{
    public partial class Form1 : Form
    {
        int SumPizza()
        {
            int suma = 0;
            if (rbSmall.Checked)
                suma += Convert.ToInt32(tbSmall.Text);
            if (rbMiddle.Checked)
                suma += Convert.ToInt32(tbMiddle.Text);
            if (rbBig.Checked)
                suma += Convert.ToInt32(tbBig.Text);
            return suma;
        }
        int SumDrink()
        {
            int suma = 0;
            int quaCola = Convert.ToInt32(tbQuaCola.Text);
            int quaJuice = Convert.ToInt32(tbQuaJuice.Text);
            int quaBeer = Convert.ToInt32(tbQuaBeer.Text);
            int priceCola= Convert.ToInt32(tbPriceCola.Text);
            int priceJuice = Convert.ToInt32(tbPriceJuice.Text);
            int priceBeer = Convert.ToInt32(tbPriceBeer.Text);
            suma += (quaCola * priceCola) + (quaBeer * priceBeer) + (quaJuice * priceJuice);
            return suma;
        }
        int SumAdd()
        {
            int suma = 0;
            if (cbCheese.Checked)
                suma += Convert.ToInt32(tbCheese.Text);
            if (cbFef.Checked)
                suma += Convert.ToInt32(tbFef.Text);
            if (cbKecap.Checked)
                suma += Convert.ToInt32(tbKecap.Text);
            return suma;
        }
        int SumDessert()
        {
            int suma = 0;
            if(lbDesserts.SelectedIndex!=-1)
            {
                suma +=Convert.ToInt32( tbPriceDessert.Text);
            }
            return suma;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pizza Mala = new naracka_na_piva.Pizza("Мала", 200);
            Pizza Sredna = new naracka_na_piva.Pizza("Средна", 300);
            Pizza Golema = new naracka_na_piva.Pizza("Голема", 500);
            rbSmall.Text = Mala.ToString();
            rbMiddle.Text = Sredna.ToString();
            rbBig.Text = Golema.ToString();
            tbSmall.Text = Mala.Cena.ToString();
            tbMiddle.Text = Sredna.Cena.ToString();
            tbBig.Text = Golema.Cena.ToString();
            Desert OvosnaPita = new Desert("Овошна Пита", 80);
            Desert Sladoled = new Desert("Сладолед", 60);
            Desert Torta = new Desert("Торта", 120);
            lbDesserts.Items.Add(OvosnaPita);
            lbDesserts.Items.Add(Sladoled);
            lbDesserts.Items.Add(Torta);
            tbSum.Text = (SumDrink()+SumPizza()+SumAdd()+SumDessert()).ToString();


        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
        }

        private void rbMiddle_CheckedChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
        }

        private void rbBig_CheckedChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
        }

        private void tbSmall_TextChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
        }

        private void tbMiddle_TextChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
        }

        private void tbBig_TextChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
        }

        private void cbFef_CheckedChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
        }

        private void cbCheese_CheckedChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
        }

        private void cbKecap_CheckedChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
        }

        private void tbFef_TextChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
        }

        private void tbCheese_TextChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
        }

        private void tbKecap_TextChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
        }

        private void tbPriceDessert_TextChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
        }

        private void lbDesserts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Desert nov =(Desert) lbDesserts.SelectedItem;
            tbPriceDessert.Text = nov.Cena.ToString();
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
        }

        private void tbQuaCola_TextChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
            tbCola.Text = (Convert.ToInt32(tbQuaCola.Text)* Convert.ToInt32(tbPriceCola.Text)).ToString();

        }

        private void tbQuaJuice_TextChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
            tbJuice.Text = (Convert.ToInt32(tbQuaJuice.Text) * Convert.ToInt32(tbPriceJuice.Text)).ToString();
        }

        private void tbQuaBeer_TextChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
            tbBeer.Text = (Convert.ToInt32(tbQuaBeer.Text) * Convert.ToInt32(tbPriceBeer.Text)).ToString();
        }

        private void tbPriceBeer_TextChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
            tbBeer.Text = (Convert.ToInt32(tbQuaBeer.Text) * Convert.ToInt32(tbPriceBeer.Text)).ToString();
        }

        private void tbPriceJuice_TextChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
            tbJuice.Text = (Convert.ToInt32(tbQuaJuice.Text) * Convert.ToInt32(tbPriceJuice.Text)).ToString();
        }

        private void tbPriceCola_TextChanged(object sender, EventArgs e)
        {
            tbSum.Text = (SumDrink() + SumPizza() + SumAdd() + SumDessert()).ToString();
            tbCola.Text = (Convert.ToInt32(tbQuaCola.Text) * Convert.ToInt32(tbPriceCola.Text)).ToString();
        }

        private void tbNaplateno_TextChanged(object sender, EventArgs e)
        {
            int vkupna = SumDrink() + SumPizza() + SumAdd() + SumDessert();
            int naplateno = Convert.ToInt32(tbNaplateno.Text);
            tbZaVrakanje.Text = (naplateno - vkupna).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сакате да ја откажете нарачката?", "Откажи нарачка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string cel = "";
            if (rbSmall.Checked)
                cel += "Мала пица";
            if (rbMiddle.Checked)
                cel += "Средна пица";
            if (rbBig.Checked)
                cel += "Голема пица";
            DialogResult result = MessageBox.Show(cel, "Вашата нарачка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

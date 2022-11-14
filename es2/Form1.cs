using System;
using System.Windows.Forms;

namespace areaTrapezio_param
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double baseMinore;
        double baseMaggiore;
        double altezza;

        double lato;
        double perimetro;
        double area;

        private void input()
        {
            baseMinore = Convert.ToDouble(txtBMinore.Text);
            baseMaggiore = Convert.ToDouble(txtBMaggiore.Text);
            altezza = Convert.ToDouble(txtAltezza.Text);
        }

        private double calcoloLato(double bm, double bM, double h)
        {
            lato = Math.Sqrt((bM - bm) / 2 + Math.Pow(h, 2));
            return lato;
        }

        private double calcoloPerimetro(double bm, double bM, double l)
        {
            perimetro = bM + bm + (l * 2);
            return perimetro;
        }

        private double calcoloArea(double bm, double bM, double h)
        {
            area = ((bm + bM) * h) / 2;
            return area;
        }

        private void output()
        {
            perimetro = Math.Round(perimetro, 2);
            area = Math.Round(area, 2);

            txtPerimetro.Text = perimetro.ToString();
            txtArea.Text = area.ToString();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            input();
            calcoloLato(baseMinore, baseMaggiore, altezza);
            calcoloPerimetro(baseMinore, baseMaggiore, lato);
            calcoloArea(baseMinore, baseMaggiore, altezza);
            output();
        }
    }
}

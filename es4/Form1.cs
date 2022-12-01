using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
/*
Per un viaggio in nave si pagano TOT
euro a persona, con uno sconto del 25% se si viaggia in “passaggio ponte”.
Sviluppare un programma per visualizzare il costo del viaggio per una famiglia di N persone,
con auto al seguito che influirà sul costo per 85 Euro.
*/

namespace paramsIndirizzo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insDati(out byte np, out float pr)
        {
            np = Convert.ToByte(txtnPersone.Text);
            pr = Convert.ToSingle(txtPrezzo.Text);
        }

        private void calcola(ref byte np, ref float pr)
        {
            bool passaggioPonte, auto;

            passaggioPonte = Convert.ToBoolean(Interaction.InputBox("Passaggio ponte? (true/false)"));
            auto = Convert.ToBoolean(Interaction.InputBox("Auto? (true/false)"));

            pr += np * pr;

            if(passaggioPonte)
            {
                pr -= (pr * 25) / 100;
            }
            if (auto)
            {
                pr += 85;
            }
        }

        private void output(float pr)
        {
            txtPrTot.Text = pr.ToString();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            byte nPersone;
            float prezzo = 0;
           
            insDati(out nPersone, out prezzo);
            calcola(ref nPersone, ref prezzo);
            output(prezzo);
        }
    }
}

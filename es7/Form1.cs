using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/*
La stazione di Pirri deve tenere conto dei pendolari che prendono il treno per recarsi in cittadella, per verificare la convenienza a tenere questa rotta, 
si vuole sviluppare un programma che, tenuto conto che il biglietto costa 1.60 per tutti, calcoli il totale incassi e il parziale di coloro che scendono a Pirri. 
Si deve visualizzate pertanto il totale generale, il totale parziale e il numero dei pendolari per Pirri
*/

namespace Pirri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const float costo = 1.60F;

        private int insDati(TextBox txt)
        {
            int n = Convert.ToInt32(txt.Text);
            return n;
        }

        private void calcola(out bool sAP)
        {
            sAP = Convert.ToBoolean(Interaction.InputBox("Scende a Pirri? (true/false)"));

            if (sAP)
            {
                // da completare
            }
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            int nPersone;
            bool scendeAPirri;

            nPersone = insDati(txtnPersone);

            for (int i = 1; i <= nPersone; i++)
            {
                calcola(out scendeAPirri);

                visualizza() // da completare
            }
        }
    }
}

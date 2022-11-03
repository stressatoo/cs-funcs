using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/* Esercizio sui sottoprogrammi per il 4 novembre
 * Un negozio all'ingrosso di frutta e verdura acquista giornalmente una certa quantità di frutta.
 * Si vuole gestire un programma che, inserito da tastiera il tipo di prodotto, la sua quantità ed il costo,
 * visualizzi il totale acquistato in termini di quantità espresse in quintali e la spesa sostenuta.
 * Eseguire l'esercizio con due sottoprogrammi, uno per l'inserimento dei dati e l'elaborazione ed uno per la visualizzazione.
 */

namespace esercizio_funcs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte nProd; // numero prodotti
        
        string tipo;
        byte quant; // quantità in quintali
        float prezzoUnit;

        float prezzo;

        float accQuant = 0;
        float accPrezzo = 0;

        private void insDati_Elab()
        {
            nProd = Convert.ToByte(txtnProdotti.Text);

            for (int i = 1; i <= nProd; i++)
            {
                tipo = Interaction.InputBox("Inserire tipo prodotto");
                quant = Convert.ToByte(Interaction.InputBox("Inserire quantità prodotto (in quintali)"));
                prezzoUnit = Convert.ToSingle(Interaction.InputBox("Inserire prezzo del relativo prodotto"));

                prezzo = quant * prezzoUnit;

                accQuant += quant;
                accPrezzo += prezzo;
            }
        }

        private void output()
        {
            txtTotInQ.Text = accQuant.ToString();
            txtTotSpesa.Text = accPrezzo.ToString();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            insDati_Elab();
            output();
        }
    }
}

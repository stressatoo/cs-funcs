using System;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;

/*
In un agrumeto si producono arance e mandarini da destinare al mercato estero. 

Ogni giorno si raccolgono gli agrumi e si inseriscono in due vettori, arance e mandarini, le quantità, in quintali, del raccolto. 

Questa operazione viene fatta per un mese il cui numero di giorni va inserito in input, (gen 31, feb 28 ecc). 
Si vogliono conoscere i totali dei due vettori, singoli e insieme, il raccolto maggiore per ogni categoria ed il giorno del mese in cui è stato prodotto.
*/

namespace esercitazioneVettori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte inserisciGiorni()
        {
            byte _giorni;

            _giorni = Convert.ToByte(txtGiorni.Text);

            return _giorni;
        }

        void input(ref int[] vettore, int contatore, string tipo)
        {
            vettore[contatore] = Convert.ToInt32(Interaction.InputBox("Inserire quantità raccolte di " + tipo + ", in quintali, per il giorno numero " + (contatore+1)));
        }

        void calcolaTotaleParziale(ref int accumulatore, int[] vettore, int contatore)
        {
            accumulatore += vettore[contatore];
        }

        int somma(int numero1, int numero2)
        {
            int risultato = numero1 + numero2;
            return risultato;
        }

        int calcolaMassimo(int[] vettore)
        {
            int massimo;
            massimo = vettore.Max();
            return massimo;
        }

        void output(int cA, int cM, int tA, int mA, int mM)
        {
            txtTotParz_Arance.Text = cA.ToString();
            txtTotParz_Mandarini.Text = cM.ToString();
            txtTotale.Text = tA.ToString();
            txtMaxArance.Text = mA.ToString();
            txtMaxMandarini.Text = mM.ToString();
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            // Giorni (Dimensioni di entrambi i vettori)
            byte giorni = inserisciGiorni();

            // Vettori
            int[] arance = new int[giorni];
            int[] mandarini = new int[giorni];

            // Tipi
            const string sA = "arance";
            const string sM = "mandarini";

            // Totali parziali
            int cArance = 0;
            int cMandarini = 0;

            // Totale
            int totaleAgrumi = 0;

            // Massimi
            int maxArance;
            int maxMandarini;

            for (int i = 0; i < giorni; ++i)
            {
                // Input del contenuto in entrambi i vettori
                input(ref arance, i, sA);
                input(ref mandarini, i, sM);

                // Calcolo totali parziali
                calcolaTotaleParziale(ref cArance, arance, i);
                calcolaTotaleParziale(ref cMandarini, mandarini, i);

                totaleAgrumi = somma(cArance, cMandarini);
            }

            maxArance = calcolaMassimo(arance);
            maxMandarini = calcolaMassimo(mandarini);

            output(cArance, cMandarini, totaleAgrumi, maxArance, maxMandarini);
        }
    }
}

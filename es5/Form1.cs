using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace esercizioIMU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const float IMU = 0.07F; 

        private void insDati(out byte nf, TextBox txt)
        {
            nf = Convert.ToByte(txt.Text);
        }

        private float calcolaImporto(out float r, out float impIMU, byte i, ref float tot)
        {
            r = Convert.ToSingle(Interaction.InputBox("Inserire rendita catastale per il fabbricato numero " + i));
            impIMU = r * IMU;

            tot += impIMU;

            return impIMU;
        }

        private void outputSingolo(float dato, ListBox lst)
        {
            lst.Items.Add(dato);
        }

        private void outputTot(float dato, TextBox txt)
        {
            txt.Text = dato.ToString();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            byte nFabbricati;

            float rendita;
            float impIMU;

            float totale = 0;

            insDati(out nFabbricati, txtNFabbricati);

            for (byte i = 1; i <= nFabbricati; ++i)
            {
                impIMU = calcolaImporto(out rendita, out impIMU, i, ref totale);
                outputSingolo(impIMU, lstImu);
            }

            outputTot(totale, txtTot);

        }
    }
}

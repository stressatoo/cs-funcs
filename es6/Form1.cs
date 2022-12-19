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

        private float calcolaImporto(float[] r, float impIMU, byte i, ref float tot)
        {
            r[i] = Convert.ToSingle(Interaction.InputBox("Inserire rendita catastale per il fabbricato numero " + i+1));
            impIMU = r[i] * IMU;

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

            float impIMU = 0;

            float totale = 0;

            insDati(out nFabbricati, txtNFabbricati);

            float[] rendita = new float[nFabbricati];

            for (byte i = 0; i < nFabbricati; ++i)
            {
                impIMU = calcolaImporto(rendita, impIMU, i, ref totale);
                outputSingolo(impIMU, lstImu);
            }

            outputTot(totale, txtTot);

        }
    }
}

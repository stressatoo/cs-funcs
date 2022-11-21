using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace params_Spesa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private float calcolaC(float costo, float quantita)
        {
            float tp;

            tp = costo * quantita;

            return tp;
        }

        private void vis(float dato, Label l)
        {
            l.Text = dato.ToString();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            float totC = 0;
            float totQ = 0;
            float c, q;
            string n;
            bool r;

            do
            {
                n = Interaction.InputBox("Inserire tipo");
                c = Convert.ToSingle(Interaction.InputBox("Inserire costo unitario"));
                q = Convert.ToSingle(Interaction.InputBox("Inserire peso in quintali"));

                totC += calcolaC(c, q);
                totQ += q;

                r = Convert.ToBoolean(Interaction.InputBox("Continuare? (true/false)"));
            } while (r);

            vis(totC, lblTotC);
            vis(totQ, lblTotQ);
        }
    }
}

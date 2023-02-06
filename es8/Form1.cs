using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/* 
 * Acquisire i nomi di un gruppo di persone,
 * ... vettore -... output
 */

namespace arrayNomi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] inputNomi(string[] vettore, int i)
        {
            vettore[i] = Interaction.InputBox("Inserire nome numero " + i++);
            return vettore;
        }

        private void output(string[] vettore, int i, ListBox lst)
        {
            lst.Items.Add(vettore[i]);
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            int dimensione;

            dimensione = Convert.ToInt32(txtDimensione.Text);

            string[] nomi = new string[dimensione];

            for (int i = 0; i < dimensione; ++i)
            {
                inputNomi(nomi, i);
                output(nomi, i, lstLista);
            }
        }
    }
}

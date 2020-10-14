using System;

using System.Windows.Forms;

namespace FormComplejo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (rdbSuma.Checked)
            {
                float real = float.Parse(txtbCompReal1.Text);
                float imaginaria = float.Parse(txtbCompImag1.Text);
                Complejo c1 = new Complejo(real, imaginaria);
                real = float.Parse(txtbCompReal2.Text);
                imaginaria = float.Parse(txtbCompImag2.Text);
                Complejo c2 = new Complejo(real, imaginaria);
                Complejo c3 = c1 + c2;
                lbResultado.Text = c3.ToString();
            }
        }

        private void rdbSuma_CheckedChanged(object sender, EventArgs e)
        {
            lbConjuga.Visible = false;
            lbOperador.Text = "+";
        }

        private void rdbResta_CheckedChanged(object sender, EventArgs e)
        {
            lbConjuga.Visible = false;
            lbOperador.Text = "-";
        }

        private void rdbMult_CheckedChanged(object sender, EventArgs e)
        {
            lbConjuga.Visible = false;
            lbOperador.Text = "x";
        }

        private void rdbConjuga_CheckedChanged(object sender, EventArgs e)
        {
            lbConjuga.Visible = true;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (rdbResta.Checked)
            {
                float real = float.Parse(txtbCompReal1.Text);
                float imaginaria = float.Parse(txtbCompImag1.Text);
                Complejo c1 = new Complejo(real, imaginaria);
                real = float.Parse(txtbCompReal2.Text);
                imaginaria = float.Parse(txtbCompImag2.Text);
                Complejo c2 = new Complejo(real, imaginaria);
                Complejo c3 = c1 - c2;
                lbResultado.Text = c3.ToString();
            }

        }
    }
}

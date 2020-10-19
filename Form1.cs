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
                try
                {
                    float real = float.Parse(txtbCompReal1.Text);
                    float imaginaria = float.Parse(txtbCompImag1.Text);
                    if (chkbSemiPlanoSuperior.Checked && imaginaria < 0)
                    {
                        throw new ApplicationException("La parte imaginaria debe ser mayor o igual a cero");
                    }
                    Complejo c1 = new Complejo(real, imaginaria);
                    real = float.Parse(txtbCompReal2.Text);
                    imaginaria = float.Parse(txtbCompImag2.Text);
                    Complejo c2 = new Complejo(real, imaginaria);
                    Complejo c3 = c1 + c2;
                    lbResultado.Text = c3.ToString();
                    if( chkbSemiPlanoSuperior.Checked && imaginaria < 0   )
                    {
                        throw new ApplicationException("La parte imaginaria debe ser mayor o igual a cero");
                    }
                }
                //Excepciones más específicas
                catch(ApplicationException error)
                {
                    MessageBox.Show(error.Message);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error, debes de ingresar un número ");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }
                
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

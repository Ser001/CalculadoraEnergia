using System;
using System.Windows.Forms;

namespace CalculadoraEnergia
{
    public partial class CalculadoraKhw : Form
    {
        public CalculadoraKhw()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLeituraAtual.Text, out double leituraAtual) &&
        double.TryParse(txtLeituraAnterior.Text, out double leituraAnterior) &&
        double.TryParse(textBoxValorKWH.Text, out double valorKwh))
            {
                double consumo = leituraAtual - leituraAnterior;
                double total = consumo * valorKwh / 100;
                textBoxResultado.Text = total.ToString("C2");

                txtLeituraAtual.Text = leituraAtual.ToString("#,##0.00");
                txtLeituraAnterior.Text = leituraAnterior.ToString("#,##0.00");
            }
            else
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos em todas as caixas de texto.", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxValorKWH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLeituraAtual_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            txtLeituraAtual.Clear();
            txtLeituraAnterior.Clear();
            textBoxValorKWH.Clear();
            textBoxResultado.Clear();
        }
    }
}


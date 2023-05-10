namespace PrjWinFormAtividadesLogicaCalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            decimal primeironumero, segundonumero, resultado, op;

            primeironumero = decimal.Parse(textBoxNumero1.Text);
            segundonumero = decimal.Parse(textBoxNumero2.Text);

            if (radioBtAdicao.Checked)
            {
                resultado = primeironumero + segundonumero;
                textBoxResultado.Text = resultado.ToString();
            }
            else if (radioBtSub.Checked)
            {
                resultado = primeironumero - segundonumero;
                textBoxResultado.Text = resultado.ToString();
            }
            else if (radioBtMulti.Checked)
            {
                resultado = primeironumero * segundonumero;
                textBoxResultado.Text = resultado.ToString();
            }
            else
            {
                resultado = primeironumero / segundonumero;
                textBoxResultado.Text = resultado.ToString();
            }
        }
    }
}
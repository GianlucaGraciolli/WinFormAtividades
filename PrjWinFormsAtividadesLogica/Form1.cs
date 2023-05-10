namespace PrjWinFormsAtividadesLogica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelReal_Click(object sender, EventArgs e)
        {

        }

        private void textBoxReal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal valorReal, resultado;
            valorReal = decimal.Parse(textBoxReal.Text);

            if (decimal.TryParse(textBoxReal.Text, out decimal res) == false)
            {
                
            }    
            {

            }
            if (radioButtonEuro.Checked)
            {
                resultado = valorReal * 0.18m;

                labelresultado.Text = $"Resultado Conversão - E$ {resultado.ToString("n2")}";
            }
            else
            {
                resultado = valorReal * 0.20m;

                labelresultado.Text = $"Resultado da Conversão - U$ {resultado.ToString("n2")}";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonEuro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
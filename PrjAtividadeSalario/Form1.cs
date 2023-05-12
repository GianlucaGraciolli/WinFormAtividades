namespace PrjAtividadeSalario
{
    public partial class FormSalario : Form
    {
        public FormSalario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal salbruto, valetransportedif, conveniodif, impostodif, salliquido, difgeral=0;
            salbruto = decimal.Parse(txtBoxSalBruto.Text);
            if (checkBoxTransporte.Checked == true)
            {
                valetransportedif = (salbruto / 100) * 6;
                difgeral = valetransportedif;
            }
            if (checkBoxConvenio.Checked == true)
            {
                conveniodif = 20;
                difgeral = difgeral + conveniodif;
            }
                if (salbruto < 980)
                {
                    impostodif = (salbruto / 100) * 8;
                }
                else if (salbruto >= 980 && salbruto < 1450)
                {
                    impostodif = (salbruto / 100) * 9;
                }
                else if (salbruto >= 1450 && salbruto < 2120)
                {
                    impostodif = (salbruto / 100) * 10;
                }
                else
                {
                    impostodif = (salbruto / 100) * 11;
                }
                difgeral = difgeral + impostodif;
            
            salliquido = salbruto - difgeral;
            MessageBox.Show(salliquido.ToString("n2"));
        }
    }
}
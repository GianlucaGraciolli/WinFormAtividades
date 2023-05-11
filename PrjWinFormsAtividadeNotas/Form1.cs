namespace PrjWinFormsAtividadeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelNota2_Click(object sender, EventArgs e)
        {

        }

        private void labelNota1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal nota1, nota2, nota3, faltas, media;
            nota1 = numNota1.Value;
            nota2 = numNota2.Value;
            nota3 = numNota3.Value;
            faltas = numFaltas.Value;

            media = (nota1 + nota2 + nota3) / 3;

            if (decimal.TryParse(faltas, out decimal res) == true )
            {

            }

            if (numFaltas.Value > 12)
            {
                MessageBox.Show("Aluno Reprovado por exceder número de faltas.", "Aviso!");
                numNota1.Value = 0 ; numNota2.Value = 0 ; numNota3.Value = 0 ; numFaltas.Value = 0 ;
                numNota1.Focus();              
            }
            else
            {
                if (media < 4)
                {
                    MessageBox.Show($" Aluno reprovado por não obter nota mínima para recuperação.\n (Abaixo de 4)\n Média Final do aluno: {media.ToString("N1")}", "Aviso!");
                    numNota1.Value = 0; numNota2.Value = 0; numNota3.Value = 0; numFaltas.Value = 0;
                    numNota1.Focus();
                }
                else if (media >= 4 && media <= 5.5m)
                {
                    MessageBox.Show($" Aluno será julgado pelo conselho.\n (Média entre 4 e 5,5)\n Média Final do aluno: {media.ToString("n2")}", "Aviso!");
                    numNota1.Value = 0; numNota2.Value = 0; numNota3.Value = 0; numFaltas.Value = 0;
                    numNota1.Focus();
                }
                else

                {
                    MessageBox.Show($" Aluno Aprovado.\n (Média acima de 5,5)\n Média Final do aluno: {media.ToString("n2")}", "Aviso!");
                    numNota1.Value = 0; numNota2.Value = 0; numNota3.Value = 0; numFaltas.Value = 0;
                    numNota1.Focus();
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
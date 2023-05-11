namespace PrjWinFormsAtividadeNotas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNota1 = new Label();
            labelNota2 = new Label();
            labelNota3 = new Label();
            labelTitulo = new Label();
            numNota1 = new NumericUpDown();
            numNota2 = new NumericUpDown();
            numNota3 = new NumericUpDown();
            labelFaltas = new Label();
            numFaltas = new NumericUpDown();
            buttonVerificacao = new Button();
            ((System.ComponentModel.ISupportInitialize)numNota1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNota2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNota3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFaltas).BeginInit();
            SuspendLayout();
            // 
            // labelNota1
            // 
            labelNota1.AutoSize = true;
            labelNota1.BackColor = Color.DodgerBlue;
            labelNota1.Font = new Font("High Tower Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelNota1.Location = new Point(133, 92);
            labelNota1.Name = "labelNota1";
            labelNota1.Size = new Size(149, 28);
            labelNota1.TabIndex = 7;
            labelNota1.Text = "Primeira Nota";
            labelNota1.Click += labelNota1_Click;
            // 
            // labelNota2
            // 
            labelNota2.AutoSize = true;
            labelNota2.BackColor = Color.DodgerBlue;
            labelNota2.Font = new Font("High Tower Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelNota2.Location = new Point(134, 150);
            labelNota2.Name = "labelNota2";
            labelNota2.Size = new Size(148, 28);
            labelNota2.TabIndex = 8;
            labelNota2.Text = "Segunda Nota";
            labelNota2.Click += labelNota2_Click;
            // 
            // labelNota3
            // 
            labelNota3.AutoSize = true;
            labelNota3.BackColor = Color.DodgerBlue;
            labelNota3.Font = new Font("High Tower Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelNota3.Location = new Point(133, 211);
            labelNota3.Name = "labelNota3";
            labelNota3.Size = new Size(148, 28);
            labelNota3.TabIndex = 9;
            labelNota3.Text = "Terceira Nota";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.DodgerBlue;
            labelTitulo.Font = new Font("High Tower Text", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.Location = new Point(149, 33);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(251, 34);
            labelTitulo.TabIndex = 6;
            labelTitulo.Text = "Aprovação - Alunos";
            // 
            // numNota1
            // 
            numNota1.BackColor = Color.DarkGray;
            numNota1.Location = new Point(288, 97);
            numNota1.Name = "numNota1";
            numNota1.Size = new Size(120, 23);
            numNota1.TabIndex = 1;
            // 
            // numNota2
            // 
            numNota2.BackColor = Color.DarkGray;
            numNota2.Location = new Point(288, 158);
            numNota2.Name = "numNota2";
            numNota2.Size = new Size(120, 23);
            numNota2.TabIndex = 2;
            numNota2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numNota3
            // 
            numNota3.BackColor = Color.DarkGray;
            numNota3.Location = new Point(287, 216);
            numNota3.Name = "numNota3";
            numNota3.Size = new Size(120, 23);
            numNota3.TabIndex = 3;
            // 
            // labelFaltas
            // 
            labelFaltas.AutoSize = true;
            labelFaltas.BackColor = Color.DodgerBlue;
            labelFaltas.Font = new Font("High Tower Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelFaltas.Location = new Point(159, 270);
            labelFaltas.Name = "labelFaltas";
            labelFaltas.Size = new Size(104, 28);
            labelFaltas.TabIndex = 10;
            labelFaltas.Text = "Nº Faltas";
            // 
            // numFaltas
            // 
            numFaltas.BackColor = Color.DarkGray;
            numFaltas.Location = new Point(287, 275);
            numFaltas.Name = "numFaltas";
            numFaltas.Size = new Size(120, 23);
            numFaltas.TabIndex = 4;
            // 
            // buttonVerificacao
            // 
            buttonVerificacao.BackColor = Color.DarkGray;
            buttonVerificacao.Font = new Font("High Tower Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVerificacao.Location = new Point(200, 330);
            buttonVerificacao.Name = "buttonVerificacao";
            buttonVerificacao.Size = new Size(155, 54);
            buttonVerificacao.TabIndex = 5;
            buttonVerificacao.Text = "Verificar Situação";
            buttonVerificacao.UseVisualStyleBackColor = false;
            buttonVerificacao.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(544, 450);
            Controls.Add(buttonVerificacao);
            Controls.Add(numFaltas);
            Controls.Add(labelFaltas);
            Controls.Add(numNota3);
            Controls.Add(numNota2);
            Controls.Add(numNota1);
            Controls.Add(labelTitulo);
            Controls.Add(labelNota3);
            Controls.Add(labelNota2);
            Controls.Add(labelNota1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numNota1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNota2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNota3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFaltas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNota1;
        private Label labelNota2;
        private Label labelNota3;
        private Label labelTitulo;
        private NumericUpDown numNota1;
        private NumericUpDown numNota2;
        private NumericUpDown numNota3;
        private Label labelFaltas;
        private NumericUpDown numFaltas;
        private Button buttonVerificacao;
    }
}
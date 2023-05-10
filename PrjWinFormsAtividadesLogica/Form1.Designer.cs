namespace PrjWinFormsAtividadesLogica
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
            labelReal = new Label();
            textBoxReal = new TextBox();
            radioButtonEuro = new RadioButton();
            radioButtonDolar = new RadioButton();
            buttonConversao = new Button();
            labelresultado = new Label();
            SuspendLayout();
            // 
            // labelReal
            // 
            labelReal.AutoSize = true;
            labelReal.BackColor = SystemColors.ActiveCaption;
            labelReal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelReal.Location = new Point(217, 124);
            labelReal.Name = "labelReal";
            labelReal.Size = new Size(218, 21);
            labelReal.TabIndex = 0;
            labelReal.Text = "Digite o valor a converter (R$)";
            labelReal.Click += labelReal_Click;
            // 
            // textBoxReal
            // 
            textBoxReal.Location = new Point(441, 126);
            textBoxReal.Name = "textBoxReal";
            textBoxReal.Size = new Size(48, 23);
            textBoxReal.TabIndex = 1;
            textBoxReal.TextChanged += textBoxReal_TextChanged;
            // 
            // radioButtonEuro
            // 
            radioButtonEuro.AutoSize = true;
            radioButtonEuro.Location = new Point(217, 175);
            radioButtonEuro.Name = "radioButtonEuro";
            radioButtonEuro.Size = new Size(72, 19);
            radioButtonEuro.TabIndex = 2;
            radioButtonEuro.TabStop = true;
            radioButtonEuro.Text = "Euro (E$)";
            radioButtonEuro.UseVisualStyleBackColor = true;
            radioButtonEuro.CheckedChanged += radioButtonEuro_CheckedChanged;
            // 
            // radioButtonDolar
            // 
            radioButtonDolar.AutoSize = true;
            radioButtonDolar.Location = new Point(411, 175);
            radioButtonDolar.Name = "radioButtonDolar";
            radioButtonDolar.Size = new Size(78, 19);
            radioButtonDolar.TabIndex = 3;
            radioButtonDolar.TabStop = true;
            radioButtonDolar.Text = "Dolar (U$)";
            radioButtonDolar.UseVisualStyleBackColor = true;
            // 
            // buttonConversao
            // 
            buttonConversao.Location = new Point(315, 214);
            buttonConversao.Name = "buttonConversao";
            buttonConversao.Size = new Size(75, 23);
            buttonConversao.TabIndex = 4;
            buttonConversao.Text = "Converter";
            buttonConversao.UseVisualStyleBackColor = true;
            buttonConversao.Click += button1_Click;
            // 
            // labelresultado
            // 
            labelresultado.AutoSize = true;
            labelresultado.Location = new Point(254, 243);
            labelresultado.Name = "labelresultado";
            labelresultado.Size = new Size(0, 15);
            labelresultado.TabIndex = 5;
            labelresultado.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 454);
            Controls.Add(labelresultado);
            Controls.Add(buttonConversao);
            Controls.Add(radioButtonDolar);
            Controls.Add(radioButtonEuro);
            Controls.Add(textBoxReal);
            Controls.Add(labelReal);
            Name = "Form1";
            Text = "AtividadesLogicas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelReal;
        private TextBox textBoxReal;
        private RadioButton radioButtonEuro;
        private RadioButton radioButtonDolar;
        private Button buttonConversao;
        private Label labelresultado;
    }
}
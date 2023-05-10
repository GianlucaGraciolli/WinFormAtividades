namespace PrjWinFormAtividadesLogicaCalculadoraSimples
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
            labelNumero1 = new Label();
            labelNumero2 = new Label();
            textBoxNumero1 = new TextBox();
            textBoxNumero2 = new TextBox();
            radioBtAdicao = new RadioButton();
            radioBtSub = new RadioButton();
            radioBtMulti = new RadioButton();
            radioBtDiv = new RadioButton();
            buttonCalcular = new Button();
            labelResultado = new Label();
            textBoxResultado = new TextBox();
            SuspendLayout();
            // 
            // labelNumero1
            // 
            labelNumero1.AutoSize = true;
            labelNumero1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumero1.Location = new Point(212, 65);
            labelNumero1.Name = "labelNumero1";
            labelNumero1.Size = new Size(158, 23);
            labelNumero1.TabIndex = 0;
            labelNumero1.Text = "Primeiro Numero";
            // 
            // labelNumero2
            // 
            labelNumero2.AutoSize = true;
            labelNumero2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumero2.Location = new Point(212, 110);
            labelNumero2.Name = "labelNumero2";
            labelNumero2.Size = new Size(156, 23);
            labelNumero2.TabIndex = 1;
            labelNumero2.Text = "Segundo Numero";
            labelNumero2.Click += label2_Click;
            // 
            // textBoxNumero1
            // 
            textBoxNumero1.Location = new Point(374, 68);
            textBoxNumero1.Name = "textBoxNumero1";
            textBoxNumero1.Size = new Size(100, 23);
            textBoxNumero1.TabIndex = 2;
            // 
            // textBoxNumero2
            // 
            textBoxNumero2.Location = new Point(374, 110);
            textBoxNumero2.Name = "textBoxNumero2";
            textBoxNumero2.Size = new Size(100, 23);
            textBoxNumero2.TabIndex = 3;
            // 
            // radioBtAdicao
            // 
            radioBtAdicao.AutoSize = true;
            radioBtAdicao.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtAdicao.Location = new Point(212, 166);
            radioBtAdicao.Name = "radioBtAdicao";
            radioBtAdicao.Size = new Size(40, 27);
            radioBtAdicao.TabIndex = 4;
            radioBtAdicao.TabStop = true;
            radioBtAdicao.Text = "+";
            radioBtAdicao.UseVisualStyleBackColor = true;
            // 
            // radioBtSub
            // 
            radioBtSub.AutoSize = true;
            radioBtSub.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtSub.Location = new Point(284, 166);
            radioBtSub.Name = "radioBtSub";
            radioBtSub.Size = new Size(35, 27);
            radioBtSub.TabIndex = 5;
            radioBtSub.TabStop = true;
            radioBtSub.Text = "-";
            radioBtSub.UseVisualStyleBackColor = true;
            // 
            // radioBtMulti
            // 
            radioBtMulti.AutoSize = true;
            radioBtMulti.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtMulti.Location = new Point(360, 166);
            radioBtMulti.Name = "radioBtMulti";
            radioBtMulti.Size = new Size(38, 27);
            radioBtMulti.TabIndex = 6;
            radioBtMulti.TabStop = true;
            radioBtMulti.Text = "x";
            radioBtMulti.UseVisualStyleBackColor = true;
            // 
            // radioBtDiv
            // 
            radioBtDiv.AutoSize = true;
            radioBtDiv.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtDiv.Location = new Point(434, 166);
            radioBtDiv.Name = "radioBtDiv";
            radioBtDiv.Size = new Size(34, 27);
            radioBtDiv.TabIndex = 7;
            radioBtDiv.TabStop = true;
            radioBtDiv.Text = "/";
            radioBtDiv.UseVisualStyleBackColor = true;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(295, 219);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 8;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelResultado.Location = new Point(144, 293);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(94, 23);
            labelResultado.TabIndex = 9;
            labelResultado.Text = "Resultado";
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(295, 293);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(107, 23);
            textBoxResultado.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 378);
            Controls.Add(textBoxResultado);
            Controls.Add(labelResultado);
            Controls.Add(buttonCalcular);
            Controls.Add(radioBtDiv);
            Controls.Add(radioBtMulti);
            Controls.Add(radioBtSub);
            Controls.Add(radioBtAdicao);
            Controls.Add(textBoxNumero2);
            Controls.Add(textBoxNumero1);
            Controls.Add(labelNumero2);
            Controls.Add(labelNumero1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumero1;
        private Label labelNumero2;
        private TextBox textBoxNumero1;
        private TextBox textBoxNumero2;
        private RadioButton radioBtAdicao;
        private RadioButton radioBtSub;
        private RadioButton radioBtMulti;
        private RadioButton radioBtDiv;
        private Button buttonCalcular;
        private Label labelResultado;
        private TextBox textBoxResultado;
    }
}
namespace PrjAtividadeSalario
{
    partial class FormSalario
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
            labelSalBruto = new Label();
            txtBoxSalBruto = new TextBox();
            checkBoxTransporte = new CheckBox();
            checkBoxConvenio = new CheckBox();
            buttoncalculo = new Button();
            label1 = new Label();
            txtBoxSalLiq = new TextBox();
            SuspendLayout();
            // 
            // labelSalBruto
            // 
            labelSalBruto.AutoSize = true;
            labelSalBruto.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelSalBruto.Location = new Point(96, 68);
            labelSalBruto.Name = "labelSalBruto";
            labelSalBruto.Size = new Size(236, 23);
            labelSalBruto.TabIndex = 0;
            labelSalBruto.Text = "Digite o Salário Bruto (R$)";
            // 
            // txtBoxSalBruto
            // 
            txtBoxSalBruto.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSalBruto.Location = new Point(338, 68);
            txtBoxSalBruto.Name = "txtBoxSalBruto";
            txtBoxSalBruto.Size = new Size(219, 28);
            txtBoxSalBruto.TabIndex = 1;
            // 
            // checkBoxTransporte
            // 
            checkBoxTransporte.AutoSize = true;
            checkBoxTransporte.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTransporte.Location = new Point(125, 166);
            checkBoxTransporte.Name = "checkBoxTransporte";
            checkBoxTransporte.Size = new Size(184, 22);
            checkBoxTransporte.TabIndex = 2;
            checkBoxTransporte.Text = "Recebo Vale Transporte";
            checkBoxTransporte.UseVisualStyleBackColor = true;
            // 
            // checkBoxConvenio
            // 
            checkBoxConvenio.AutoSize = true;
            checkBoxConvenio.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxConvenio.Location = new Point(361, 166);
            checkBoxConvenio.Name = "checkBoxConvenio";
            checkBoxConvenio.Size = new Size(188, 22);
            checkBoxConvenio.TabIndex = 3;
            checkBoxConvenio.Text = "Recebo Convênio Médico";
            checkBoxConvenio.UseVisualStyleBackColor = true;
            // 
            // buttoncalculo
            // 
            buttoncalculo.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttoncalculo.Location = new Point(287, 225);
            buttoncalculo.Name = "buttoncalculo";
            buttoncalculo.Size = new Size(86, 29);
            buttoncalculo.TabIndex = 4;
            buttoncalculo.Text = "Calcular";
            buttoncalculo.UseVisualStyleBackColor = true;
            buttoncalculo.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(106, 343);
            label1.Name = "label1";
            label1.Size = new Size(182, 23);
            label1.TabIndex = 5;
            label1.Text = "Salário Líquido (R$)";
            // 
            // txtBoxSalLiq
            // 
            txtBoxSalLiq.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSalLiq.Location = new Point(294, 343);
            txtBoxSalLiq.Name = "txtBoxSalLiq";
            txtBoxSalLiq.Size = new Size(219, 28);
            txtBoxSalLiq.TabIndex = 6;
            // 
            // FormSalario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(662, 450);
            Controls.Add(txtBoxSalLiq);
            Controls.Add(label1);
            Controls.Add(buttoncalculo);
            Controls.Add(checkBoxConvenio);
            Controls.Add(checkBoxTransporte);
            Controls.Add(txtBoxSalBruto);
            Controls.Add(labelSalBruto);
            Name = "FormSalario";
            Text = "Calcular Salário Líquido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSalBruto;
        private TextBox txtBoxSalBruto;
        private CheckBox checkBoxTransporte;
        private CheckBox checkBoxConvenio;
        private Button buttoncalculo;
        private Label label1;
        private TextBox txtBoxSalLiq;
    }
}
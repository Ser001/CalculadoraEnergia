
namespace CalculadoraEnergia
{
    partial class CalculadoraKhw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraKhw));
            this.txtLeituraAnterior = new System.Windows.Forms.TextBox();
            this.txtLeituraAtual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxValorKWH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLeituraAnterior
            // 
            this.txtLeituraAnterior.Location = new System.Drawing.Point(142, 60);
            this.txtLeituraAnterior.Name = "txtLeituraAnterior";
            this.txtLeituraAnterior.Size = new System.Drawing.Size(154, 23);
            this.txtLeituraAnterior.TabIndex = 0;
            // 
            // txtLeituraAtual
            // 
            this.txtLeituraAtual.Location = new System.Drawing.Point(142, 109);
            this.txtLeituraAtual.Name = "txtLeituraAtual";
            this.txtLeituraAtual.Size = new System.Drawing.Size(154, 23);
            this.txtLeituraAtual.TabIndex = 1;
            this.txtLeituraAtual.TextChanged += new System.EventHandler(this.txtLeituraAtual_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kwh - Anterior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kwh - Recente";
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxResultado.Location = new System.Drawing.Point(142, 190);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(154, 35);
            this.textBoxResultado.TabIndex = 4;
            this.textBoxResultado.TextChanged += new System.EventHandler(this.textBoxResultado_TextChanged);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Resultado.Location = new System.Drawing.Point(31, 197);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(94, 25);
            this.Resultado.TabIndex = 5;
            this.Resultado.Text = "Resultado";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(12, 231);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(326, 32);
            this.buttonCalcular.TabIndex = 6;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(12, 269);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(326, 32);
            this.buttonLimpar.TabIndex = 7;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor Kwh";
            // 
            // textBoxValorKWH
            // 
            this.textBoxValorKWH.Location = new System.Drawing.Point(142, 155);
            this.textBoxValorKWH.Name = "textBoxValorKWH";
            this.textBoxValorKWH.Size = new System.Drawing.Size(51, 23);
            this.textBoxValorKWH.TabIndex = 9;
            this.textBoxValorKWH.TextChanged += new System.EventHandler(this.textBoxValorKWH_TextChanged);
            // 
            // CalculadoraKhw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 326);
            this.Controls.Add(this.textBoxValorKWH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLeituraAtual);
            this.Controls.Add(this.txtLeituraAnterior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculadoraKhw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Energia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLeituraAnterior;
        private System.Windows.Forms.TextBox txtLeituraAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxValorKWH;
    }
}


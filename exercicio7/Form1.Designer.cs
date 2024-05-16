namespace exercicio7
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.radioButtonAdicao = new System.Windows.Forms.RadioButton();
            this.radioButtonSubtracao = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiplicacao = new System.Windows.Forms.RadioButton();
            this.radioButtonDivisao = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(229, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCalcular.Location = new System.Drawing.Point(87, 275);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(262, 43);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.BackColor = System.Drawing.Color.Transparent;
            this.labelResultado.Location = new System.Drawing.Point(191, 232);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 13);
            this.labelResultado.TabIndex = 17;
            // 
            // radioButtonAdicao
            // 
            this.radioButtonAdicao.AutoSize = true;
            this.radioButtonAdicao.Location = new System.Drawing.Point(87, 135);
            this.radioButtonAdicao.Name = "radioButtonAdicao";
            this.radioButtonAdicao.Size = new System.Drawing.Size(31, 17);
            this.radioButtonAdicao.TabIndex = 18;
            this.radioButtonAdicao.TabStop = true;
            this.radioButtonAdicao.Text = "+";
            this.radioButtonAdicao.UseVisualStyleBackColor = true;
            this.radioButtonAdicao.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonSubtracao
            // 
            this.radioButtonSubtracao.AutoSize = true;
            this.radioButtonSubtracao.Location = new System.Drawing.Point(163, 135);
            this.radioButtonSubtracao.Name = "radioButtonSubtracao";
            this.radioButtonSubtracao.Size = new System.Drawing.Size(28, 17);
            this.radioButtonSubtracao.TabIndex = 19;
            this.radioButtonSubtracao.TabStop = true;
            this.radioButtonSubtracao.Text = "-";
            this.radioButtonSubtracao.UseVisualStyleBackColor = true;
            // 
            // radioButtonMultiplicacao
            // 
            this.radioButtonMultiplicacao.AutoEllipsis = true;
            this.radioButtonMultiplicacao.AutoSize = true;
            this.radioButtonMultiplicacao.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButtonMultiplicacao.Location = new System.Drawing.Point(241, 134);
            this.radioButtonMultiplicacao.Name = "radioButtonMultiplicacao";
            this.radioButtonMultiplicacao.Size = new System.Drawing.Size(30, 17);
            this.radioButtonMultiplicacao.TabIndex = 20;
            this.radioButtonMultiplicacao.TabStop = true;
            this.radioButtonMultiplicacao.Text = "x";
            this.radioButtonMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivisao
            // 
            this.radioButtonDivisao.AutoSize = true;
            this.radioButtonDivisao.Location = new System.Drawing.Point(325, 134);
            this.radioButtonDivisao.Name = "radioButtonDivisao";
            this.radioButtonDivisao.Size = new System.Drawing.Size(30, 17);
            this.radioButtonDivisao.TabIndex = 21;
            this.radioButtonDivisao.TabStop = true;
            this.radioButtonDivisao.Text = "/";
            this.radioButtonDivisao.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 349);
            this.Controls.Add(this.radioButtonDivisao);
            this.Controls.Add(this.radioButtonMultiplicacao);
            this.Controls.Add(this.radioButtonSubtracao);
            this.Controls.Add(this.radioButtonAdicao);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.RadioButton radioButtonAdicao;
        private System.Windows.Forms.RadioButton radioButtonSubtracao;
        private System.Windows.Forms.RadioButton radioButtonMultiplicacao;
        private System.Windows.Forms.RadioButton radioButtonDivisao;
    }
}


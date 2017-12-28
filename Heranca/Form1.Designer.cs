namespace Casa.Financas.Visual
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDeposito = new System.Windows.Forms.Button();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.comboSaldo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboNumero = new System.Windows.Forms.ComboBox();
            this.buttonSaque = new System.Windows.Forms.Button();
            this.textValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDeposito
            // 
            this.buttonDeposito.Location = new System.Drawing.Point(58, 117);
            this.buttonDeposito.Name = "buttonDeposito";
            this.buttonDeposito.Size = new System.Drawing.Size(75, 23);
            this.buttonDeposito.TabIndex = 0;
            this.buttonDeposito.Text = "Deposito";
            this.buttonDeposito.UseVisualStyleBackColor = true;
            this.buttonDeposito.Click += new System.EventHandler(this.buttonDeposito_Click);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(58, 14);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(214, 21);
            this.comboContas.TabIndex = 1;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // comboSaldo
            // 
            this.comboSaldo.FormattingEnabled = true;
            this.comboSaldo.Location = new System.Drawing.Point(58, 50);
            this.comboSaldo.Name = "comboSaldo";
            this.comboSaldo.Size = new System.Drawing.Size(212, 21);
            this.comboSaldo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saldo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero";
            // 
            // comboNumero
            // 
            this.comboNumero.FormattingEnabled = true;
            this.comboNumero.Location = new System.Drawing.Point(58, 84);
            this.comboNumero.Name = "comboNumero";
            this.comboNumero.Size = new System.Drawing.Size(212, 21);
            this.comboNumero.TabIndex = 6;
            // 
            // buttonSaque
            // 
            this.buttonSaque.Location = new System.Drawing.Point(160, 116);
            this.buttonSaque.Name = "buttonSaque";
            this.buttonSaque.Size = new System.Drawing.Size(75, 23);
            this.buttonSaque.TabIndex = 7;
            this.buttonSaque.Text = "Saque";
            this.buttonSaque.UseVisualStyleBackColor = true;
            this.buttonSaque.Click += new System.EventHandler(this.buttonSaque_Click);
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(58, 164);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(177, 20);
            this.textValor.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboDestino);
            this.groupBox1.Location = new System.Drawing.Point(19, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transferencia";
            // 
            // comboDestino
            // 
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Location = new System.Drawing.Point(39, 31);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(177, 21);
            this.comboDestino.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Titular:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Transferir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonTransferencia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.buttonSaque);
            this.Controls.Add(this.comboNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSaldo);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.buttonDeposito);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeposito;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.ComboBox comboSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboNumero;
        private System.Windows.Forms.Button buttonSaque;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.Button button1;
    }
}


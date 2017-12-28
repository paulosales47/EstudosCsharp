namespace Casa.Financas.Visual
{
    partial class FormularioDeCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textNumeroContaCadastro = new System.Windows.Forms.TextBox();
            this.textNomeTitularCadastro = new System.Windows.Forms.TextBox();
            this.textSaldoInicialCadastro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTipoConta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero da conta: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do titular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo Inicial:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCadastroCliente_Click);
            // 
            // textNumeroContaCadastro
            // 
            this.textNumeroContaCadastro.Location = new System.Drawing.Point(160, 55);
            this.textNumeroContaCadastro.Name = "textNumeroContaCadastro";
            this.textNumeroContaCadastro.Size = new System.Drawing.Size(196, 20);
            this.textNumeroContaCadastro.TabIndex = 4;
            // 
            // textNomeTitularCadastro
            // 
            this.textNomeTitularCadastro.Location = new System.Drawing.Point(160, 86);
            this.textNomeTitularCadastro.Name = "textNomeTitularCadastro";
            this.textNomeTitularCadastro.Size = new System.Drawing.Size(196, 20);
            this.textNomeTitularCadastro.TabIndex = 5;
            // 
            // textSaldoInicialCadastro
            // 
            this.textSaldoInicialCadastro.Location = new System.Drawing.Point(160, 117);
            this.textSaldoInicialCadastro.Name = "textSaldoInicialCadastro";
            this.textSaldoInicialCadastro.Size = new System.Drawing.Size(196, 20);
            this.textSaldoInicialCadastro.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de conta:";
            // 
            // comboTipoConta
            // 
            this.comboTipoConta.FormattingEnabled = true;
            this.comboTipoConta.Location = new System.Drawing.Point(160, 28);
            this.comboTipoConta.Name = "comboTipoConta";
            this.comboTipoConta.Size = new System.Drawing.Size(196, 21);
            this.comboTipoConta.TabIndex = 8;
            // 
            // FormularioDeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 252);
            this.Controls.Add(this.comboTipoConta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSaldoInicialCadastro);
            this.Controls.Add(this.textNomeTitularCadastro);
            this.Controls.Add(this.textNumeroContaCadastro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioDeCadastro";
            this.Text = "FormularioDeCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textNumeroContaCadastro;
        private System.Windows.Forms.TextBox textNomeTitularCadastro;
        private System.Windows.Forms.TextBox textSaldoInicialCadastro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTipoConta;
    }
}
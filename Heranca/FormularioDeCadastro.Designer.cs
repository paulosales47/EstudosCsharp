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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero da conta: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do titular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo Inicial:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCadastroCliente_Click);
            // 
            // textNumeroContaCadastro
            // 
            this.textNumeroContaCadastro.Location = new System.Drawing.Point(160, 22);
            this.textNumeroContaCadastro.Name = "textNumeroContaCadastro";
            this.textNumeroContaCadastro.Size = new System.Drawing.Size(196, 20);
            this.textNumeroContaCadastro.TabIndex = 4;
            // 
            // textNomeTitularCadastro
            // 
            this.textNomeTitularCadastro.Location = new System.Drawing.Point(160, 53);
            this.textNomeTitularCadastro.Name = "textNomeTitularCadastro";
            this.textNomeTitularCadastro.Size = new System.Drawing.Size(196, 20);
            this.textNomeTitularCadastro.TabIndex = 5;
            // 
            // textSaldoInicialCadastro
            // 
            this.textSaldoInicialCadastro.Location = new System.Drawing.Point(160, 84);
            this.textSaldoInicialCadastro.Name = "textSaldoInicialCadastro";
            this.textSaldoInicialCadastro.Size = new System.Drawing.Size(196, 20);
            this.textSaldoInicialCadastro.TabIndex = 6;
            // 
            // FormularioDeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 179);
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
    }
}
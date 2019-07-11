namespace ProjetoVet
{
    partial class ConsultaServicoContas
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
            this.rbtVista = new System.Windows.Forms.RadioButton();
            this.rbtPrazo = new System.Windows.Forms.RadioButton();
            this.rbtOutros = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numParcelas = new System.Windows.Forms.NumericUpDown();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Pagamento:";
            // 
            // rbtVista
            // 
            this.rbtVista.AutoSize = true;
            this.rbtVista.Location = new System.Drawing.Point(163, 11);
            this.rbtVista.Name = "rbtVista";
            this.rbtVista.Size = new System.Drawing.Size(58, 17);
            this.rbtVista.TabIndex = 1;
            this.rbtVista.TabStop = true;
            this.rbtVista.Text = "Á Vista";
            this.rbtVista.UseVisualStyleBackColor = true;
            // 
            // rbtPrazo
            // 
            this.rbtPrazo.AutoSize = true;
            this.rbtPrazo.Location = new System.Drawing.Point(163, 34);
            this.rbtPrazo.Name = "rbtPrazo";
            this.rbtPrazo.Size = new System.Drawing.Size(73, 17);
            this.rbtPrazo.TabIndex = 2;
            this.rbtPrazo.TabStop = true;
            this.rbtPrazo.Text = "Parcelado";
            this.rbtPrazo.UseVisualStyleBackColor = true;
            // 
            // rbtOutros
            // 
            this.rbtOutros.AutoSize = true;
            this.rbtOutros.Location = new System.Drawing.Point(163, 57);
            this.rbtOutros.Name = "rbtOutros";
            this.rbtOutros.Size = new System.Drawing.Size(56, 17);
            this.rbtOutros.TabIndex = 3;
            this.rbtOutros.TabStop = true;
            this.rbtOutros.Text = "Outros";
            this.rbtOutros.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbtOutros);
            this.panel1.Controls.Add(this.rbtVista);
            this.panel1.Controls.Add(this.rbtPrazo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 92);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numParcelas);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(281, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 92);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantidade de Parcelas:";
            // 
            // numParcelas
            // 
            this.numParcelas.Location = new System.Drawing.Point(7, 34);
            this.numParcelas.Name = "numParcelas";
            this.numParcelas.Size = new System.Drawing.Size(120, 20);
            this.numParcelas.TabIndex = 1;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(12, 133);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(105, 23);
            this.btnGerar.TabIndex = 6;
            this.btnGerar.Text = "Gerar Títulos";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(129, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ConsultaServicoContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 166);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ConsultaServicoContas";
            this.Text = "Pagamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtVista;
        private System.Windows.Forms.RadioButton rbtPrazo;
        private System.Windows.Forms.RadioButton rbtOutros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numParcelas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
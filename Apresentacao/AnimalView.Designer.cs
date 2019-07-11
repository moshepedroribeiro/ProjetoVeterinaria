namespace ProjetoVet
{
    partial class AnimalView
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtProprietario = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgvAnimal = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDProp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipoAnimal = new System.Windows.Forms.ComboBox();
            this.numIdade = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPront = new System.Windows.Forms.Button();
            this.btnBuscarProp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Animal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Proprietario:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(61, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(298, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(105, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(254, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtProprietario
            // 
            this.txtProprietario.Enabled = false;
            this.txtProprietario.Location = new System.Drawing.Point(81, 72);
            this.txtProprietario.Name = "txtProprietario";
            this.txtProprietario.Size = new System.Drawing.Size(278, 20);
            this.txtProprietario.TabIndex = 9;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(403, 6);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(90, 23);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(403, 41);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(90, 23);
            this.btnDeletar.TabIndex = 13;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(403, 102);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // dgvAnimal
            // 
            this.dgvAnimal.AllowUserToOrderColumns = true;
            this.dgvAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimal.Location = new System.Drawing.Point(15, 291);
            this.dgvAnimal.Name = "dgvAnimal";
            this.dgvAnimal.Size = new System.Drawing.Size(478, 150);
            this.dgvAnimal.TabIndex = 15;
            this.dgvAnimal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAnimal_CellClick);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(15, 255);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(344, 20);
            this.txtPesquisar.TabIndex = 16;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(383, 255);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(110, 23);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Código Proprietario:";
            // 
            // txtIDProp
            // 
            this.txtIDProp.Enabled = false;
            this.txtIDProp.Location = new System.Drawing.Point(117, 105);
            this.txtIDProp.Name = "txtIDProp";
            this.txtIDProp.Size = new System.Drawing.Size(100, 20);
            this.txtIDProp.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Animal:";
            // 
            // cbxTipoAnimal
            // 
            this.cbxTipoAnimal.FormattingEnabled = true;
            this.cbxTipoAnimal.Location = new System.Drawing.Point(99, 176);
            this.cbxTipoAnimal.Name = "cbxTipoAnimal";
            this.cbxTipoAnimal.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoAnimal.TabIndex = 8;
            // 
            // numIdade
            // 
            this.numIdade.Location = new System.Drawing.Point(155, 141);
            this.numIdade.Name = "numIdade";
            this.numIdade.Size = new System.Drawing.Size(120, 20);
            this.numIdade.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idade do Animal (em Anos):";
            // 
            // btnPront
            // 
            this.btnPront.Location = new System.Drawing.Point(252, 176);
            this.btnPront.Name = "btnPront";
            this.btnPront.Size = new System.Drawing.Size(107, 41);
            this.btnPront.TabIndex = 11;
            this.btnPront.Text = "Buscar Prontuário";
            this.btnPront.UseVisualStyleBackColor = true;
            this.btnPront.Click += new System.EventHandler(this.BtnPront_Click);
            // 
            // btnBuscarProp
            // 
            this.btnBuscarProp.Location = new System.Drawing.Point(235, 102);
            this.btnBuscarProp.Name = "btnBuscarProp";
            this.btnBuscarProp.Size = new System.Drawing.Size(124, 23);
            this.btnBuscarProp.TabIndex = 10;
            this.btnBuscarProp.Text = "Buscar Proprietario";
            this.btnBuscarProp.UseVisualStyleBackColor = true;
            this.btnBuscarProp.Click += new System.EventHandler(this.BtnBuscarProp_Click);
            // 
            // AnimalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 453);
            this.Controls.Add(this.txtIDProp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dgvAnimal);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPront);
            this.Controls.Add(this.btnBuscarProp);
            this.Controls.Add(this.txtProprietario);
            this.Controls.Add(this.cbxTipoAnimal);
            this.Controls.Add(this.numIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnimalView";
            this.Text = "Manutenção de Animais";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtProprietario;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgvAnimal;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtIDProp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTipoAnimal;
        private System.Windows.Forms.NumericUpDown numIdade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPront;
        private System.Windows.Forms.Button btnBuscarProp;
    }
}
namespace ProjetoVet
{
    partial class AnimalProntuarioView
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvProntuario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPesquisar = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataProntuario = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTratamento = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExames = new System.Windows.Forms.Button();
            this.btnPesquisarHoje = new System.Windows.Forms.Button();
            this.btnExamesAnimal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProntuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(336, 179);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(92, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // dgvProntuario
            // 
            this.dgvProntuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProntuario.Location = new System.Drawing.Point(15, 222);
            this.dgvProntuario.Name = "dgvProntuario";
            this.dgvProntuario.Size = new System.Drawing.Size(534, 138);
            this.dgvProntuario.TabIndex = 2;
            this.dgvProntuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProntuario_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Busca por Data:";
            // 
            // dtpPesquisar
            // 
            this.dtpPesquisar.Location = new System.Drawing.Point(102, 182);
            this.dtpPesquisar.Name = "dtpPesquisar";
            this.dtpPesquisar.Size = new System.Drawing.Size(228, 20);
            this.dtpPesquisar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(61, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(63, 20);
            this.txtID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data Prontuário:";
            // 
            // dtpDataProntuario
            // 
            this.dtpDataProntuario.Location = new System.Drawing.Point(220, 9);
            this.dtpDataProntuario.Name = "dtpDataProntuario";
            this.dtpDataProntuario.Size = new System.Drawing.Size(211, 20);
            this.dtpDataProntuario.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Diagnóstico ou Descrição:";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(150, 43);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(281, 20);
            this.txtDiagnostico.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tratamento:";
            // 
            // txtTratamento
            // 
            this.txtTratamento.Location = new System.Drawing.Point(82, 72);
            this.txtTratamento.Name = "txtTratamento";
            this.txtTratamento.Size = new System.Drawing.Size(349, 20);
            this.txtTratamento.TabIndex = 15;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(455, 6);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(91, 23);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(455, 38);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(91, 23);
            this.btnDeletar.TabIndex = 17;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(455, 99);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(91, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Buscar Exame:";
            // 
            // btnExames
            // 
            this.btnExames.Location = new System.Drawing.Point(96, 111);
            this.btnExames.Name = "btnExames";
            this.btnExames.Size = new System.Drawing.Size(103, 32);
            this.btnExames.TabIndex = 20;
            this.btnExames.Text = "Adicionar Exame";
            this.btnExames.UseVisualStyleBackColor = true;
            this.btnExames.Click += new System.EventHandler(this.BtnExames_Click);
            // 
            // btnPesquisarHoje
            // 
            this.btnPesquisarHoje.Location = new System.Drawing.Point(437, 179);
            this.btnPesquisarHoje.Name = "btnPesquisarHoje";
            this.btnPesquisarHoje.Size = new System.Drawing.Size(109, 23);
            this.btnPesquisarHoje.TabIndex = 21;
            this.btnPesquisarHoje.Text = "Pesquisar por Hoje";
            this.btnPesquisarHoje.UseVisualStyleBackColor = true;
            this.btnPesquisarHoje.Click += new System.EventHandler(this.BtnPesquisarHoje_Click);
            // 
            // btnExamesAnimal
            // 
            this.btnExamesAnimal.Location = new System.Drawing.Point(368, 116);
            this.btnExamesAnimal.Name = "btnExamesAnimal";
            this.btnExamesAnimal.Size = new System.Drawing.Size(29, 23);
            this.btnExamesAnimal.TabIndex = 22;
            this.btnExamesAnimal.Text = "...";
            this.btnExamesAnimal.UseVisualStyleBackColor = true;
            this.btnExamesAnimal.Click += new System.EventHandler(this.BtnExamesAnimal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Pesquisar Exames do Animal:";
            // 
            // AnimalProntuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExamesAnimal);
            this.Controls.Add(this.btnPesquisarHoje);
            this.Controls.Add(this.btnExames);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtTratamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDataProntuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProntuario);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "AnimalProntuarioView";
            this.Text = "Manutenção de Prontuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProntuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvProntuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataProntuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTratamento;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExames;
        private System.Windows.Forms.Button btnPesquisarHoje;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnExamesAnimal;
        private System.Windows.Forms.Label label3;
    }
}
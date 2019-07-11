namespace ProjetoVet
{
    partial class ServicoView
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDataFechamento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvServicos = new System.Windows.Forms.DataGridView();
            this.dtpPesquisar = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDAnimal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHorario = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipoServico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.MistyRose;
            this.btnFechar.Location = new System.Drawing.Point(162, 156);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(154, 34);
            this.btnFechar.TabIndex = 58;
            this.btnFechar.Text = "Finalizar Servico";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(61, 76);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Status:";
            // 
            // numValor
            // 
            this.numValor.DecimalPlaces = 2;
            this.numValor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numValor.Location = new System.Drawing.Point(52, 113);
            this.numValor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(120, 20);
            this.numValor.TabIndex = 55;
            this.numValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Valor:";
            // 
            // txtDataFechamento
            // 
            this.txtDataFechamento.Enabled = false;
            this.txtDataFechamento.Location = new System.Drawing.Point(322, 80);
            this.txtDataFechamento.Name = "txtDataFechamento";
            this.txtDataFechamento.Size = new System.Drawing.Size(117, 20);
            this.txtDataFechamento.TabIndex = 53;
            this.txtDataFechamento.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(206, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Data de Fechamento:";
            // 
            // dgvServicos
            // 
            this.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicos.Location = new System.Drawing.Point(15, 243);
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.Size = new System.Drawing.Size(552, 146);
            this.dgvServicos.TabIndex = 51;
            this.dgvServicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvServicos_CellClick);
            // 
            // dtpPesquisar
            // 
            this.dtpPesquisar.Location = new System.Drawing.Point(136, 208);
            this.dtpPesquisar.Name = "dtpPesquisar";
            this.dtpPesquisar.Size = new System.Drawing.Size(246, 20);
            this.dtpPesquisar.TabIndex = 50;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(399, 205);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(120, 23);
            this.btnPesquisar.TabIndex = 49;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(480, 98);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 23);
            this.btnLimpar.TabIndex = 48;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(480, 48);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(87, 23);
            this.btnDeletar.TabIndex = 47;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(480, 3);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(87, 23);
            this.btnGravar.TabIndex = 46;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Data (Ex: 05/07/1999):";
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Location = new System.Drawing.Point(388, 43);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(51, 23);
            this.btnBuscarAnimal.TabIndex = 44;
            this.btnBuscarAnimal.Text = "Buscar";
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.BtnBuscarAnimal_Click);
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Enabled = false;
            this.txtNomeAnimal.Location = new System.Drawing.Point(252, 45);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(130, 20);
            this.txtNomeAnimal.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nome do Animal:";
            // 
            // txtIDAnimal
            // 
            this.txtIDAnimal.Enabled = false;
            this.txtIDAnimal.Location = new System.Drawing.Point(114, 45);
            this.txtIDAnimal.Name = "txtIDAnimal";
            this.txtIDAnimal.Size = new System.Drawing.Size(39, 20);
            this.txtIDAnimal.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Codigo do Animal:";
            // 
            // dtpHorario
            // 
            this.dtpHorario.Location = new System.Drawing.Point(209, 6);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.Size = new System.Drawing.Size(230, 20);
            this.dtpHorario.TabIndex = 36;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(61, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(92, 20);
            this.txtID.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Horário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Codigo:";
            // 
            // cbxTipoServico
            // 
            this.cbxTipoServico.FormattingEnabled = true;
            this.cbxTipoServico.Location = new System.Drawing.Point(282, 112);
            this.cbxTipoServico.Name = "cbxTipoServico";
            this.cbxTipoServico.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoServico.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Tipo de Servico:";
            // 
            // ServicoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxTipoServico);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDataFechamento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvServicos);
            this.Controls.Add(this.dtpPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscarAnimal);
            this.Controls.Add(this.txtNomeAnimal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIDAnimal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpHorario);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ServicoView";
            this.Text = "Manutenção de Serviço";
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvServicos;
        private System.Windows.Forms.DateTimePicker dtpPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarAnimal;
        public System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtIDAnimal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown numValor;
        public System.Windows.Forms.TextBox txtStatus;
        public System.Windows.Forms.TextBox txtDataFechamento;
        public System.Windows.Forms.DateTimePicker dtpHorario;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.ComboBox cbxTipoServico;
    }
}
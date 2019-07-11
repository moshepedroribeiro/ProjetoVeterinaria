namespace ProjetoVet
{
    partial class ConsultaView
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpHorario = new System.Windows.Forms.DateTimePicker();
            this.txtIDAnimal = new System.Windows.Forms.TextBox();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDMedico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeMedico = new System.Windows.Forms.TextBox();
            this.btnBuscarMedico = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtpPesquisar = new System.Windows.Forms.DateTimePicker();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDataFechamento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código do Animal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome do Animal:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(61, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(92, 20);
            this.txtID.TabIndex = 5;
            // 
            // dtpHorario
            // 
            this.dtpHorario.Location = new System.Drawing.Point(209, 6);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.Size = new System.Drawing.Size(230, 20);
            this.dtpHorario.TabIndex = 6;
            // 
            // txtIDAnimal
            // 
            this.txtIDAnimal.Enabled = false;
            this.txtIDAnimal.Location = new System.Drawing.Point(110, 45);
            this.txtIDAnimal.Name = "txtIDAnimal";
            this.txtIDAnimal.Size = new System.Drawing.Size(43, 20);
            this.txtIDAnimal.TabIndex = 7;
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Enabled = false;
            this.txtNomeAnimal.Location = new System.Drawing.Point(252, 45);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(130, 20);
            this.txtNomeAnimal.TabIndex = 8;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Location = new System.Drawing.Point(388, 43);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(51, 23);
            this.btnBuscarAnimal.TabIndex = 9;
            this.btnBuscarAnimal.Text = "Buscar";
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.BtnBuscarAnimal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Codigo do Médico:";
            // 
            // txtIDMedico
            // 
            this.txtIDMedico.Enabled = false;
            this.txtIDMedico.Location = new System.Drawing.Point(114, 81);
            this.txtIDMedico.Name = "txtIDMedico";
            this.txtIDMedico.Size = new System.Drawing.Size(39, 20);
            this.txtIDMedico.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome do Médico:";
            // 
            // txtNomeMedico
            // 
            this.txtNomeMedico.Enabled = false;
            this.txtNomeMedico.Location = new System.Drawing.Point(252, 81);
            this.txtNomeMedico.Name = "txtNomeMedico";
            this.txtNomeMedico.Size = new System.Drawing.Size(130, 20);
            this.txtNomeMedico.TabIndex = 13;
            // 
            // btnBuscarMedico
            // 
            this.btnBuscarMedico.Location = new System.Drawing.Point(388, 79);
            this.btnBuscarMedico.Name = "btnBuscarMedico";
            this.btnBuscarMedico.Size = new System.Drawing.Size(51, 23);
            this.btnBuscarMedico.TabIndex = 14;
            this.btnBuscarMedico.Text = "Buscar";
            this.btnBuscarMedico.UseVisualStyleBackColor = true;
            this.btnBuscarMedico.Click += new System.EventHandler(this.BtnBuscarMedico_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Data (Ex: 05/07/1999):";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(480, 3);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(87, 23);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(480, 48);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(87, 23);
            this.btnDeletar.TabIndex = 17;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(480, 98);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(399, 210);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(120, 23);
            this.btnPesquisar.TabIndex = 19;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // dtpPesquisar
            // 
            this.dtpPesquisar.Location = new System.Drawing.Point(136, 213);
            this.dtpPesquisar.Name = "dtpPesquisar";
            this.dtpPesquisar.Size = new System.Drawing.Size(246, 20);
            this.dtpPesquisar.TabIndex = 20;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(15, 248);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(552, 146);
            this.dgvConsulta.TabIndex = 21;
            this.dgvConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsulta_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(206, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Data de Fechamento:";
            // 
            // txtDataFechamento
            // 
            this.txtDataFechamento.Enabled = false;
            this.txtDataFechamento.Location = new System.Drawing.Point(322, 116);
            this.txtDataFechamento.Name = "txtDataFechamento";
            this.txtDataFechamento.Size = new System.Drawing.Size(117, 20);
            this.txtDataFechamento.TabIndex = 25;
            this.txtDataFechamento.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Valor:";
            // 
            // numValor
            // 
            this.numValor.DecimalPlaces = 2;
            this.numValor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numValor.Location = new System.Drawing.Point(52, 149);
            this.numValor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(120, 20);
            this.numValor.TabIndex = 27;
            this.numValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(61, 112);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 29;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.MistyRose;
            this.btnFechar.Location = new System.Drawing.Point(388, 160);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(154, 34);
            this.btnFechar.TabIndex = 30;
            this.btnFechar.Text = "Finalizar Consulta";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // ConsultaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 418);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDataFechamento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.dtpPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscarMedico);
            this.Controls.Add(this.txtNomeMedico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIDMedico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarAnimal);
            this.Controls.Add(this.txtNomeAnimal);
            this.Controls.Add(this.txtIDAnimal);
            this.Controls.Add(this.dtpHorario);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaView";
            this.Text = "ConsultaView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarMedico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DateTimePicker dtpPesquisar;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtIDAnimal;
        public System.Windows.Forms.TextBox txtNomeAnimal;
        public System.Windows.Forms.TextBox txtIDMedico;
        public System.Windows.Forms.TextBox txtNomeMedico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.DateTimePicker dtpHorario;
        public System.Windows.Forms.TextBox txtDataFechamento;
        public System.Windows.Forms.NumericUpDown numValor;
        public System.Windows.Forms.TextBox txtStatus;
    }
}
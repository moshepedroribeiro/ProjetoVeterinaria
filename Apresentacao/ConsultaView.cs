using Modelo;
using Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVet
{
    public partial class ConsultaView : Form
    {
        ConsultaServico cs = new ConsultaServico();
        AnimalServico ans = new AnimalServico();
        public ConsultaView()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            var consulta = from c in cs.TodasConsultas()
                           select new
                           {
                             c.ConsultaID,
                             Horario = c.Horario.ToString("dd/MM/yyyy"),
                             c.Valor,
                             Animal = c.Animal.Nome,
                             Medico = c.Medico.Nome
                         };
            dgvConsulta.DataSource = consulta.ToList();
        }

        public void RefreshDataGridView(string horario)
        {
            var consulta = from c in cs.TodasConsultas(horario)
                           select new
                           {
                               c.ConsultaID,
                               Horario = c.Horario.ToString("dd/MM/yyyy"),
                               c.Valor,
                               Animal = c.Animal.Nome,
                               Medico = c.Medico.Nome
                           };
            dgvConsulta.DataSource = consulta.ToList();
        }

        public void RefreshDataGridViewStr(string horario)
        {
            var consulta = from c in cs.TodasConsultasData(horario)
                           select new
                           {
                               c.ConsultaID,
                               Horario = c.Horario.ToString("dd/MM/yyyy"),
                               c.Valor,
                               Animal = c.Animal.Nome,
                               Medico = c.Medico.Nome
                           };
            dgvConsulta.DataSource = consulta.ToList();
        }

        private void BtnBuscarAnimal_Click(object sender, EventArgs e)
        {
            BuscasConsultaView bcv = new BuscasConsultaView(this, 1);
            bcv.Show();
        }

        private void BtnBuscarMedico_Click(object sender, EventArgs e)
        {
            BuscasConsultaView bcv = new BuscasConsultaView(this, 2);
            bcv.Show();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text != "Fechada")
            {
                Consulta c = new Consulta();

                if (!String.IsNullOrEmpty(txtID.Text))
                {
                    c.ConsultaID = Convert.ToInt32(txtID.Text);
                }

                c.Horario = dtpHorario.Value;

                c.Valor = Convert.ToDouble(numValor.Value);
                c.AnimalID = Convert.ToInt32(txtIDAnimal.Text);
                c.MedicoID = Convert.ToInt32(txtIDMedico.Text);
                c.Status = "Aberta";
                c.DataFechamento = txtDataFechamento.Text;

                cs.Gravar(c);
            } else
            {
                MessageBox.Show("Não se pode alterar registros após o fechamento da Consulta", "Impossível Alterar");
            }
            
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtIDAnimal.Clear();
            txtIDMedico.Clear();
            txtNomeAnimal.Clear();
            txtNomeMedico.Clear();
            txtDataFechamento.Text = ".";
            dtpHorario.Value = DateTime.Now;
            txtStatus.Clear();
            numValor.Value = 0;
            dtpHorario.Enabled = true;
            numValor.Enabled = true;
            RefreshDataGridView();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }


        private void PopularControles(Consulta c)
        {
            txtID.Text = Convert.ToString(c.ConsultaID);
            txtIDAnimal.Text = Convert.ToString(c.AnimalID);
            txtIDMedico.Text = Convert.ToString(c.MedicoID);
            txtNomeAnimal.Text = c.Animal.Nome;
            txtNomeMedico.Text = c.Medico.Nome;
            txtStatus.Text = c.Status;
            numValor.Value = Convert.ToDecimal(c.Valor);
            dtpHorario.Value = c.Horario;
            txtDataFechamento.Text = c.DataFechamento;

            if(c.DataFechamento != ".")
            {
                dtpHorario.Enabled = false;
                numValor.Enabled = false;
            }
        }

        private int ObterIDConsultaSelecionada(int rowIndex)
        {
            return Convert.ToInt32(dgvConsulta.Rows[rowIndex].Cells[0].Value);
        }

        private void DgvConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControles(cs.ObterPorID(ObterIDConsultaSelecionada(e.RowIndex)));
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(dtpPesquisar.Value.ToString("dd/MM/yyyy")))
            {
                RefreshDataGridViewStr(dtpPesquisar.Value.ToString("dd/MM/yyyy"));
            } else
            {
                RefreshDataGridView();
            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione Algum Registro");
            }
            else if(txtDataFechamento.Text == "." && txtStatus.Text == "Aberta")
            {
                int id = Convert.ToInt32(txtID.Text);
                ConsultaServico ps = new ConsultaServico();
                /*if (.Count() == 0)
                {*/
                    cs.Remover(id);
                    LimparCampos();
                /*}
                else
                {
                    MessageBox.Show("Este Animal possui registros vinculados", "Impossível Excluir");
                }*/

            } else if(txtDataFechamento.Text != "." && txtStatus.Text != "Aberta")
            {
                MessageBox.Show("Não é possível excluir Consultas Finalizadas", "Impossível Excluir");
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Consulta c = new Consulta();

            if (!String.IsNullOrEmpty(txtID.Text))
            {
                c.ConsultaID = Convert.ToInt32(txtID.Text);
            }

            c.Horario = dtpHorario.Value;
            c.AnimalID = Convert.ToInt32(txtIDAnimal.Text);
            c.MedicoID = Convert.ToInt32(txtIDMedico.Text);
            c.Status = "Fechada";
            c.DataFechamento = DateTime.Now.ToString("dd/MM/yyyy");
            c.Valor = Convert.ToDouble(numValor.Value);
            cs.Gravar(c);
            //LimparCampos();
            ConsultaServicoContas csc = new ConsultaServicoContas(this);
            csc.Show();
        }
    }
}

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
    public partial class ServicoView : Form
    {
        ServicoServico ss = new ServicoServico();
        TipoServicoServico tss = new TipoServicoServico();
        public ServicoView()
        {
            InitializeComponent();
            PopularComboBox();
            RefreshDataGridView();
        }

        private void PopularComboBox()
        {
            var tipos = tss.TodosTiposServico().OrderBy(tp => tp.Descricao).ToList<TipoServico>();
            cbxTipoServico.DataSource = tipos;

            tipos.Insert(0, new TipoServico()
            {
                TipoServicoID = -1,
                Descricao = "Selecione um Tipo:"
            });

            cbxTipoServico.DisplayMember = "Descricao";
            cbxTipoServico.ValueMember = "TipoServicoID";
        }

        private void RefreshDataGridView()
        {
            var servicos = from s in ss.TodosServicos()
                           select new
                           {
                               s.ServicoID,
                               s.Valor,
                               s.DataFechamento,
                               Animal = s.Animal.Nome,
                               TipoServico = s.TipoServico.Descricao
                           };
            dgvServicos.DataSource = servicos.ToList();
        }

        private void RefreshDataGridView(string horario)
        {
            var servicos = from s in ss.TodosServicos(horario)
                           select new
                           {
                               s.ServicoID,
                               s.Valor,
                               s.DataFechamento,
                               Animal = s.Animal.Nome,
                               TipoServico = s.TipoServico.Descricao
                           };
            dgvServicos.DataSource = servicos.ToList();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text != "Fechada")
            {
                Servico s = new Servico();

                if (!String.IsNullOrEmpty(txtID.Text))
                {
                    s.ServicoID = Convert.ToInt32(txtID.Text);
                }

                s.Horario = dtpHorario.Value.ToString();
                s.Valor = Convert.ToDouble(numValor.Value);
                s.AnimalID = Convert.ToInt32(txtIDAnimal.Text);
                s.Status = "Aberta";
                s.TipoServicoID = Convert.ToInt32(cbxTipoServico.SelectedValue);
                s.DataFechamento = txtDataFechamento.Text;

                ss.Gravar(s);
            } else
            {
                MessageBox.Show("Não se pode alterar registros após o fechamento do Serviço", "Impossível Alterar");
            }
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtIDAnimal.Clear();
            txtNomeAnimal.Clear();
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

        private void PopularControles(Servico s)
        {
            txtID.Text = Convert.ToString(s.ServicoID);
            txtIDAnimal.Text = Convert.ToString(s.AnimalID);
            txtNomeAnimal.Text = s.Animal.Nome;
            txtStatus.Text = s.Status;
            numValor.Value = Convert.ToDecimal(s.Valor);
            dtpHorario.Value = Convert.ToDateTime(s.Horario);
            txtDataFechamento.Text = s.DataFechamento;
            cbxTipoServico.SelectedValue = s.TipoServicoID;

            if (s.DataFechamento != ".")
            {
                dtpHorario.Enabled = false;
                numValor.Enabled = false;
            }
        }

        private int ObterIDServicoSelecionado(int rowIndex)
        {
            return Convert.ToInt32(dgvServicos.Rows[rowIndex].Cells[0].Value);
        }

        private void DgvServicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControles(ss.ObterPorID(ObterIDServicoSelecionado(e.RowIndex)));
        }

        private void BtnBuscarAnimal_Click(object sender, EventArgs e)
        {
            BuscasConsultaView bcv = new BuscasConsultaView(this, 1);
            bcv.Show();
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
                ServicoServico ss = new ServicoServico();
                /*if (.Count() == 0)
                {*/
                ss.Remover(id);
                LimparCampos();
                /*}
                else
                {
                    MessageBox.Show("Este Animal possui registros vinculados", "Impossível Excluir");
                }*/
            }
            else if (txtDataFechamento.Text != "." && txtStatus.Text != "Aberta")
            {
                MessageBox.Show("Não é possível excluir Serviços Finalizados", "Impossível Excluir");
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Servico s = new Servico();

            if (!String.IsNullOrEmpty(txtID.Text))
            {
                s.ServicoID = Convert.ToInt32(txtID.Text);
            }

            s.Horario = dtpHorario.Value.ToString("dd/MM/yyyy");
            s.AnimalID = Convert.ToInt32(txtIDAnimal.Text);
            s.Status = "Fechada";
            s.DataFechamento = DateTime.Now.ToString("dd/MM/yyyy");
            s.Valor = Convert.ToDouble(numValor.Value);
            s.TipoServicoID = Convert.ToInt32(cbxTipoServico.SelectedValue);

            ss.Gravar(s);
            //LimparCampos();
            ConsultaServicoContas csc = new ConsultaServicoContas(this);
            csc.Show();
        }
    }
}

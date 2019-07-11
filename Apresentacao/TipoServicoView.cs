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
    public partial class TipoServicoView : Form
    {
        TipoServicoServico tps = new TipoServicoServico();
        
        public TipoServicoView()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            TipoServico tp = new TipoServico();
            if (!String.IsNullOrEmpty(txtID.Text))
            {
                tp.TipoServicoID = Convert.ToInt32(txtID.Text);
            }

            tp.Descricao = txtDescricao.Text;

            tps.Gravar(tp);
            LimparCampos();
        }

        private void RefreshDataGridView()
        {
            dgvTipoServico.DataSource = tps.TodosTiposServico();
        }

        private void RefreshDataGridView(string descricao)
        {
            dgvTipoServico.DataSource = tps.TodosTiposServico(descricao);
        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtDescricao.Clear();
            RefreshDataGridView();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void PopularControles(TipoServico ts)
        {
            txtID.Text = Convert.ToString(ts.TipoServicoID);
            txtDescricao.Text = ts.Descricao;
        }

        private int ObterIDTipoServicoSelecionado(int rowIndex)
        {
            return Convert.ToInt32(dgvTipoServico.Rows[rowIndex].Cells[0].Value);
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPesquisar.Text))
            {
                RefreshDataGridView(txtPesquisar.Text);
            }
            else
            {
                RefreshDataGridView();
            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            if (txtID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione Algum Registro");
            }
            else
            {
                //ServicoServico ps = new ServicoServico();

                /*if (ps.ServicosPorTipo(id).Count() == 0)
                {*/
                    tps.Remover(id);
                    LimparCampos();
                /*}
                else
                {
                    MessageBox.Show("Este Tipo de Servico possui registros vinculados", "Impossível Excluir");
                }*/
            }
        }

        private void DgvTipoServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControles(tps.ObterPorID(ObterIDTipoServicoSelecionado(e.RowIndex)));
        }
    }
}

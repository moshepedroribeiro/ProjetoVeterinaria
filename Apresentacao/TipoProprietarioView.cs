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
    public partial class TipoProprietarioView : Form
    {
        TipoProprietarioServico tps;
        public TipoProprietarioView()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            tps = new TipoProprietarioServico();
            TipoProprietario tp = new TipoProprietario();

            if (!String.IsNullOrEmpty(txtID.Text))
            {
                tp.TipoProprietarioID = Convert.ToInt32(txtID.Text);
            }

            tp.Descricao = txtDescricao.Text;
            tp.PercentualDesconto = Convert.ToInt32(numDesconto.Value);

            tps.Gravar(tp);
            LimparCampos();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void PopularControles(TipoProprietario tp)
        {
            txtID.Text = Convert.ToString(tp.TipoProprietarioID);
            txtDescricao.Text = tp.Descricao.ToString();
            numDesconto.Value = Convert.ToInt32(tp.PercentualDesconto);
        }

        private void RefreshDataGridView()
        {
            tps = new TipoProprietarioServico();
            dgvTipoProprietario.DataSource = tps.TodosTiposProprietarios();
        }

        private void RefreshDataGridView(string nome)
        {
            tps = new TipoProprietarioServico();
            dgvTipoProprietario.DataSource = tps.TodosTiposProprietarios(nome);
        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtDescricao.Clear();
            numDesconto.Value = 0;

            RefreshDataGridView();
        }

        private int ObterIDTipoProprietarioSelecionado(int rowIndex)
        {
            return Convert.ToInt32(dgvTipoProprietario.Rows[rowIndex].Cells[0].Value);
        }

        private void DgvTipoProprietario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControles(tps.ObterPorID(ObterIDTipoProprietarioSelecionado(e.RowIndex)));
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
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
                ProprietarioServico ps = new ProprietarioServico();

                if (ps.ProprietariosPorTipo(id).Count() == 0)
                {
                    tps.Remover(id);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Este Tipo de Proprietarios possui registros vinculados", "Impossível Excluir");
                }
            }
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
    }
}

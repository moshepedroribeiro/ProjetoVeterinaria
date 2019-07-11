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
    public partial class ExameView : Form
    {
        ExameServico es = new ExameServico();
        public ExameView()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void BtnListaAnimais_Click(object sender, EventArgs e)
        {
            ExameAnimalView eav = new ExameAnimalView();
            eav.Show();
        }

        public void RefreshDataGridView()
        {
            dgvExame.DataSource = es.TodosExames();
        }

        public void RefreshDataGridView(string descricao)
        {
            dgvExame.DataSource = es.TodosExames(descricao);
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

        private void LimparCampos()
        {
            txtID.Clear();
            txtDescricao.Clear();
            numValor.Value = 0;
            RefreshDataGridView();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Exame ex = new Exame();
            
            if(!String.IsNullOrEmpty(txtID.Text))
            {
                ex.ExameID = Convert.ToInt32(txtID.Text);
            }

            ex.Descricao = txtDescricao.Text;
            ex.Valor = Convert.ToDouble(numValor.Value);

            es.Gravar(ex);

            LimparCampos();
        }

        private void PopularControles(Exame ex)
        {
            txtID.Text = Convert.ToString(ex.ExameID);
            txtDescricao.Text = ex.Descricao;
            numValor.Value = Convert.ToDecimal(ex.Valor);
        }

        private int ObterIDTipoAnimalSelecionado(int rowIndex)
        {
            return Convert.ToInt32(dgvExame.Rows[rowIndex].Cells[0].Value);
        }

        private void DgvExame_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControles(es.ObterPorID(ObterIDTipoAnimalSelecionado(e.RowIndex)));
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
                /*if(es.ExamesProntuarioCount(id).Count() == 0)
                {
                    es.Remover(id);
                    LimparCampos();
                } else
                {
                    MessageBox.Show("Este Exame possui registros vinculados", "Impossível Excluir");
                }*/
                es.Remover(id);
                LimparCampos();
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}

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
    public partial class TipoAnimalView : Form
    {
        TipoAnimalServico tas = new TipoAnimalServico();
        public TipoAnimalView()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dgvTipoAnimal.DataSource = tas.TodosTiposAnimal();
        }

        private void RefreshDataGridView(string nome)
        {
            dgvTipoAnimal.DataSource = tas.TodosTiposAnimal(nome);
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            TipoAnimal ta = new TipoAnimal();

            if (!String.IsNullOrEmpty(txtID.Text))
            {
                ta.TipoAnimalID = Convert.ToInt32(txtID.Text);
            }

            ta.Descricao = txtDescricao.Text;

            tas.Gravar(ta);

            LimparCampos();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtDescricao.Clear();
            RefreshDataGridView();
        }

        private void PopularControles(TipoAnimal ta)
        {
            txtID.Text = Convert.ToString(ta.TipoAnimalID);
            txtDescricao.Text = ta.Descricao;
        }

        private int ObterIDTipoAnimalSelecionado(int rowIndex)
        {
            return Convert.ToInt32(dgvTipoAnimal.Rows[rowIndex].Cells[0].Value);
        }

        private void DgvTipoAnimal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControles(tas.ObterPorID(ObterIDTipoAnimalSelecionado(e.RowIndex)));
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
                AnimalServico ans = new AnimalServico();

                if(ans.AnimaisPorTipo(id).Count() == 0)
                {
                    tas.Remover(id);
                    LimparCampos();
                } else
                {
                    MessageBox.Show("Este Tipo de Animal possui registros vinculados", "Impossível Excluir");
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

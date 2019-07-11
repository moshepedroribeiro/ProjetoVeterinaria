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
    public partial class AnimalView : Form
    {
        AnimalServico ans = new AnimalServico();
        TipoAnimalServico tas = new TipoAnimalServico();
        Proprietario p = new Proprietario();
        public AnimalView()
        {
            InitializeComponent();
            PopularComboBox();
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            var animal = from a in ans.TodosAnimais()
                               select new
                               {
                                   a.AnimalID,
                                   a.Nome,
                                   a.Idade,
                                   Proprietario = a.Proprietario.Nome,
                                   TipoAnimal = a.TipoAnimal.Descricao
                               };
            //var animal = ans.TodosAnimais();
            dgvAnimal.DataSource = animal.ToList();
        }

        public void RefreshDataGridView(string nome)
        {
            var animal = from a in ans.TodosAnimais(nome)
                         select new
                         {
                             a.AnimalID,
                             a.Nome,
                             a.Idade,
                             Proprietario = a.Proprietario.Nome,
                             TipoAnimal = a.TipoAnimal.Descricao
                         };
            //var animal = ans.TodosAnimais();
            dgvAnimal.DataSource = animal.ToList();
        }

        private void BtnBuscarProp_Click(object sender, EventArgs e)
        {
            AnimalProprietarioView apv = new AnimalProprietarioView(this);
            apv.Show();
        }

        private void BtnPront_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtID.Text))
            {
                btnPront.Enabled = true;
                AnimalProntuarioView apv = new AnimalProntuarioView(this);
                apv.Show();
            } else
            {
                MessageBox.Show("Selecione um Animal para acessar o Prontuário", "Atenção");
            }
            
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            txtProprietario.Clear();
            txtIDProp.Clear();
            numIdade.Value = 0;
            cbxTipoAnimal.SelectedIndex = 0;
            this.RefreshDataGridView();
        }

        public void PopularComboBox()
        {
            var tipos = tas.TodosTiposAnimal().OrderBy(ta => ta.Descricao).ToList<TipoAnimal>();
            cbxTipoAnimal.DataSource = tipos;

            tipos.Insert(0, new TipoAnimal()
            {
                TipoAnimalID = -1,
                Descricao = "Selecione um Tipo:"
            });

            cbxTipoAnimal.DisplayMember = "Descricao";
            cbxTipoAnimal.ValueMember = "TipoAnimalID";
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Animal a = new Animal();


            if (!String.IsNullOrEmpty(txtID.Text))
            {
                a.AnimalID = Convert.ToInt32(txtID.Text);
            }

            a.Nome = txtNome.Text;
            a.Idade = Convert.ToInt32(numIdade.Value);
            a.TipoAnimalID = Convert.ToInt32(cbxTipoAnimal.SelectedValue);
            a.ProprietarioID = Convert.ToInt32(txtIDProp.Text);



            ans.Gravar(a);

            LimparCampos();
        }

        private void DgvAnimal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControles(ans.ObterPorID(ObterIDAnimalSelecionado(e.RowIndex)));
        }

        private void PopularControles(Animal a)
        {
            txtID.Text = Convert.ToString(a.AnimalID);
            txtNome.Text = a.Nome.ToString();
            txtProprietario.Text = a.Proprietario.Nome.ToString();
            numIdade.Value = a.Idade;
            txtIDProp.Text = a.Proprietario.ProprietarioID.ToString();
            cbxTipoAnimal.SelectedValue = a.TipoAnimalID;
        }

        private int ObterIDAnimalSelecionado(int rowIndex)
        {
            return Convert.ToInt32(dgvAnimal.Rows[rowIndex].Cells[0].Value);
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione Algum Registro");
            }
            else
            {
                int id = Convert.ToInt32(txtID.Text);
                ProntuarioServico ps = new ProntuarioServico();
                if(ps.ProntuariosPorAnimal(id).Count() == 0)
                {
                    ans.Remover(id);
                    LimparCampos();
                } else
                {
                    MessageBox.Show("Este Animal possui registros vinculados", "Impossível Excluir");
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

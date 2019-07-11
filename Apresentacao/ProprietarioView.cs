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
    public partial class ProprietarioView : Form
    {
        private TipoProprietarioServico tps = new TipoProprietarioServico();
        private ProprietarioServico ps = new ProprietarioServico();
        public ProprietarioView()
        {
            InitializeComponent();
            PopularComboBox();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            var proprietario = from p in ps.TodosProprietarios()
                               select new
                               {
                                   p.ProprietarioID,
                                   p.Nome,
                                   p.Endereco,
                                   TipoProprietario = p.TipoProprietario.Descricao
                               };
            dgvProprietario.DataSource = proprietario.ToList();
        }

        private void RefreshDataGridView(string nome)
        {
            var proprietario = from p in ps.TodosProprietarios(nome)
                               select new
                               {
                                   p.ProprietarioID,
                                   p.Nome,
                                   p.Endereco,
                                   TipoProprietario = p.TipoProprietario.Descricao
                               };
            dgvProprietario.DataSource = proprietario.ToList();
        }

        private void PopularComboBox()
        {
            var tipos = tps.TodosTiposProprietarios().OrderBy(tp => tp.Descricao).ToList<TipoProprietario>();
            cbxTipoProprietario.DataSource = tipos;

            tipos.Insert(0, new TipoProprietario()
            {
                TipoProprietarioID = -1,
                Descricao = "Selecione um Tipo:"
            });

            cbxTipoProprietario.DisplayMember = "Descricao";
            cbxTipoProprietario.ValueMember = "TipoProprietarioID";
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Proprietario p = new Proprietario();
            
            if(!String.IsNullOrEmpty(txtID.Text))
            {
                p.ProprietarioID = Convert.ToInt32(txtID.Text);
            }
            
            p.Nome = txtNome.Text;
            p.DataNascimento = dtpDataNascimento.Value;
            p.Endereco = txtEndereco.Text;
            p.RgIe = txtRgIe.Text;
            p.CpfCnpj = txtCpfCnpj.Text;
            p.Telefone = txtTelefone.Text;
            p.TipoProprietarioID = Convert.ToInt32(cbxTipoProprietario.SelectedValue);

            ps.Gravar(p);
            LimparCampos();           
        }

        private void PopularControles(Proprietario p)
        {
            txtID.Text = Convert.ToString(p.ProprietarioID);
            txtNome.Text = p.Nome.ToString();
            txtEndereco.Text = p.Endereco.ToString();
            txtRgIe.Text = p.RgIe.ToString();
            txtCpfCnpj.Text = p.CpfCnpj.ToString();
            txtTelefone.Text = p.Telefone.ToString();
            cbxTipoProprietario.SelectedValue = p.TipoProprietarioID;
            dtpDataNascimento.Value = p.DataNascimento;
        }

        private int ObterIDProprietarioSelecionado(int rowIndex)
        {
            return Convert.ToInt32(dgvProprietario.Rows[rowIndex].Cells[0].Value);
        }

        private void DgvProprietario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControles(ps.ObterPorID(ObterIDProprietarioSelecionado(e.RowIndex)));
        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtRgIe.Clear();
            txtCpfCnpj.Clear();
            txtTelefone.Clear();
            cbxTipoProprietario.SelectedIndex = 0;

            foreach (DateTimePicker dtp in this.Controls.OfType<DateTimePicker>())
            {
                dtpDataNascimento.Value = DateTime.Now;
            }

            this.RefreshDataGridView();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            AnimalServico ans = new AnimalServico();

            if(txtID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione Algum Registro");
            } else
            {
                if(ans.AnimaisPorProprietario(id).Count() == 0)
                {
                    ps.Remover(id);
                    LimparCampos();
                } else
                {
                    MessageBox.Show("Este Proprietario está vinculado a outros registros", "Impossível Excluir");
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
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

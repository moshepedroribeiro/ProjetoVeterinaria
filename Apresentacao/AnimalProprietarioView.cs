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
    public partial class AnimalProprietarioView : Form
    {
        private TipoProprietarioServico tps = new TipoProprietarioServico();
        private ProprietarioServico ps = new ProprietarioServico();
        AnimalView av;
        public AnimalProprietarioView(AnimalView fmrAv)
        {
            InitializeComponent();
            RefreshDataGridView();
            av = fmrAv;
        }

        public void RefreshDataGridView()
        {
            var proprietario = from p in ps.TodosProprietarios()
                               select new
                               {
                                   p.ProprietarioID,
                                   p.Nome,
                                   p.Endereco,
                                   TipoProprietario = p.TipoProprietario.Descricao
                               };
            dgvBusca.DataSource = proprietario.ToList();
        }

        public void RefreshDataGridView(string nome)
        {
            var proprietario = from p in ps.TodosProprietarios(nome)
                               select new
                               {
                                   p.ProprietarioID,
                                   p.Nome,
                                   p.Endereco,
                                   TipoProprietario = p.TipoProprietario.Descricao
                               };
            dgvBusca.DataSource = proprietario.ToList();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtPesquisar.Text))
            {
                RefreshDataGridView(txtPesquisar.Text);
            } else
            {
                RefreshDataGridView();
            }
            
        }

        private int ObterIDProprietarioSelecionado(int rowIndex)
        {
            return Convert.ToInt32(dgvBusca.Rows[rowIndex].Cells[0].Value);
        }

        private void DgvBusca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControles(ps.ObterPorID(ObterIDProprietarioSelecionado(e.RowIndex)));
            this.Close();
        }

        public void PopularControles(Proprietario p)
        {
            av.txtProprietario.Text = p.Nome.ToString();
            av.txtIDProp.Text = Convert.ToString(p.ProprietarioID);

            av.txtProprietario.Refresh();
            av.txtIDProp.Refresh();
        }
    }
}

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
    public partial class AnimalProntuarioView : Form
    {
        ProntuarioServico ps = new ProntuarioServico();
        AnimalServico ans = new AnimalServico();
        AnimalView av;
        public AnimalProntuarioView(AnimalView frm)
        {
            InitializeComponent();
            av = frm;
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            var pron = from p in ps.TodosProntuarios(Convert.ToInt32(av.txtID.Text))
                       select new
                       {
                           p.ProntuarioID,
                           p.Diagnostico,
                           Data = p.Data.ToString("dd/MM/yyyy"),
                           p.Tratamento,
                           Animal = p.Animal.Nome
                       };

            dgvProntuario.DataSource = pron.ToList();
        }

        public void RefreshDataGridView(string data)
        {
            var pron = from p in ps.TodosProntuarios(Convert.ToInt32(av.txtID.Text), data)
                       select new
                       {
                           p.ProntuarioID,
                           p.Diagnostico,
                           Data = p.Data.ToString("dd/MM/yyyy"),
                           p.Tratamento,
                           Animal = p.Animal.Nome
                       };

            dgvProntuario.DataSource = pron.ToList();
        }

        public void LimparCampos()
        {
            txtID.Clear();
            txtDiagnostico.Clear();
            txtTratamento.Clear();
            dtpDataProntuario.Value = DateTime.Now;
            RefreshDataGridView();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Prontuario p = new Prontuario();

            if (!String.IsNullOrEmpty(txtID.Text))
            {
                p.ProntuarioID = Convert.ToInt32(txtID.Text);
            }

            p.Diagnostico = txtDiagnostico.Text;
            p.Tratamento = txtTratamento.Text;
            p.Data = dtpDataProntuario.Value;
            p.AnimalID = Convert.ToInt32(av.txtID.Text);

            ps.Gravar(p);

            LimparCampos();
        }

        private void PopularControles(Prontuario p)
        {
            txtID.Text = Convert.ToString(p.ProntuarioID);
            txtDiagnostico.Text = p.Diagnostico.ToString();
            txtTratamento.Text = p.Tratamento.ToString();
            dtpDataProntuario.Value = p.Data;
        }

        private void DgvProntuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControles(ps.ObterPorID(ObterIDProntuarioSelecionado(e.RowIndex)));
        }

        private int ObterIDProntuarioSelecionado(int rowIndex)
        {
            return Convert.ToInt32(dgvProntuario.Rows[rowIndex].Cells[0].Value);
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione Algum Registro");
            }
            else
            {
                ps.Remover(Convert.ToInt32(txtID.Text));
                LimparCampos();
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (dtpPesquisar.Value.ToString("dd/MM/yyyy") != DateTime.Now.ToString("dd/MM/yyyy"))
            {
                RefreshDataGridView(dtpPesquisar.Value.ToString("dd/MM/yyyy"));
            }
            else
            {
                RefreshDataGridView();
            }
        }

        private void BtnPesquisarHoje_Click(object sender, EventArgs e)
        {
            RefreshDataGridView(DateTime.Now.ToString("dd/MM/yyyy"));
        }

        private void BtnExames_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtID.Text)) {
                int op = 1;
                AnimalProntuarioExameView apev = new AnimalProntuarioExameView(av, this, op);
                apev.Show();
            } else
            {
                MessageBox.Show("Selecione um registro de Prontuário salvo para adicionar um exame");
            }
        }

        private void BtnExamesAnimal_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtID.Text))
            {
                int op = 2;
                AnimalProntuarioExameView apev = new AnimalProntuarioExameView(av, this, op);
                apev.Show();
            }
            else
            {
                MessageBox.Show("Selecione um registro de Prontuário salvo para buscar um exame");
            }
        }
    }
}

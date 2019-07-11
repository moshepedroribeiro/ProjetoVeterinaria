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
    public partial class AnimalProntuarioExameView : Form
    {
        AnimalProntuarioView apv;
        AnimalView av;
        ExameServico es = new ExameServico();
        ProntuarioExameServico pes = new ProntuarioExameServico();
        public AnimalProntuarioExameView(AnimalView frm, AnimalProntuarioView frm2, int op)
        {
            InitializeComponent();
            av = frm;
            apv = frm2;
            
            if (op == 1)
            {
                RefreshDataGridView();
            }else
            {
                RefreshDataGridViewSearch();
            }


        }

        private void RefreshDataGridView()
        {
            dgvProntuarioExame.DataSource = es.TodosExames();
        }

        private void RefreshDataGridViewSearch()
        {
            var pron = from p in pes.TodosExamesPorProntuario(Convert.ToInt32(apv.txtID.Text))
                       select new
                       {
                           p.ProntuarioExameID,
                           Exame = p.Exame.Descricao
                        
                       };

            dgvProntuarioExame.DataSource = pron.ToList();



            btnPesquisar.Enabled = false;
            txtPesquisar.Enabled = false;
        }

        private void RefreshDataGridView(string desc)
        {
            dgvProntuarioExame.DataSource = es.TodosExames(desc);
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

        private void DgvProntuarioExame_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProntuarioExame pe = new ProntuarioExame();
            MessageBox.Show(apv.txtID.Text);
            pe.ExameID = ObterIDExameSelecionado(e.RowIndex);
            pe.ProntuarioID = Convert.ToInt32(apv.txtID.Text);

            DialogResult result = MessageBox.Show("Deseja Adicionar o Exame " +
                "a este prontuário?", "Aviso", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                pes.Gravar(pe);
            } else
            {
                MessageBox.Show("Exame não adicionado ao Prontuário");
            }
        }

        private int ObterIDExameSelecionado(int rowIndex)
        {
            return Convert.ToInt32(dgvProntuarioExame.Rows[rowIndex].Cells[0].Value);
        }
    }
}

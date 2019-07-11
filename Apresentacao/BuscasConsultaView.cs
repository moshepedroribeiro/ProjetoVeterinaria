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
    public partial class BuscasConsultaView : Form
    {
        MedicoServico ms = new MedicoServico();
        AnimalServico ans = new AnimalServico();

        ConsultaView cv = null;
        ServicoView sv = null;
        int op;
        public BuscasConsultaView(ConsultaView cons, int op)
        {
            InitializeComponent();
            cv = cons;
            this.op = op;

            if(op == 1)
            {
                RefreshDataGridViewAnimal();
            } else
            {
                RefreshDataGridViewMedico();
            }
        }

        public BuscasConsultaView(ServicoView con, int op)
        {
            InitializeComponent();
            sv = con;
            this.op = op;

            if (op == 1)
            {
                RefreshDataGridViewAnimal();
            }
            else
            {
                RefreshDataGridViewMedico();
            }
        }

        private void RefreshDataGridViewAnimal()
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
            dgvBusca.DataSource = animal.ToList();
        }

        private void RefreshDataGridViewAnimal(string nome)
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
            dgvBusca.DataSource = animal.ToList();
        }

        public void RefreshDataGridViewMedico()
        {
            var med = from m in ms.TodosMedicos()
                      select new
                      {
                          m.MedicoID,
                          m.Nome,
                          m.Crmv
                      };
            dgvBusca.DataSource = med.ToList();
        }

        public void RefreshDataGridViewMedico(string nome)
        {
            var med = from m in ms.TodosMedicos(nome)
                      select new
                      {
                          m.MedicoID,
                          m.Nome,
                          m.Crmv
                      };
            dgvBusca.DataSource = med.ToList();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if(op == 1 && !String.IsNullOrEmpty(txtBuscar.Text))
            {
                RefreshDataGridViewAnimal(txtBuscar.Text);
            } else if(op == 1 && String.IsNullOrEmpty(txtBuscar.Text))
            {
                RefreshDataGridViewAnimal();
            } else if(op == 2 && !String.IsNullOrEmpty(txtBuscar.Text))
            {
                RefreshDataGridViewMedico(txtBuscar.Text);
            } else if(op == 2 && String.IsNullOrEmpty(txtBuscar.Text))
            {
                RefreshDataGridViewMedico();
            }
        }

        private int ObterIDAnimalSelecionado(int rowIndex)
        {
            return Convert.ToInt32(dgvBusca.Rows[rowIndex].Cells[0].Value);
        }

        private int ObterIDMedicoSelecionado(int rowIndex)
        {
            return Convert.ToInt32(dgvBusca.Rows[rowIndex].Cells[0].Value);
        }

        private void PopularControles(Animal a)
        {
            if (sv == null) {
                cv.txtIDAnimal.Text = Convert.ToString(a.AnimalID);
                cv.txtNomeAnimal.Text = a.Nome;
            } else if(cv == null)
            {
                sv.txtIDAnimal.Text = Convert.ToString(a.AnimalID);
                sv.txtNomeAnimal.Text = a.Nome;
            }
        }

        private void PopularControles(Medico m)
        {
            cv.txtIDMedico.Text = Convert.ToString(m.MedicoID);
            cv.txtNomeMedico.Text = m.Nome;
        }

        private void DgvBusca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(op == 1)
            {
                PopularControles(ans.ObterPorID(ObterIDAnimalSelecionado(e.RowIndex)));
            } else
            {
                PopularControles(ms.ObterPorID(ObterIDMedicoSelecionado(e.RowIndex)));
            }

            this.Close();

            //MessageBox.Show(Convert.ToString(e.RowIndex));
        }
    }
}

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
    public partial class MedicoView : Form
    {
        int id;
        public MedicoView(int idMedico)
        {
            id = idMedico;
            InitializeComponent();
            RefreshDataGridView();
        }

        MedicoServico ms = new MedicoServico();

        public void RefreshDataGridView()
        {
            var med = from m in ms.TodosMedicos()
                         select new
                         {
                             m.MedicoID,
                             m.Nome,
                             m.Crmv
                         };
            dgvMedico.DataSource = med.ToList();
        }

        public void RefreshDataGridView(string nome)
        {
            var med = from m in ms.TodosMedicos(nome)
                      select new
                      {
                          m.MedicoID,
                          m.Nome,
                          m.Crmv
                      };
            dgvMedico.DataSource = med.ToList();
        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            txtCrmv.Clear();
            pwdSenha.Clear();
            pwdSenha.Enabled = true;
            RefreshDataGridView();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Medico m = new Medico();

            if (!String.IsNullOrEmpty(txtID.Text))
            {
                m.MedicoID = Convert.ToInt32(txtID.Text);
            }

            m.Nome = txtNome.Text;
            m.Crmv = txtCrmv.Text;
            m.Senha = pwdSenha.Text;

            ms.Gravar(m);
            LimparCampos();
        }

        private void PopularControles(Medico m)
        {
            txtID.Text = Convert.ToString(m.MedicoID);
            txtNome.Text = m.Nome.ToString();
            txtCrmv.Text = m.Crmv.ToString();
            pwdSenha.Text = m.Senha;
        }

        private int ObterIDMedicoSelecionado(int rowIndex)
        {
            return Convert.ToInt32(dgvMedico.Rows[rowIndex].Cells[0].Value);
        }

        private void DgvMedico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(Convert.ToString(ObterIDMedicoSelecionado(e.RowIndex)) + "   " + Convert.ToString(this.id));
            PopularControles(ms.ObterPorID(ObterIDMedicoSelecionado(e.RowIndex)));
            if (this.id != ObterIDMedicoSelecionado(e.RowIndex))
            {
                pwdSenha.Enabled = false;
            } else if(this.id == ObterIDMedicoSelecionado(e.RowIndex))
            {
                btnDeletar.Enabled = false;
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

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione Algum Registro");
            }
            else
            {
                int id = Convert.ToInt32(txtID.Text);
                /*ConsultaServico cs = new ConsultaServico();
                if (cs.MedicoPorConsulta(id).Count() == 0)
                {*/
                    ms.Remover(id);
                    LimparCampos();
                /*}
                else
                {
                    MessageBox.Show("Este Animal possui registros vinculados", "Impossível Excluir");
                }*/

            }
        }
    }
}

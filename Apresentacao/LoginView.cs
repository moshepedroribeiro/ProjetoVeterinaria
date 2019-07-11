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
    public partial class LoginView : Form
    {
        MedicoServico ms = new MedicoServico();
        public LoginView()
        {
            InitializeComponent();
            PopularCombobox();
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            var m = ms.ObterPorID(Convert.ToInt32(txtID.Text));
            
            if (m.MedicoID == Convert.ToInt32(txtID.Text) && m.Senha == txtSenha.Text)
            {
                Inicial i = new Inicial(m.MedicoID);
                i.Show();
                this.Visible = false;
            } else
            {
                MessageBox.Show("Usuário ou senha incorretos, Caso esqueceste tua senha, entre em contato com o Administrador do Sistema", "Aviso");
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopularCombobox()
        {
            var med = ms.TodosMedicos().OrderBy(p => p.Nome).ToList<Medico>();
            cbxUser.DataSource = med;

            med.Insert(0, new Medico()
            {
                MedicoID = -1,
                Nome = "Selecione um Usuario:"
            });

            cbxUser.DisplayMember = "Nome";
            cbxUser.ValueMember = "MedicoID";
        }

        private void TxtID_Leave(object sender, EventArgs e)
        {
            //PopularCombobox(Convert.ToInt32(txtID.Text));
        }

        private void CbxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = Convert.ToString(cbxUser.SelectedValue);
        }
    }
}

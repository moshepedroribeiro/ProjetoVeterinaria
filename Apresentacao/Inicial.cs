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
    public partial class Inicial : Form
    {
        int id;
        public Inicial(int idMedico)
        {
            id = idMedico;
            InitializeComponent();
        }

        private void Opcao1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void TipoDeProprietárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoProprietarioView tpv = new TipoProprietarioView();
            tpv.Show();
        }

        private void ProprietárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProprietarioView pv = new ProprietarioView();
            pv.Show();
        }

        private void TipoAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoAnimalView tav = new TipoAnimalView();
            tav.Show();
        }

        private void AnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnimalView av = new AnimalView();
            av.Show();
        }

        private void ExamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExameView ev = new ExameView();
            ev.Show();
        }

        private void TipoDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoServicoView tsv = new TipoServicoView();
            tsv.Show();
        }

        private void MedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicoView mv = new MedicoView(id);
            mv.Show();
        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaView cv = new ConsultaView();
            cv.Show();
        }

        private void Opcao21ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicoView sv = new ServicoView();
            sv.Show();
        }

        private void ContasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContasReceberView crv = new ContasReceberView();
            crv.Show();
        }

        private void Opcao31ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaixaView cv = new CaixaView();
            cv.Show();
        }
    }
}

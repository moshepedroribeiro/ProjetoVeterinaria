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
    public partial class ConsultaServicoContas : Form
    {
        ConsultaView cv;
        ServicoView sv;

        public ConsultaServicoContas(ConsultaView frm)
        {
            InitializeComponent();
            cv = frm;
        }

        public ConsultaServicoContas(ServicoView frm)
        {
            InitializeComponent();
            sv = frm;
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            ContasReceber cr = new ContasReceber();
            ConsultaServico cs = new ConsultaServico();
            ContasReceberServico crs = new ContasReceberServico();
            List<ContasReceber> contas = new List<ContasReceber>();


            if (rbtVista.Checked || rbtOutros.Checked)
            {
                cr.DataBaixa = DateTime.Now.ToString("dd/MM/yyyy");
                cr.DataCriacao = DateTime.Now.ToString("dd/MM/yyyy");
                cr.DataVencimento = DateTime.Now.ToString("dd/MM/yyyy");
                
                if(!String.IsNullOrEmpty(cv.txtID.Text))
                {
                    cr.ValorTitulo = Convert.ToDouble(cv.numValor.Value);
                    cr.ConsultaID = Convert.ToInt32(cv.txtID.Text);
                } else
                {
                    cr.ValorTitulo = Convert.ToDouble(sv.numValor.Value);
                    cr.ServicoID = Convert.ToInt32(sv.txtID.Text);
                }

                crs.Gravar(cr);
            } else if(rbtPrazo.Checked)
            {
                for (int i = 1; i <= Convert.ToInt32(numParcelas.Value); i++)
                {
                    if (!String.IsNullOrEmpty(cv.txtID.Text))
                    {
                        cr.ValorTitulo = Convert.ToDouble(cv.numValor.Value)/ Convert.ToDouble(numParcelas.Value);
                        cr.ConsultaID = Convert.ToInt32(cv.txtID.Text);
                    }
                    else
                    {
                        cr.ValorTitulo = Convert.ToDouble(sv.numValor.Value)/ Convert.ToDouble(numParcelas.Value);
                        cr.ServicoID = Convert.ToInt32(sv.txtID.Text);
                    }
                    cr.DataVencimento = DateTime.Now.AddMonths(i).ToString("dd/MM/yyyy");
                    cr.DataCriacao = DateTime.Now.ToString("dd/MM/yyyy");
                    cr.DataBaixa = ".";

                    contas.Add(cr);
                }

              
                crs.GravarList(contas);
                
            }

            this.Close();
        }
    }
}

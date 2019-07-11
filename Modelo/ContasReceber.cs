using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class ContasReceber
    {
        public int ContasReceberID { get; set; }
        public double ValorTitulo { get; set; }
        public string DataCriacao { get; set; }
        public string DataBaixa { get; set; }
        public string DataVencimento { get; set; }
        public int ConsultaID { get; set; }
        public int ServicoID { get; set; }
        public Consulta Consulta { get; set; }
        public Servico Servico { get; set; }
    }
}

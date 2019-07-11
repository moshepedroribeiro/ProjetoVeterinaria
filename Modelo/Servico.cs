using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Servico
    {
        public int ServicoID { get; set; }
        public double Valor { get; set; }
        public string Horario { get; set; }
        public string DataFechamento { get; set; }
        public string Status { get; set; }
        public int TipoServicoID { get; set; }
        public int AnimalID { get; set; }
        public TipoServico TipoServico { get; set; }
        public Animal Animal { get; set; }
        public List<ContasReceber> ContasReceber { get; set; }
    }
}

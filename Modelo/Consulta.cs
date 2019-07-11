using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Consulta
    {
        public int ConsultaID { get; set; }
        public DateTime Horario { get; set; }
        public string DataFechamento { get; set; }
        public double Valor { get; set; }
        public int AnimalID { get; set; }
        public int MedicoID { get; set; }
        public string Status { get; set; }
        public Animal Animal { get; set; }
        public Medico Medico { get; set; }
        public List<ContasReceber> ContasReceber { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Prontuario
    {
        public int ProntuarioID { get; set; }
        public DateTime Data { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamento { get; set; }
        public int AnimalID { get; set; }
        public Animal Animal { get; set; }
        public virtual List<ProntuarioExame> ProntuarioExame { get; set; }
    }
}

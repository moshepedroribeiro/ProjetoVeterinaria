using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class ProntuarioExame
    {
        public int ProntuarioExameID { get; set; }
        public int ProntuarioID { get; set; }
        public int ExameID { get; set; }
        public virtual Prontuario Prontuario { get; set; }
        public virtual Exame Exame { get; set; }
    }
}

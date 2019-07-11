using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int ProprietarioID { get; set; }
        public int TipoAnimalID { get; set; }
        public virtual List<Prontuario> Prontuario { get; set; }
        public virtual Proprietario Proprietario { get; set; }
        public virtual TipoAnimal TipoAnimal { get; set; }
        public List<Consulta> Consulta { get; set; }
        public List<Servico> Servico { get; set; }
    }
}

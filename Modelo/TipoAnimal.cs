using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class TipoAnimal
    {
        public int TipoAnimalID { get; set; }
        public string Descricao { get; set; }
        public virtual List<Animal> Animal { get; set; }
    }
}

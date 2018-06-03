using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_Trein
{
    class Animal
    {
        public string AnimalType { get; set; }
        public string AnimalSize { get; set; }

        public Animal(string animaltype, string animalsize)
        {
            this.AnimalSize = animalsize;
            this.AnimalType = animaltype;
        }
    }
}

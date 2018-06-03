using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_Trein
{
    class Wagon
    {
        public int Points { get; set; }
        public List<Animal> Animals { get; set; }

        public Wagon(Animal animal)
        {
            Animals = new List<Animal> { animal };
            Points = AnamilSizeToPoint(animal.AnimalSize);
        }

        private int AnamilSizeToPoint(string size)
        {
            int point = 0;
            if (size == "Small")
            {
                point = 1;
            }
            else if (size == "Medium")
            {
                point = 3;
            }
            else if (size == "Large")
            {
                point = 5;
            }

            return point;
        }
    }
}

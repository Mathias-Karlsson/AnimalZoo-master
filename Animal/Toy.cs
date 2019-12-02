using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Toy
    {
        private string name;
        public Toy(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
        
    }
}

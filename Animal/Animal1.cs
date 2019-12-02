using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvForms
{
    enum SPECIES { CAT, DOG, BIRD}
    class Animal
    {
        public string Name { get; set; }
        public SPECIES Species { get; set; } 
        public bool CanFly { get; set; }
    }
}

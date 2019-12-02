using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Cat : Animal
    {
        public Cat(string name)
        {
            base.name = name;
            species = SPECIES.CAT;
            canFly = false;
        }


        public override void IntroduceYourself()
        {
            Console.WriteLine("Mjau. Jag är en katt som heter " + name);
            base.IntroduceYourself();
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Animal
    {
        public enum SPECIES { CAT, DOG, BIRD }

        public string name { get; set; }
        public SPECIES species { get; set; }
        public bool canFly { get; set; }
        public int birthyear { get; set; }
        private Animal friend { get; set; }
        private Animal house { get; set; }

        public static int currentYear = 2019;
        public int getAge()
        {
            return currentYear - birthyear;
        }

        public void setAge(int newAge)
        {
            birthyear = currentYear - newAge;
        }

        public void SetFriend(Animal animal)
        {
            friend = animal;
        }

        public void AddAnimal(Animal animal)
        {
            house = animal;
        }

        public void Print()
        {
            if (friend != null)
            {
                Console.WriteLine("Här är uppgifter om min kompis: ");
                friend.IntroduceYourself();
            }
            else
            {
                Console.WriteLine("Jag har ingen kompis.");
            }
        }

        public virtual void IntroduceYourself()
        {
            Console.WriteLine("Morr.Jag är ett djur som heter " + name + ".");
            Console.WriteLine("Jag är " + (currentYear - birthyear) + " år gammal.");
        }
    }

}

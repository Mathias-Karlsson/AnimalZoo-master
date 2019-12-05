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
        private int birthyear { get; set; }
        public Animal friend { get; set; }
        public House house { get; set; }
        public Toy toy { get; set; }

        private static int currentYear = 2019;
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

        public void AddToy(Toy animal)
        {
            toy = animal;
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

        public static int GetCurrentYear()
        {
            return currentYear;
        }

        public virtual void IntroduceYourself()
        {
            Console.WriteLine("Morr.Jag är ett djur som heter " + name + ".");
            Console.WriteLine("Jag är " + (currentYear - birthyear) + " år gammal.");
            Console.WriteLine("Min kompis är " + friend.name);
            Console.WriteLine("Min leksak är " + toy.GetName());
        }
    }

}

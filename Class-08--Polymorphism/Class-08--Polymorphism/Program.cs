using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_08__Polymorphism
{
    class Animal
    {
        public string Name;
        public string Sound;

        public void animalsound()
        {
            Console.WriteLine("animal make a sound");
        }
    }


    class Lion : Animal
    {
        private void animalsound()
        {
            Console.WriteLine("Lion make the sound: Roar");
        }
    }

    class Horse : Animal
    {
        private void animalsound()
        {
            Console.WriteLine("Horse make the sound: Neigh");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
                Animal myAnimal =  Animal();
                Lion myLion = new Lion();
                Horse myHorse = new Horse();

                myAnimal.animalsound();
                myLion.animalsound();
                myHorse.animalsound();
                Console.ReadKey();
        }
    }
}

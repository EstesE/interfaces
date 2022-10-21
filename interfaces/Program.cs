using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface = defines a "contract" that all the classes inheriting from should follow

            //      An interface delares "what a class should have"
            //      An inheriting class defines "how it should do it"

            //      Benefit = security + multiple inheritance + "plug-and-play"


            Rabbit rabbit = new Rabbit();
            rabbit.Flee();

            Hawk hawk = new Hawk();
            hawk.Hunt();

            Fish fish = new Fish();
            fish.Flee();
            fish.Hunt();

            Console.ReadLine();
        }

        interface IPrey
        {
            void Flee();
        }

        interface IPredator
        {
            void Hunt();
        }

        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away!\n");
            }
        }

        class Hawk : IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk hunts for food!\n");
            }
        }

        class Fish : IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("The fish swims away.");
            }

            public void Hunt()
            {
                Console.WriteLine("The fish searches for smaller fish to eat.\n");
            }
        }
    }
}

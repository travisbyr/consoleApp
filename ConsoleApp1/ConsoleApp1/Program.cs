using System;

namespace ConsoleApp1
{
    class Animal
    {
        String AnimalName;
        String AnimalType;
        String AnimalSound;

        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();

            a1.AnimalName = "cleopatra";
            a1.AnimalType = "lion";
            a1.AnimalSound = "roar";


            a2.AnimalName = "paptrika";
            a2.AnimalType = "tiger";
            a2.AnimalSound = "snarl";


            a3.AnimalName = "hercules";
            a3.AnimalType = "mouse";
            a3.AnimalSound = "squeak";

            Console.WriteLine(a1.AnimalName + " the " + a1.AnimalType + " can " + a1.AnimalSound);
            Console.WriteLine(a2.AnimalName + " the " + a2.AnimalType + " can " + a2.AnimalSound);
            Console.WriteLine(a3.AnimalName + " the " + a3.AnimalType + " can " + a3.AnimalSound);
        }

    }
}

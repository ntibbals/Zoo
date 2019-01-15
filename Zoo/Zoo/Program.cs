using System;
using Zoo.CLasses;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Frog();
        }

        static void Frog()
        {
            BlueMntTreeFrong frog = new BlueMntTreeFrong();
            frog.Number_Of_Legs = 4;
            frog.Poison_Level = 7;
            Console.WriteLine($"Frog:");
            Console.WriteLine($"Number of legs: {frog.Number_Of_Legs}");
            Console.WriteLine($"Has a tale: {frog.Number_Of_Legs}");
            Console.WriteLine($"Has a tale: {frog.Number_Of_Legs}");
            Console.WriteLine($"Lives in tree: {frog.Lives_In_Tree}");
            Console.WriteLine(frog.Ribbit());
            Console.WriteLine(frog.LaysEggs());
            Console.WriteLine(frog.Extend_Tongue());
            Console.WriteLine(frog.Eating());
        }
    }
}

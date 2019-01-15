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
            Gecko();
            Tiger();
        }

        static void Frog()
        {
            BlueMntTreeFrong frog = new BlueMntTreeFrong();
            frog.Number_Of_Legs = 4;
            frog.Poison_Level = 7;
            Console.WriteLine($"Frog:");
            Console.WriteLine($"Number of legs: {frog.Number_Of_Legs}");
            Console.WriteLine($"Has a tale: {frog.Tail}");
            Console.WriteLine($"Lives in tree: {frog.Lives_In_Tree}");
            Console.WriteLine(frog.Ribbit());
            Console.WriteLine(frog.LaysEggs());
            Console.WriteLine(frog.Extend_Tongue());
            Console.WriteLine(frog.Eating());
            Console.WriteLine(frog.Sleeping());
        }

        static void Gecko()
        {
            LeopardGecko gecko = new LeopardGecko();
            gecko.Number_Of_Legs = 4;
            gecko.Num_Spots = 25;
            Console.WriteLine($"Gecko:");
            Console.WriteLine($"Number of legs: {gecko.Number_Of_Legs}");
            Console.WriteLine($"Has a tale: {gecko.Tail}");
            Console.WriteLine($"Has dry skin: {gecko.Dry_Skin}");
            Console.WriteLine($"Spots: {gecko.Num_Spots}");
            Console.WriteLine(gecko.Insurance_Quote());
            Console.WriteLine(gecko.Burrow());
            Console.WriteLine(gecko.Eating());
            Console.WriteLine(gecko.Sleeping());
        }

        static void Tiger()
        {
            BengalTiger tiger = new BengalTiger();
            tiger.Number_Of_Legs = 4;
            Console.WriteLine($"Tiger:");
            Console.WriteLine($"Number of legs: {tiger.Number_Of_Legs}");
            Console.WriteLine($"Has a tale: {tiger.Tail}");
            Console.WriteLine(tiger.Roam());
            Console.WriteLine(tiger.Climb());
            Console.WriteLine(tiger.Eating());
            Console.WriteLine(tiger.Sleeping());
        }
    }
}

﻿using System;
using Zoo.CLasses;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("Welcome to the Zoo.");
            Console.WriteLine("**************************************");
            Frog();
            Console.WriteLine("**************************************");
            Gecko();
            Console.WriteLine("**************************************");
            Tiger();
            Console.WriteLine("**************************************");
            Orca();
            Console.WriteLine("**************************************");
            Whale();
            Console.WriteLine("**************************************");
            Sally();
            Console.WriteLine("**************************************");
            Lion();
            Console.WriteLine("**************************************");
            Turtle();
            Console.WriteLine("**************************************");
            Console.ReadLine();
        }

        static void Frog()
        {
            BlueMntTreeFrong frog = new BlueMntTreeFrong();
            frog.Number_Of_Legs = 4;
            frog.Poison_Level = 7;
            Console.WriteLine("Frog:");
            Console.WriteLine($"Number of legs: {frog.Number_Of_Legs}");
            Console.WriteLine($"Has a tale: {frog.Tail}");
            Console.WriteLine($"Lives in tree: {frog.Lives_In_Tree}");
            Console.WriteLine(frog.Ribbit());
            Console.WriteLine(frog.Lays_Eggs());
            Console.WriteLine(frog.Extend_Tongue());
            Console.WriteLine(frog.Eating());
            Console.WriteLine(frog.Sleeping());
        }

        static void Gecko()
        {
            LeopardGecko gecko = new LeopardGecko();
            gecko.Number_Of_Legs = 4;
            gecko.Num_Spots = 25;
            Console.WriteLine("Gecko:");
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
            Console.WriteLine("Tiger:");
            Console.WriteLine($"Number of legs: {tiger.Number_Of_Legs}");
            Console.WriteLine($"Has a tale: {tiger.Tail}");
            Console.WriteLine(tiger.Roam());
            Console.WriteLine(tiger.Climb());
            Console.WriteLine(tiger.Eating());
            Console.WriteLine(tiger.Sleeping());
        }

        static void Orca()
        {
            Orca orca = new Orca();
            Console.WriteLine("Orca:");
            Console.WriteLine(orca.JumpRockBase());
        }

        static void Whale()
        {
            BlueWhale whale = new BlueWhale();
            Console.WriteLine("Whale");
            Console.WriteLine(whale.Mating());
        }

        static void Sally()
        {
            CaveSalamander sally = new CaveSalamander();
            Console.WriteLine("Sally the Salamander:");
            Console.WriteLine(sally.Lays_Eggs());
        }

        static void Lion()
        {
            Lion lion = new Lion();
            Console.WriteLine("Lion:");
            Console.WriteLine(lion.Hunting());
        }

        static void Turtle()
        {
            SpottedTurtle turtle = new SpottedTurtle();
            Console.WriteLine("Turtle:");
            Console.WriteLine(turtle.Migrates());
        }
    }
}

﻿using Packt.Shared;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        var bob = new Person();
        WriteLine(bob.ToString());
        bob.Name = "Bob";
        
        bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlimpia;
        WriteLine(format: "{0}'s Favorite wonder is {1}. It's integer is {2}.",
            arg0: bob.Name,
            arg1: bob.FavoriteAncientWonder,
            arg2: (int)bob.FavoriteAncientWonder);
  
      //  bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
          bob.BucketList=(WondersOfTheAncientWorld)18;
          WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

        bob.Children.Add(new Person{Name = "Alfred"});
        bob.Children.Add(new Person{Name = "Zoe"});
        WriteLine($"{bob.Name} has {bob.Children.Count} children:");
        for (int child =0;child < bob.Children.Count;child++)
        {
            WriteLine($"{bob.Children[child].Name}");
        }
        BankAccount.InterestRate= 0.012M;
        var jonesAccount = new BankAccount();
        jonesAccount.AccountName="Mrs.Jones";
        jonesAccount.Balance = 2400;

        WriteLine(format:"{0} earnes {1:C} interest.",

        arg0:jonesAccount.AccountName,
        arg1:jonesAccount.Balance*BankAccount.InterestRate);

        var gerrierAccount = new BankAccount();
        gerrierAccount.AccountName="Mrs.Gerrier";
        gerrierAccount.Balance = 98;

        WriteLine(format:"{0}earnes {1:C} interest.",
        arg0:gerrierAccount.AccountName,
        arg1:gerrierAccount.Balance*BankAccount.InterestRate);

        WriteLine($"{bob.Name} is a {Person.Species}");

        WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

        var blankPerson = new Person();
        WriteLine(format :"{0}  of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
        arg0: blankPerson.Name,
        arg1: blankPerson.HomePlanet,
        arg2:blankPerson.Instantiated);

        var gunny = new Person("Gunny","Mars");
        WriteLine(format:"{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
        arg0: gunny.Name,
        arg1: gunny.HomePlanet,
        arg2: gunny.Instantiated);

        (string, int) fruit = bob.GetFruit();
        WriteLine($"{fruit.Item1},{fruit.Item2} there are.");

    }
} 
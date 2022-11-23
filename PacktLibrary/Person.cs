using System.Collections.Generic;
namespace Packt.Shared;
public class Person
{
 public string? Name;
 public WondersOfTheAncientWorld FavoriteAncientWonder ;
 public WondersOfTheAncientWorld BucketList;
 public DateTime DateOfBirth;
 public List<Person> Children = new List<Person>();  
 public const string Species = "Homo Sapien";
 public readonly string HomePlanet = "Earth";     
 public readonly DateTime Instantiated;
 public Person()
 {
    Name = "Unknow";
    Instantiated=DateTime.Now;
 }
 public Person(string initalName, string homePlanet)
 {
    Name = initalName;
    HomePlanet = homePlanet;
    Instantiated = DateTime.Now;
 }
 public (string,int) GetFruit()
        {
            return("Appeles",5);
        }
}




using System;
using System.Collections.Generic;

namespace lists
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> planetList = new List<string>() { "Mercury", "Mars" };
      planetList.Add("Jupiter");
      planetList.Add("Saturn");

      List<string> extraPlanets = new List<string>() { "Uranus", "Neptune" };
      planetList.AddRange(extraPlanets);
      planetList.Insert(0, "Earth");
      planetList.Insert(3, "Venus");
      planetList.Add("Pluto");

      List<string> rockyPlanets = new List<string>();
      rockyPlanets = planetList.GetRange(2, 3);

      planetList.Remove("Pluto");

      Console.WriteLine("\nplanetList");
      foreach (var item in planetList)
      {
        Console.Write(" ");
        Console.Write(item);
      }
      
      Console.WriteLine("\nrockyPlanets");
      foreach (var item in rockyPlanets)
      {
        Console.Write(" ");
        Console.Write(item);
      }

      Console.WriteLine("\n planetList Length:{0}  \n rockyPlanets Length:{1}", planetList.Count, rockyPlanets.Count);
    
    }
  }
}

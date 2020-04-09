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

    List<string> extraPlanets = new List<string>() { "Earth", "Pluto" };
      planetList.AddRange(extraPlanets);
      Console.WriteLine("");
       foreach (var item in planetList)
      {
        Console.Write(" ");
        Console.Write(item);
      }
    }
  }
}

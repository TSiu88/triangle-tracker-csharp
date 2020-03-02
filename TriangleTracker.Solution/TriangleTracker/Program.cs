using System;
using TriangleTracker.Models;
  public class Program {
    static void Main()
    {
      Console.WriteLine("Determine your triangle type by providing the lengths of the 3 sides.");
      Console.WriteLine("Length of side 1: ");
      string sideOne = Console.ReadLine();
      int sideOneInt = int.Parse(sideOne);
      Console.WriteLine("Length of side 2: ");
      string sideTwo = Console.ReadLine();
      int sideTwoInt = int.Parse(sideTwo);
      Console.WriteLine("Length of side 3: ");
      string sideThree = Console.ReadLine();
      int sideThreeInt = int.Parse(sideThree);
      Triangle t = new Triangle(sideOneInt, sideTwoInt, sideThreeInt);
      t.DetermineType();
      Console.ReadLine();
    }
  }

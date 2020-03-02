using System;

namespace TriangleTracker.Models {
  public class Triangle {
    public int Side1 { get; set;}
    public int Side2 { get; set;}
    public int Side3 { get; set;}

    public Triangle(int s1, int s2, int s3) {
      Side1 = s1;
      Side2 = s2;
      Side3 = s3;
    }

    public void DetermineType() {
      if(DetermineIfTriangle()) {
        if ((Side1 == Side2) && (Side2 == Side3)) {
          Console.WriteLine("Equilaterial triangle");
        } else if ((Side1 == Side2) || (Side2 == Side3) || (Side1 == Side3)) {
          Console.WriteLine("Isosceles triangle");
        } else {
          Console.WriteLine("Scalene triangle");
        }
      } else {
        Console.WriteLine("Not a triangle");
      }
    }

    public bool DetermineIfTriangle() {
      if(((Side1 + Side2) < Side3) || ((Side2 + Side3) < Side1) || ((Side1 + Side3) < Side2)) {
        return false;
      }
      return true;
    }
  }
}
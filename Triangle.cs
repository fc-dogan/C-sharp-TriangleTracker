using System;
using System.Collections.Generic;

public class Triangle
{
  public int Side1;
  public int Side2;
  public int Side3;

  public Triangle(int side1, int side2, int side3)
  {
    Side1 = side1;
    Side2 = side2;
    Side3 = side3;
  }

  public string TriangleChecker(int side1, int side2, int side3)
  {
    
    if ((side1 + side2) < side3 || (side1 + side3) < side2 || (side2 + side3) < side1)
    {
      return "It's not a triangle";
    }
    else if ( side1 == side2 && side1 == side3 && side2 == side3)
    {
      return "Equilateral Triangle";
    }
    else if( side1 == side2 || side1 == side3 || side2 == side3 )
    {
      return "Isosceles Triangle";
    }
    else
    {
      return "Scalene Triangle";
    }
  }
}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter triangle sides to check the type");
    Console.WriteLine("Side 1: ");
    string stringSide1 = Console.ReadLine();
    int intSide1 = int.Parse(stringSide1);

    Console.WriteLine("Side 2: ");
    string stringSide2 = Console.ReadLine();
    int intSide2 = int.Parse(stringSide2);

    Console.WriteLine("Side 3: ");
    string stringSide3 = Console.ReadLine();
    int intSide3 = int.Parse(stringSide3);

    Triangle userTriangle = new Triangle( intSide1, intSide2, intSide3);

    Console.WriteLine(userTriangle.TriangleChecker(intSide1, intSide2, intSide3));
    
      
    
  }
}
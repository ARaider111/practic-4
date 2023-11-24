using System;

class Program 
{
  public static void Main (string[] args) 
  {
    float a = 0, b = 0;
    Console.WriteLine ("Введите координату x точки:");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine ("Введите координату y точки:");
    b = float.Parse(Console.ReadLine());
    
    if( (a > -1 && a < 3) && (b > -2 && b < 4 ) )
    {
      Console.WriteLine($"Точка с координатами ({a};{b}) принадлежит данной заштрихованной плоскости");
    }
    else
    {
      Console.WriteLine($"Точка с координатами ({a};{b}) не принадлежит данной заштрихованной плоскости");
    }
  }
}
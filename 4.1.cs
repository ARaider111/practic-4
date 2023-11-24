using System;

class Program {
  public static void Main (string[] args) 
  {
    int n = 0;
    Console.WriteLine ("Введите число, которое результат не должен привысить: ");
    n = int.Parse(Console.ReadLine());

    int result = 1;
    for (int number = 3; number < n; number += 3)
    {
      result *= number;
    }
    Console.WriteLine($"Произведение равно: {result}");
  }
}
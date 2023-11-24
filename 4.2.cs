using System;
using System.IO;
using System.Collections.Generic;

class Program
{
  public static void Main (string[] args) 
  {
    string numsTask2 = "numsTask2.txt";
    int k = 0;
    
    Console.WriteLine ("Введите количество чисел: ");
    k = int.Parse(Console.ReadLine());
    double[] numbers = new double[k];
    Random rand = new Random();
    try
    {
      for (int i = 0; i < numbers.Length; ++i)
      {
        numbers[i] =  Math.Round(rand.NextDouble() * 20 - 10, 2);
      }

      string stringNumbers = string.Join(";" + " ", numbers);
      using(StreamWriter writer = new StreamWriter(numsTask2))
      {
        writer.WriteLine(stringNumbers);
      }

      using(StreamReader reader = new StreamReader(numsTask2))
      {
        stringNumbers = reader.ReadLine();
        string[] numberStrings = stringNumbers.Split(";" + " ");
        numbers = new double[k];
        for (int j = 0; j < numberStrings.Length; ++j)
        {
          numbers[j] = Convert.ToDouble(numberStrings[j]); 
        }
      }

      
      for (int i = 0; i < numbers.Length; i++)
      {
        for (int j = 0; j < numbers.Length - i - 1; j++)
        {
         if (numbers[j] < numbers[j + 1])
          {
            double temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
          }
        }
      }

      List<double> positiveNumbers = new List<double>();
      for (int i = 0; i < numbers.Length; i++)
      {
        if(numbers[i] > 0)
        {
          positiveNumbers.Add(numbers[i]);
        }
      }
      
      double sum = 0;
      Console.WriteLine("Отсортированный массив: ");
      foreach(double number in positiveNumbers)
      {
        Console.Write(number + "; ");
        if (number > 0)
        {
          sum += number;
        } 
      }
      
      Console.WriteLine();
      Console.WriteLine($"Сумма положительных чисел: {sum:F2}");
    }
    
    catch (FileNotFoundException)
    {
        Console.WriteLine("Файл не найден");
    }
    catch (IOException)
    {
        Console.WriteLine("Ошибка чтения файла или записи в файл");
    }

    finally 
    {
      Console.WriteLine("Нажмите любую клавишу для завершения программы");
      Console.ReadKey();
      File.Delete(numsTask2);
    }
  }
}


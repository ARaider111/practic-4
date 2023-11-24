using System;
using System.IO;
using System.Collections.Generic;

class Program 
{
  public static void Main (string[] args) 
  {
    string numsTask3 = "numsTask3.txt";
    int k = 0;

    Console.WriteLine ("Введите количество чисел: ");
    k = int.Parse(Console.ReadLine());
    int[] numbers = new int[k];
    Random rand = new Random();
    
    try
    {
      for (int i = 0; i < numbers.Length; ++i)
      {
        numbers[i] = rand.Next(-100, 100);
      }

      string stringNumbers = string.Join("," + " ", numbers);
      using(StreamWriter writer = new StreamWriter(numsTask3))
      {
        writer.WriteLine(stringNumbers);
      }

      using(StreamReader reader = new StreamReader(numsTask3))
      {
        stringNumbers = reader.ReadLine();
        string[] numberStrings = stringNumbers.Split("," + " ");
        numbers = new int[k];
        for (int j = 0; j < numberStrings.Length; ++j)
        {
          numbers[j] = int.Parse(numberStrings[j]); 
        }
      }


      for (int i = 0; i < numbers.Length; i++)
      {
        for (int j = 0; j < numbers.Length - i - 1; j++)
        {
         if (numbers[j] < numbers[j + 1])
          {
            int temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
          }
        }
      }

      List<int> positiveNumbers = new List<int>();
      for (int i = 0; i < numbers.Length; i++)
      {
        if(numbers[i] > 0)
        {
          positiveNumbers.Add(numbers[i]);
        }
      }

      int minNum = 100;
      int maxNum = 0;
      Console.WriteLine("Отсортированный массив: ");
      foreach(int number in positiveNumbers)
      {
        Console.Write(number + ", ");
        if(number < minNum)
        {
          minNum = number;
        }

        if (number > maxNum)
        {
          maxNum = number;
        }
      }
      Console.WriteLine();

      float result = (float)minNum / maxNum;
      Console.WriteLine($"Отношение минимального числа к максимальному: {result:F2}");
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
      File.Delete(numsTask3);
    }
  }
}
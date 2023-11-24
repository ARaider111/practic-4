using System;

class Program
{
    static float CalculateTriangleArea(float x1, float y1, float x2, float y2, float x3, float y3)
    {
        return Math.Abs((x1 * y2 + x2 * y3 + x3 * y1 - y1 * x2 - y2 * x3 - y3 * x1) / 2);
    }
  
    static void Main()
    {
        float x1 = 0, y1 = 2;
        float x2 = -2, y2 = -3;
        float x3 = 2, y3 = -3;

        Console.WriteLine("Введите координаты точки (x, y):");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());

        float fullTriangleArea = CalculateTriangleArea(x1, y1, x2, y2, x3, y3);
        float triangleArea1 = CalculateTriangleArea(a, b, x2, y2, x3, y3);
        float triangleArea2 = CalculateTriangleArea(x1, y1, a, b, x3, y3);
        float triangleArea3 = CalculateTriangleArea(x1, y1, x2, y2, a, b);

        if (Math.Abs(fullTriangleArea) == Math.Abs(triangleArea1 + triangleArea2 + triangleArea3))
        {
            Console.WriteLine($"Точка ({a};{b}) принадлежит данной заштрихованной области");
        }
        else
        {
            Console.WriteLine($"Точка ({a};{b}) не принадлежит данной заштрихованной области");
        }
    }
}

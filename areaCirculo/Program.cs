using System;

namespace areaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double area, raio;
            raio = double.Parse(Console.ReadLine());
            area = pi * (raio * raio);
            Console.WriteLine("X = " + Math.Round(area, 4).ToString()); // 3 casas depois da virgula
            Console.ReadLine();

        }
    }
}

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
            Console.WriteLine($"A={area.ToString("F4")}");
            Console.ReadLine();

        }
    }
}

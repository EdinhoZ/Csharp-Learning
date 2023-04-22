using System;

namespace Tutorial1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double comp, larg, area, perimetro;

            Console.Write("Comprimento: ");
            comp = double.Parse(Console.ReadLine());

            Console.Write("Largura: ");
            larg = double.Parse(Console.ReadLine());

            area = comp * larg;
            perimetro = 2 * comp + 2 * larg;

            Console.WriteLine("A área é: " + area);
            Console.WriteLine("O perimetro é: " + perimetro);
            

            Console.ReadKey();
        }
    }
}

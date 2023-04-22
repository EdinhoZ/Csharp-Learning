using System;

namespace Tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            string nome;

            Console.WriteLine("Introduza o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Introduza a 1ªNota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduza a 2ªNota: ");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;
            Console.WriteLine("A média é: " + media);

            Console.ReadKey();
        }
    }
}

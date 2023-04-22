using System;

namespace Tutorial4
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2;
            string nome1, nome2;

            Console.Write("Nome do 1º aluno: ");
            nome1 = Console.ReadLine();

            Console.Write("Nome do 2º aluno: ");
            nome2 = Console.ReadLine();

            Console.Write("Idade do 1ºaluno: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.Write("Idade do 2ºaluno: ");
            idade2 = int.Parse(Console.ReadLine());

            if (idade1 > idade2)
                Console.WriteLine("O aluno mais velho é: " + nome1 + " com " + idade1 + " anos.");
            else
                Console.WriteLine("O aluno mais velho é: " + nome2 + " com " + idade2 + " anos.");

            Console.ReadKey();

        }
    }
}

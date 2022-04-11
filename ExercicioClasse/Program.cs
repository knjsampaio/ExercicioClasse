using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.Write("Insira o nome do primeiro usuário:");
            p1.nome = Console.ReadLine();
            Console.Write("Insira a idade do primeiro usuário:");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Insira o nome do segundo usuário:");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Insira a idade do segundo usuário:");
            p2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine($" O nome do primeiro usuário é {p1.nome} e a idade é {p1.idade}. ");
            Console.WriteLine($" O nome do segundo usuário é {p2.nome} e a idade é {p2.idade}. ");

            if (p1.idade > p2.idade)
            {
                Console.WriteLine($"O primeiro usuário {p1.nome} é mais velho que o segundo usuário {p2.nome}.");
            }
            else
            {
                Console.WriteLine($"O segundo usuário {p2.nome} é mais velho que o primeiro usuário {p1.nome}.");
            }
            Console.ReadKey();
        }
    }
}

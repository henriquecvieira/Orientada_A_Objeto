using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Media
    {
        public static void Aluno()
        {
            Console.WriteLine("\nDigite o nome do Aluno");
            string nome = Console.ReadLine();
            Console.WriteLine("\n");
            decimal qtdNotas = 3;
            Console.WriteLine("Digite as " + qtdNotas + " notas do aluno " + nome);
            Console.WriteLine("\n");

            List<decimal> notas = new List<decimal>();
            decimal totalNotas = 0;
            for (decimal i = 1; i <= qtdNotas; i++)

            {
                Console.WriteLine("Digite a nota número " + i);
                decimal nota = decimal.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }

            decimal media = totalNotas / notas.Count;
            Console.WriteLine("as notas do " + nome + " são:\n");
            foreach (decimal nota in notas)
            {
                Console.WriteLine("Nota:  " + nota + "\n");
            }

            Console.WriteLine("A Média do  " + nome + " é " + media.ToString("0.0000"));

        }
    }
}

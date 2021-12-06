using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;

        public static void Criar()
        {
            while (true)
            {
                string mensagem = "\n " +
                    "\n    Olá, bem vindo!\n" +
                    "\n    Estamos utilizando a programação funcional" +
                    "\n\n" +
                    "\n    Digite uma das opções abaixo:" +
                    "\n    0 - Para sair do programa" +
                    "\n    1 - Para Ler arquivo" +
                    "\n    2 - Para executar a tabuada" +
                    "\n    3 - Calcular média dos alunos";
                Console.WriteLine(mensagem);

                Console.WriteLine("\n");


                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("\n");
                    Arquivo.Ler(1);
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Digite o número que deseja na tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.Aluno();
                    Console.WriteLine("\n=========\n");

                }
                else
                {
                    Console.WriteLine("     DIGITE NOVAMENTE");
                }

            }

        }
        
    }
}

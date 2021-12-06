using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{
    class Arquivo
    {

        private static string CaminhoArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivo"];
        }

        
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = ConfigurationManager.AppSettings["CaminhoArquivo"] + "arq" + numeroArquivo + ".txt ";
            Console.WriteLine("==== Lendo Arquivo ====\n" + "  " + arquivoComCaminho + "\n");
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);

                    }
                    Console.WriteLine("===================");
                }

                string arquivoComCaminho2 = ConfigurationManager.AppSettings["caminho_arquivos"] + "arq" + (numeroArquivo + 1) + ".txt";


                if (File.Exists(arquivoComCaminho2))
                {
                    Arquivo.Ler(numeroArquivo + 1);
                }

            }


        }

    }
}

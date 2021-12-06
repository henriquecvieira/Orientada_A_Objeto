using Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace OrientadaFuncao
{
        class Program
        {       
            static void Main(string[] args)
            {
            //Menu.Criar();

            var clientes = Cliente.LerClientes();

            Cliente.Teste = "sss";

            var cliente = new Cliente();
            cliente.Nome = "Arthur";
            cliente.Telefone = "1194656132";
            cliente.CPF = "214535986532";
            cliente.Gravar();

            Cliente c = new Cliente();
            
            var cliente2 = new Cliente();
            cliente2.Nome = "Aurora";
            cliente2.Telefone = "1195465498";
            cliente2.CPF = "32165486532";
            cliente2.Gravar();
                   

            }

        }

}



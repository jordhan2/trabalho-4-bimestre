using System;
using System.Collections.Generic;

namespace trab_4_bimestre_exer_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<fornecedor> cadastro = new List<fornecedor>();
            string continuar = "S";
           


            while (continuar.ToUpper() == "S")
            {
                Console.WriteLine("SEJA BEM VINDO A TELA DE CADASTRO: ");
                var cad = new fornecedor();

                

                Console.WriteLine("Digite seu nome: ");
                cad.nome = Console.ReadLine();

                Console.WriteLine("Digite seu CNPJ: ");
                cad.cnpj = Console.ReadLine();

                Console.WriteLine("Digite seu RG: ");
                cad.rg = Console.ReadLine();

                Console.WriteLine("Digite sua cidade: ");
                cad.cidade = Console.ReadLine();

                Console.WriteLine("Digite seu Estado: ");
                cad.estado = Console.ReadLine();

                Console.WriteLine("Digite seu Bairro: ");
                cad.bairro = Console.ReadLine();

                Console.WriteLine("Digite seu codigo de acesso: ");
                cad.codigo = Console.ReadLine();

                Console.WriteLine("Digite a Área de atuação: ");
                cad.area = Console.ReadLine();

                Console.WriteLine("Digite sua definição de trabalho: ");
                cad.definicao = Console.ReadLine();

                Console.WriteLine("Digite sua Habitualidade: ");
                cad.habitualidade = Console.ReadLine();

                cadastro.Add(cad);

                Console.WriteLine("Deseja continuar [S] ou [N] ?: ");
                continuar = Console.ReadLine();

            }
            cadastro.Sort();
            Console.WriteLine("\n\n Apresentação dos nomes em Ordem Alfabetica: ");
            apresentardados(cadastro);
        }

        private static void apresentardados(List<fornecedor> cadastro)

        {
            foreach (var item in cadastro)
            {
                Console.WriteLine("\n\n*****************************");
                Console.WriteLine("Nome: " + item.nome);
                Console.WriteLine("CNPJ: " + item.cnpj);
                Console.WriteLine("RG: " + item.rg);
                Console.WriteLine("Cidade: " + item.cidade);
                Console.WriteLine("Estado: " + item.estado);
                Console.WriteLine("Bairro: " + item.bairro);
                Console.WriteLine("Codigo: " + item.codigo);
                Console.WriteLine("Area: " + item.area);
                Console.WriteLine("Definição: " + item.definicao);
                Console.WriteLine("Habitualidade: " + item.habitualidade);

            }
          
        }
    }
}

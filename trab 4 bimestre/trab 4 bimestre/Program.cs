using System;
using System.Collections.Generic;

namespace trab_4_bimestre
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produtos> mercado = new List<Produtos>();
            string continuar = "S";
            string incluir, sair;
            int escolha = 0;
            string consult;
            int consultar = 0;
            string cont;
            
            while (escolha != 3)
            {
                Console.WriteLine("Digite [1] - incluir [2] consultar [3] sair");
                escolha = Convert.ToInt32(Console.ReadLine());
                cont = "S";
                
                if (escolha == 1)
                {
                    while (cont.ToUpper() == "S")
                    {


                        var merc = new Produtos();

                        Console.WriteLine("Digite o nome do produto: ");
                        merc.nome = Console.ReadLine();

                        Console.WriteLine("Digite o codigo do produto: ");
                        merc.codigo = Console.ReadLine();

                        Console.WriteLine("Digite o preço do produto: ");
                        merc.preco = Console.ReadLine();

                        Console.WriteLine("Digite a validade do produto: ");
                        merc.validade = Console.ReadLine();

                        Console.WriteLine("Digite o nome do fornecedor: ");
                        merc.fornecedor = Console.ReadLine();

                        Console.WriteLine("Digite o nome da marca do produto: ");
                        merc.marca = Console.ReadLine();

                        Console.WriteLine("Digite o nome do estoque: ");
                        merc.estoque = Console.ReadLine();

                        Console.WriteLine("Digite a cor do produto: ");
                        merc.cor = Console.ReadLine();

                        Console.WriteLine("Digite o lote do produto: ");
                        merc.lote = Console.ReadLine();

                        Console.WriteLine("Digite a pratilheira do produto: ");
                        merc.pratilheira = Console.ReadLine();

                        mercado.Add(merc);

                        Console.WriteLine("Deseja continuar [S] ou [N]: ");
                        cont = Console.ReadLine();
                    }

                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Consultar por [1] nome\n - [2] codigo\n - [3] preço\n - [4] fornecedor\n - [5] marca\n");
                    consultar = Convert.ToInt32(Console.ReadLine());

                    if (consultar == 1)
                    {
                        Console.WriteLine("Digite o nome do produto: ");
                        consult = Console.ReadLine();
                        foreach (var item in mercado)
                        {
                            if (consult == item.nome)
                            {
                                Console.WriteLine("nome do produto: " + item.nome);
                                Console.WriteLine("codigo do produto: " + item.codigo);
                                Console.WriteLine("preço do produto: " + item.preco);
                                Console.WriteLine("validade do produto: " + item.validade);
                                Console.WriteLine("O fornecedor: " + item.fornecedor);
                                Console.WriteLine("A marca do produto: " + item.marca);
                                Console.WriteLine("estoque: " + item.estoque);
                                Console.WriteLine("cor do produto: " + item.cor);
                                Console.WriteLine("lote do produto: " + item.lote);
                                Console.WriteLine("pratilheira do produto: " + item.pratilheira);

                            }
                            else
                            {
                                Console.WriteLine("nome nao encontrado: ");
                            }
                        }
                    }
                    else if (consultar == 2)
                    {
                        Console.WriteLine("Digite o codigo do produto: ");
                        consult = Console.ReadLine();
                        foreach (var item in mercado)
                        {
                            if (consult == item.codigo)
                            {
                                Console.WriteLine("nome do produto: " + item.nome);
                                Console.WriteLine("codigo do produto: " + item.codigo);
                                Console.WriteLine("preço do produto: " + item.preco);
                                Console.WriteLine("validade do produto: " + item.validade);
                                Console.WriteLine("O fornecedor: " + item.fornecedor);
                                Console.WriteLine("A marca do produto: " + item.marca);
                                Console.WriteLine("estoque: " + item.estoque);
                                Console.WriteLine("cor do produto: " + item.cor);
                                Console.WriteLine("lote do produto: " + item.lote);
                                Console.WriteLine("pratilheira do produto: " + item.pratilheira);

                            }
                            else
                            {
                                Console.WriteLine("codigo do produto não encontrado: ");
                            }
                        }
                    }
                    else if (consultar == 3)
                    {
                        Console.WriteLine("Digite o preço do produto: ");
                        consult = Console.ReadLine();
                        foreach (var item in mercado)
                        {
                            if (consult == item.preco)
                            {
                                Console.WriteLine("nome do produto: " + item.nome);
                                Console.WriteLine("codigo do produto: " + item.codigo);
                                Console.WriteLine("preço do produto: " + item.preco);
                                Console.WriteLine("validade do produto: " + item.validade);
                                Console.WriteLine("O fornecedor: " + item.fornecedor);
                                Console.WriteLine("A marca do produto: " + item.marca);
                                Console.WriteLine("estoque: " + item.estoque);
                                Console.WriteLine("cor do produto: " + item.cor);
                                Console.WriteLine("lote do produto: " + item.lote);
                                Console.WriteLine("pratilheira do produto: " + item.pratilheira);

                            }
                            else
                            {
                                Console.WriteLine("preço do produto não encontrado: ");
                            }
                        }
                    }
                    else if (consultar == 4)
                    {
                        Console.WriteLine("Digite o fornecedor: ");
                        consult = Console.ReadLine();
                        foreach (var item in mercado)
                        {
                            if (consult == item.fornecedor)
                            {
                                Console.WriteLine("nome do produto: " + item.nome);
                                Console.WriteLine("codigo do produto: " + item.codigo);
                                Console.WriteLine("preço do produto: " + item.preco);
                                Console.WriteLine("validade do produto: " + item.validade);
                                Console.WriteLine("O fornecedor: " + item.fornecedor);
                                Console.WriteLine("A marca do produto: " + item.marca);
                                Console.WriteLine("estoque: " + item.estoque);
                                Console.WriteLine("cor do produto: " + item.cor);
                                Console.WriteLine("lote do produto: " + item.lote);
                                Console.WriteLine("pratilheira do produto: " + item.pratilheira);

                            }
                            else
                            {
                                Console.WriteLine("nome do fornecedor não encontrado: ");
                            }
                        }
                    }
                    else if (consultar == 5)
                    {
                        Console.WriteLine("Digite a marca: ");
                        consult = Console.ReadLine();
                        foreach (var item in mercado)
                        {
                            if (consult == item.marca)
                            {
                                Console.WriteLine("nome do produto: " + item.nome);
                                Console.WriteLine("codigo do produto: " + item.codigo);
                                Console.WriteLine("preço do produto: " + item.preco);
                                Console.WriteLine("validade do produto: " + item.validade);
                                Console.WriteLine("O fornecedor: " + item.fornecedor);
                                Console.WriteLine("A marca do produto: " + item.marca);
                                Console.WriteLine("estoque: " + item.estoque);
                                Console.WriteLine("cor do produto: " + item.cor);
                                Console.WriteLine("lote do produto: " + item.lote);
                                Console.WriteLine("pratilheira do produto: " + item.pratilheira);

                            }
                            else
                            {
                                Console.WriteLine("marca do produto não encontrada: ");
                            }
                        }
                    }
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("você saiu e aqui está os produtos cadastrados: ");
                    
                    foreach (var item in mercado)
                    {
                        Console.WriteLine("nome do produto: " + item.nome);
                        Console.WriteLine("codigo do produto: " + item.codigo);
                        Console.WriteLine("preço do produto: " + item.preco);
                        Console.WriteLine("validade do produto: " + item.validade);
                        Console.WriteLine("O fornecedor: " + item.fornecedor);
                        Console.WriteLine("A marca do produto: " + item.marca);
                        Console.WriteLine("estoque: " + item.estoque);
                        Console.WriteLine("cor do produto: " + item.cor);
                        Console.WriteLine("lote do produto: " + item.lote);
                        Console.WriteLine("pratilheira do produto: " + item.pratilheira);
                    }
                }
                else
                {
                    Console.WriteLine("OPERAÇÃO INVALIDA: ");
                }
            }
            
        }
    }
}

using System;

namespace trab_4_bimestre_1_exer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2,2];
            int soma = 0;
            int maior = 0;
            int menor = 0;

            for (int linha= 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("Digite um Valor para linha: "+ linha + "coluna: "+ coluna + " = ");
                    array[linha, coluna] = Convert.ToInt32(Console.ReadLine());

                }
            }
            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    soma += array[linha, coluna];
                    if (maior < 0)
                    {
                        maior = array[linha, coluna];
                    }
                    else if(maior < array[linha, coluna])
                    {
                        maior = array[linha, coluna];
                    }
                    if (menor == 0)
                    {
                        menor = array[linha, coluna];
                    }
                    else if (menor > array[linha, coluna])
                    {
                        menor = array[linha, coluna];
                    }
                }

            }
            Console.WriteLine("resultado da Media: = " + soma.ToString());
            Console.WriteLine("O maior numero é: " + maior);
            Console.WriteLine("O menor numero é: " + menor);
        }
    }
}

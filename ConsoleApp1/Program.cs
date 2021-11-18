using IronPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe a quantidade de linhas: ");
                int linhas = int.Parse(Console.ReadLine());
                Console.Write("Informe a quantidade de colunas: ");
                int colunas = int.Parse(Console.ReadLine());

                int[,] mat = new int[linhas, colunas];

                for (int i = 0; i < linhas; i++)
                {
                    Console.Write("Informe uma sequencia de números: ");
                    string[] values = Console.ReadLine().Split(' ');
                    for (int j = 0; j < colunas; j++)
                    {
                        mat[i, j] = int.Parse(values[j]);
                    }
                }

                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                string continua = "S";

                while (continua != "N")
                {
                    Console.Write("Informe um número da sequencia: ");
                    int numero = int.Parse(Console.ReadLine());

                    for (int i = 0; i < linhas; i++)
                    {
                        for (int j = 0; j < colunas; j++)
                        {
                            if (mat[i, j] == numero)
                            {
                                Console.WriteLine("Encontrado na posição: " + i.ToString() + "," + j.ToString());

                                if (j - 1 >= 0)
                                    Console.WriteLine("Esquerda: " + mat[i, j - 1]);

                                if (j + 1 <= colunas - 1)
                                    Console.WriteLine("Direita: " + mat[i, j + 1]);

                                if (i + 1 <= linhas - 1)
                                    Console.WriteLine("Embaixo: " + mat[i + 1, j]);

                                if (i - 1 >= 0)
                                    Console.WriteLine("Acima: " + mat[i - 1, j]);
                            }
                        }
                    }

                    Console.Write("Deseja continuar? ");
                    continua = Console.ReadLine().ToUpper();
                }                
            }
            catch (Exception ex)
            {

                Console.Write("Erro: " + ex.Message);
                Console.ReadKey();
            }
        }
    }
}

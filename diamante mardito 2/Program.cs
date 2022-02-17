using System;

namespace diamante_mardito_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //É Dado uma letra ('A' a 'Z'), exiba um diamante iniciando em 'A' e tendo a letra fornecida com o
            //ponto mais distante.

            int tamanhoDiamante, opcao;
            
            while (true)
            {
                Console.WriteLine("\nDesafio diamante X Academia do Programador");
                Console.WriteLine(" Digite 1 para desenhar um diamante em X ");
                Console.WriteLine(" Digite 2 para sair do programa");

                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 2)
                {
                    Environment.Exit(0);
                }
                if (opcao == 1)
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Digite o tamanho do diamante: ");
                tamanhoDiamante = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                int quantidadeEspacos = (tamanhoDiamante - 1) / 2;
                int alfabeto = 1;
                
                int quantidadeDeLinhasSuperior = (tamanhoDiamante - 1) / 2;
                int quantidadeDeLinhasInferior = (tamanhoDiamante - 1) / 2;

                if (tamanhoDiamante % 2 == 0)
                {
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Por favor digite um número Impar");
                    Console.WriteLine(" ");
                    Console.ResetColor();
                    continue;
                }
                for (int linha = 0; linha < quantidadeDeLinhasSuperior; linha++)
                {
                    for (int i = 0; i < quantidadeEspacos; i++)
                    {
                        Console.Write(" ");
                    }
                    for (int i = 0; i < alfabeto; i++)
                    {
                        Console.Write("X");
                    }

                    quantidadeEspacos--;
                    alfabeto += 2;

                    Console.WriteLine(" ");
                }

                for (int coluna = 0; coluna < tamanhoDiamante; coluna++)
                {
                    Console.Write("X");

                }

                quantidadeEspacos++;
                alfabeto -= 2;
                Console.WriteLine(" ");

                for (int linha = 0; linha < quantidadeDeLinhasInferior; linha++)
                {
                    for (int i = 0; i < quantidadeEspacos; i++)
                    {
                        Console.Write(" ");
                    }
                    for (int i = 0; i < alfabeto; i++)
                    {
                        Console.Write("X");
                    }
                    quantidadeEspacos++;
                    alfabeto -= 2;
                    Console.WriteLine(" ");
                }
                Console.ResetColor();
                Console.ReadLine();  
            }

        }
    }
}
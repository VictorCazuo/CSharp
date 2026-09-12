using System;

namespace BoletimEscolar
{
    class Program
    {
        static void Main()
        {
            /// <summary>
            /// Desafio: Boletim Escolar (Arrays Paralelos)
            /// Objetivo: Treinar a entrada de dados do usuário, armazenamento em arrays paralelos e cálculos de agregação.
            /// Requisitos: 
            /// 1. Criar dois arrays de tamanho 5: um para nomes e outro para notas.
            /// 2. Solicitar ao usuário que digite os 5 nomes e as 5 notas.
            /// 3. Exibir a lista de alunos com suas respectivas notas.
            /// 4. Calcular e exibir a média geral da turma.
            /// </summary>

            Console.WriteLine("=== SISTEMA DE BOLETIM ESCOLAR ===\n");

            string[] nomes = new string[5];
            double[] notas = new double[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Digite o {i + 1}° nome: ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine(); 

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Digite a nota de {nomes[i]}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\n--- Relatório de Notas ---");
            Console.WriteLine($"{"Aluno",-15} | {"Nota"}");
            Console.WriteLine(new string('-', 25));

            double soma = 0;

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"{nomes[i],-15} | {notas[i]:F1}");
                soma += notas[i];
            }

            double media = soma / notas.Length;

            Console.WriteLine(new string('-', 25));
            Console.WriteLine($"Média Geral da Turma: {media:F2}");
        }
    }
}
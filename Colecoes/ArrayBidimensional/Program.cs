using System;

namespace ArraysEMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PORTFÓLIO DE ARRAYS E MATRIZES ===\n");

            Desafio1Teatro();
            Console.WriteLine(new string('-', 40));

            Desafio2Alunos();
            Console.WriteLine(new string('-', 40));

            Desafio3Faturas();
            Console.WriteLine(new string('-', 40));

            Desafio4JanelaDeslizante();
        }

        /// <summary>
        /// Desafio 1: Mapeamento de Assentos (Matriz 2D)
        /// Objetivo: Criar um sistema de representação visual de um teatro usando matrizes bidimensionais ([,]).
        /// Requisitos: Inicializar uma matriz de 3 linhas e 4 colunas preenchida com a letra "L" (Livre). 
        /// Em seguida, simular a reserva de um assento específico alterando a posição [1, 2] para "X" (Ocupado) e imprimir.
        /// </summary>
        static void Desafio1Teatro()
        {
            Console.WriteLine("--- Desafio 1: Mapeamento de Assentos ---");
            string[,] teatro = new string[3, 4];

            for (int linha = 0; linha < teatro.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < teatro.GetLength(1); coluna++)
                {
                    teatro[linha, coluna] = "L";
                }
            }

            teatro[1, 2] = "X";

            for (int linha = 0; linha < teatro.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < teatro.GetLength(1); coluna++)
                {
                    Console.Write(teatro[linha, coluna] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Desafio 2: Grade de Alunos (Matriz Dinâmica)
        /// Objetivo: Praticar a inserção de dados pelo usuário dentro de uma matriz bidimensional.
        /// Requisitos: Criar uma matriz de 2 linhas e 5 colunas. Utilizar laços aninhados para solicitar 
        /// o nome de cada aluno e alocá-lo. Ao final, exibir a grade completa organizada.
        /// </summary>
        static void Desafio2Alunos()
        {
            Console.WriteLine("\n--- Desafio 2: Grade de Alunos ---");
            string[,] alunos = new string[2, 5];

            for (int linha = 0; linha < alunos.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < alunos.GetLength(1); coluna++)
                {
                    Console.Write($"Digite o nome do aluno da linha {linha}, coluna {coluna}: ");
                    alunos[linha, coluna] = Console.ReadLine();
                }
            }

            Console.WriteLine("\nGrade Final:");
            for (int linha = 0; linha < alunos.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < alunos.GetLength(1); coluna++)
                {
                    Console.Write(alunos[linha, coluna] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Desafio 3: Fechamento de Faturas (O Problema do Two Sum)
        /// Objetivo: Encontrar dois valores dentro de um array que somados resultem em um alvo específico.
        /// Requisitos: Solicitar o tamanho do array e o "valor alvo". Utilizar laços aninhados para cruzar 
        /// os dados e encontrar os índices da dupla que atinge a soma, interrompendo a busca em seguida.
        /// </summary>
        static void Desafio3Faturas()
        {
            Console.WriteLine("\n--- Desafio 3: Fechamento de Faturas (Two Sum) ---");
            Console.Write("Digite a quantidade de itens que terão seu array: ");
            int quantArray = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor alvo: ");
            int alvo = Convert.ToInt32(Console.ReadLine());

            int[] faturas = new int[quantArray];
            bool parEncontrado = false;

            for (int i = 0; i < faturas.Length; i++)
            {
                Console.Write($"Digite o {i + 1}° valor: ");
                faturas[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int x = 0; x < faturas.Length; x++)
            {
                for (int y = x + 1; y < faturas.Length; y++)
                {
                    int soma = faturas[x] + faturas[y];
                    if (soma == alvo)
                    {
                        Console.WriteLine($"\nOs valores que somados dão {alvo} estão nos índices {x} e {y}");
                        parEncontrado = true;
                        break;
                    }
                }
                if (parEncontrado)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Desafio 4: Análise de Tráfego (Algoritmo de Janela Deslizante)
        /// Objetivo: Encontrar o pico de acessos consecutivos usando Sliding Window.
        /// Requisitos: Solicitar total de dias e tamanho da janela. O algoritmo deve calcular a primeira 
        /// janela e depois "deslizar" (subtraindo o índice que sai e somando o que entra), otimizando a performance.
        /// </summary>
        static void Desafio4JanelaDeslizante()
        {
            Console.WriteLine("\n--- Desafio 4: Análise de Tráfego (Sliding Window) ---");
            Console.Write("Digite a quantidade de acessos (Tamanho do Array): ");
            int quantidadeDeAcessos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade de dias consecutivos (Tamanho da Janela): ");
            int diasConsecutivos = Convert.ToInt32(Console.ReadLine());

            if (diasConsecutivos > quantidadeDeAcessos)
            {
                Console.WriteLine("A janela não pode ser maior que o total de dias.");
                return;
            }

            int[] acessos = new int[quantidadeDeAcessos];
            for (int i = 0; i < acessos.Length; i++)
            {
                Console.Write($"Digite o {i + 1}° valor: ");
                acessos[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nArray de comparação: ");
            for (int x = 0; x < acessos.Length; x++)
            {
                Console.Write($"{acessos[x]} ");
            }
            Console.WriteLine();

            int maiorSoma = 0;
            int somaAtual = 0;

            for (int i = 0; i < diasConsecutivos; i++)
            {
                somaAtual += acessos[i];
            }
            maiorSoma = somaAtual;

            for (int i = diasConsecutivos; i < acessos.Length; i++)
            {
                somaAtual = somaAtual - acessos[i - diasConsecutivos] + acessos[i];

                if (somaAtual > maiorSoma)
                {
                    maiorSoma = somaAtual;
                }
            }

            Console.WriteLine($"\nA maior soma em {diasConsecutivos} dias consecutivos é: {maiorSoma}");
        }
    }
}
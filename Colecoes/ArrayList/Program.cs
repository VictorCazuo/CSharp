using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Exercício 1 ---");
        Exercicio1();

        Console.WriteLine("\n--- Exercício 2 ---");
        Exercicio2();

        Console.WriteLine("\n--- Exercício 3 ---");
        Exercicio3();

        Console.WriteLine("\n--- Exercício 4 ---");
        Exercicio4();
    }

    // Exercício 1: Simular uma fila de banco usando ArrayList. 
    // Adicionar pessoas, inserir uma prioridade, remover itens específicos e listar o resultado.
    static void Exercicio1()
    {
        ArrayList fila = new ArrayList();

        fila.Add("Ana");
        fila.Add("Bruno");
        fila.Add("Carlos");

        fila.Insert(0, "Senhor João");

        fila.Remove("Bruno");
        fila.RemoveAt(0);

        foreach (string pessoa in fila)
        {
            Console.WriteLine(pessoa);
        }
    }

    // Exercício 2: Receber um array de pontos, passar para um ArrayList, 
    // ordenar de forma crescente e depois inverter para a ordem decrescente.
    static void Exercicio2()
    {
        int[] pontosSemana = { 450, 920, 150, 880, 550 };
        ArrayList ranking = new ArrayList();

        ranking.AddRange(pontosSemana);

        Console.WriteLine("\nLista padrão\n");
        foreach (int ponto in ranking)
        {
            Console.Write($"{ponto} ");
        }

        ranking.Sort();
        Console.WriteLine("\nLista ordenada\n");
        foreach (int ponto in ranking)
        {
            Console.Write($"{ponto} ");
        }

        ranking.Reverse();
        Console.WriteLine("\nLista inversa\n");
        foreach (int ponto in ranking)
        {
            Console.Write($"{ponto} ");
        }

        Console.WriteLine(); 
    }

    // Exercício 3: Varrer um ArrayList com tipos de dados variados (string, int, double, bool) 
    // e somar apenas os valores numéricos, validando os tipos de dados.
    static void Exercicio3()
    {
        ArrayList dadosBaguncados = new ArrayList() { 101, "Teclado Mecânico", 250.50, true };
        double soma = 0;

        foreach (var dado in dadosBaguncados)
        {
            if (dado is int numeroInt)
            {
                soma += numeroInt;
            }
            else if (dado is double numeroDouble)
            {
                soma += numeroDouble;
            }
        }

        Console.WriteLine(soma);
    }

    // Exercício 4: Usar recursividade para navegar em um ArrayList que contém
    // outros ArrayLists aninhados e somar todos os números inteiros encontrados.
    static void Exercicio4()
    {
        ArrayList labirinto = new ArrayList()
        {
            10,
            "Lixo",
            new ArrayList
            {
                20,
                30,
                new ArrayList
                {
                    40,
                    "Ignorar",
                    50
                }
            },
            60
        };

        int resultado = somarLabirinto(labirinto);
        Console.WriteLine(resultado);
    }

    static int somarLabirinto(ArrayList lista)
    {
        int total = 0;

        foreach (var item in lista)
        {
            if (item is int numero)
            {
                total += numero;
            }
            else if (item is ArrayList arraylist)
            {
                total += somarLabirinto(arraylist);
            }
        }
        return total;
    }
}
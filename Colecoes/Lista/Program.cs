using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Exercício 1: O Inventário do RPG ---");
        Exercicio1();

        Console.WriteLine("\n--- Exercício 2: O Alarme do Sensor ---");
        Exercicio2();

        Console.WriteLine("\n--- Exercício 3: A Fusão de Servidores ---");
        Exercicio3();
    }

    // Exercício 1: Simular uma mochila de RPG usando List<string>.
    // Adicionar itens iniciais, inserir um item em uma posição específica,
    // remover um item pelo nome e exibir a quantidade total e os itens restantes.
    static void Exercicio1()
    {
        List<string> mochila = new List<string>() { "Espada", "Escudo", "Poção" };

        mochila.Insert(1, "Mapa");
        mochila.Remove("Poção");

        Console.WriteLine($"Total de itens: {mochila.Count}");

        foreach (string item in mochila)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine(); // Quebra de linha para organizar o console
    }

    // Exercício 2: Filtrar dados críticos usando expressões Lambda (Predicados).
    // Checar a existência de temperaturas acima de 40.0, criar uma nova lista 
    // apenas com temperaturas baixas e remover os valores críticos da lista original.
    static void Exercicio2()
    {
        List<double> temperatura = new List<double>() { 35.5, 42.1, 38.0, 15.2, 45.0, 39.9 };

        bool existe = temperatura.Exists(x => x > 40.0);
        if (existe)
        {
            Console.WriteLine("Perigo: Superaquecimento!");
        }

        List<double> temperaturasBaixas = temperatura.FindAll(x => x < 36.0);

        Console.WriteLine("Temperaturas baixas encontradas:");
        foreach (double t in temperaturasBaixas)
        {
            Console.Write($"{t} ");
        }
        Console.WriteLine(); 

        temperatura.RemoveAll(x => x > 40.0);
    }

    // Exercício 3: Unificar dois lotes de dados simulando servidores distintos.
    // Usar AddRange para mesclar, Sort para ordenar de forma crescente, 
    // e realizar o processamento matemático com tipo fortemente definido.
    static void Exercicio3()
    {
        List<int> loteA = new List<int>() { 50, 10, 30 };
        List<int> loteB = new List<int>() { 20, 60, 40 };

        loteA.AddRange(loteB);
        loteA.Sort();

        int soma = 0;

        Console.WriteLine("Lote unificado e ordenado:");
        foreach (int lote in loteA)
        {
            Console.Write($"{lote} ");
            soma += lote;
        }

        Console.WriteLine($"\nA soma de todos os lotes é = {soma}");
    }
}



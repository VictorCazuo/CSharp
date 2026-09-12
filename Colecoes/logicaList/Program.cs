using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- TICKET 1: A Lista de Compras ---");
        Exercicio1();

        Console.WriteLine("\n--- TICKET 2: O Placar do Jogo ---");
        Exercicio2();

        Console.WriteLine("\n--- TICKET 3: A Catraca do Parque ---");
        Exercicio3();
    }

    // Exercício 1: Operações básicas de manipulação de List<T> (Add, Insert, Remove, Count)
    static void Exercicio1()
    {
        List<string> compras = new List<string>();

        compras.Add("Arroz");
        compras.Add("Feijão");
        compras.Add("Macarrão");

        compras.Insert(0, "Café");
        compras.Remove("Macarrão");

        Console.WriteLine($"Você possui {compras.Count} itens em seu carrinho");
        Console.WriteLine("Itens:");

        foreach (string item in compras)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine(); 
    }

    // Exercício 2: Trabalhando com lotes de dados (AddRange) e ordenação (Sort, Reverse)
    static void Exercicio2()
    {
        // Crio a lista de tipo inteiro com valores iniciados
        List<int> pontuacoes = new List<int>() { 50, 10, 80 };

        Console.WriteLine("Lista Original");
        retornaListaPontuacoes(pontuacoes);

        // Crio um array de inteiros e adiciono à minha lista
        int[] novasPontuacoes = { 20, 90, 30 };
        pontuacoes.AddRange(novasPontuacoes);

        Console.WriteLine("Lista depois de adicionar o array");
        retornaListaPontuacoes(pontuacoes);

        Console.WriteLine("Lista ordenada:");
        pontuacoes.Sort();
        retornaListaPontuacoes(pontuacoes);

        Console.WriteLine("Lista ordenada do maior pro menor:");
        pontuacoes.Sort();
        pontuacoes.Reverse();
        retornaListaPontuacoes(pontuacoes);
    }

    // Exercício 3: Utilizando Expressões Lambda (=>) para buscas e remoções (FindAll, Exists, RemoveAll)
    static void Exercicio3()
    {
        List<int> idades = new List<int>() { 10, 15, 22, 18, 30, 8, 45 };

        Console.WriteLine("Maiores de idade:");
        List<int> maioresDeIdade = idades.FindAll(i => i >= 18);
        foreach (int idade in maioresDeIdade)
        {
            Console.Write($"{idade} ");
        }
        Console.WriteLine(); 


        bool temIdoso = maioresDeIdade.Exists(i => i >= 65);
        if (temIdoso)
        {
            Console.WriteLine($"\nTem idoso: {temIdoso}");
        }
        else
        {
            Console.WriteLine($"\nNão tem idoso: {temIdoso}");
        }

        Console.WriteLine("\nLista de idades permitidas no parque infantil:");
        idades.RemoveAll(i => i < 12);
        foreach (int idade in idades)
        {
            Console.Write($"{idade} ");
        }
        Console.WriteLine(); 
    }

    // Método auxiliar estático para evitar repetição de código no Exercício 2 
    static void retornaListaPontuacoes(List<int> pontuacoes)
    {
        foreach (int ponto in pontuacoes)
        {
            Console.Write($"{ponto} ");
        }
        Console.WriteLine("\n");
    }

}
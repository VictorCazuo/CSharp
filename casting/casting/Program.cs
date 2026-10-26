using System.Collections.Generic;
using casting;

//Exercicio 1 do gato
Console.WriteLine("Exercicio 1\n");


Gato gato1 = new Gato();
gato1.Nome = "Garfield";

Animal animal1 = gato1; //upcasting - eu transformo minha classe derivada em classe base

Gato gato2 = (Gato)animal1; //downcasting - eu converto a minha classe base em classe derivada e armazeno em uma variável do tipo da classe derivada

gato2.ArranharSofa(); //agora eu consigo acessar o método :)

Console.WriteLine("\n");

//Exercicio 2 da Assistência Técnica
Console.WriteLine("Exercicio 2");

List<Eletronico> Eletronicos = new List<Eletronico>();

Eletronico c1 = new Celular { Marca = "Samsung", NumeroLinha = "tab 3" };
Eletronico c2 = new Celular { Marca = "Apple", NumeroLinha = "13 pro max" };
Eletronico t1 = new Televisao { Marca = "Samsung", Polegadas = 25 };
Eletronico t2 = new Televisao { Marca = "AOC", Polegadas = 24 };

Eletronicos.AddRange([c1, c2, t1, t2 ]);

foreach(Eletronico e in Eletronicos)
{
    Console.WriteLine("\n");
    if (e is Celular)
    {
        var downcasting = (Celular)e;
        Console.WriteLine($"Celular da marca = {e.Marca} e o Número de linha = {downcasting.NumeroLinha}");
    }

    if (e is Televisao)
    {
        var downcasting = (Televisao)e;
        Console.WriteLine($"Televisão da marca = {e.Marca} e a Polegada de = {downcasting.Polegadas}");
    }
}

Console.WriteLine("\n");

// Exercicio 3 do RH da Empresa
Console.WriteLine("Exercicio 3");

Funcionario[] equipe = new Funcionario[]
{
    new Desenvolvedor {Nome = "João", LinguagemFavorita = "Python"},
    new Desenvolvedor {Nome = "Victor", LinguagemFavorita = "C#"},
    new Gerente {Nome = "Marcos", BonusAnual = 200},
    new Gerente {Nome = "Felipe", BonusAnual = 300},
};

foreach(var f in equipe)
{
    Console.WriteLine("\n");
    if (f is Desenvolvedor)
    {
        var downcasting = (Desenvolvedor)f;
        Console.WriteLine($"O desenvolvedor {f.Nome} gosta muito de {downcasting.LinguagemFavorita}");
        f.Trabalhar();
    }

    if (f is Gerente)
    {
        var downcasting = (Gerente)f;
        Console.WriteLine($"O Gerente {f.Nome} tem um bônus anual de {downcasting.BonusAnual:C}");
        f.Trabalhar();
    }
}




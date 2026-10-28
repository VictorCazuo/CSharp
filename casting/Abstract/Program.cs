using Abstract;
using System.Collections.Generic;

//Exercicio 1 - Folha de Pagamento
Console.WriteLine("Exercício 1 - Folha de pagamento");

List<Funcionario> funcionarios = new List<Funcionario>
{
    new Desenvolvedor("Victor"),
    new Desenvolvedor("Felipe"),
    new Gerente("Carlos",300),
    new Gerente("Lucas", 400)
};

decimal folhaDePagamentoTotal = 0;

foreach(var f in funcionarios)
{
    if(f is Gerente gerente)
    {
        Console.WriteLine($"O gerente {gerente.Nome} teve o bônus anual de {gerente.BonusAnual:C}");
    }

    folhaDePagamentoTotal += f.CalcularSalario();
}

Console.WriteLine($"A folha de pagamento total foi de {folhaDePagamentoTotal:C}");


//Exercício 2 - CatalogoProduto
Console.WriteLine("\nExercício 2 - Catálogo de Produto");

List<ProdutoVirtual> produtos = new List<ProdutoVirtual>
{
    new Ebook {Preco = 10, TamanhoMB = 1},
    new Ebook {Preco = 20, TamanhoMB = 20},
    new CursoOnline {Preco = 50, HorasDeAula = 120},
    new CursoOnline {Preco = 70, HorasDeAula = 150}
};

List<ProdutoVirtual> produtoCaro = produtos.FindAll(p => p.Preco > 50);

static void ImprimirCatalogo(IEnumerable<ProdutoVirtual>produtos)
{
    foreach( var p in produtos)
    {
        p.ObterDescricao();
    }
}

ImprimirCatalogo(produtoCaro);


//Exercício 3 - Interface e Classe abstrata
Console.WriteLine("\nExercício 3 - Interface e Classe abstrata");
CarroForte carro = new CarroForte();
carro.Placa = "MVW-5528";
carro.RealizarInspecao();




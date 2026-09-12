using Catalogo_de_produto;

List<Produto> produtos = DadosProdutos.GetProdutos();

ExibirProdutos(produtos);

//Adicionar itens na lista
produtos.Add(new Produto { Nome = "Webcam", Preco = 150.00 });
produtos.Add(new Produto { Nome = "Cadeira", Preco = 1200.00 });

ExibirProdutos(produtos);

//Achar e remover item da lista
produtos.RemoveAll(p => p.Nome == "Webcam");

ExibirProdutos(produtos);

//ordenar

Console.WriteLine("\nLista ordenada\n");
var ordenar = produtos.OrderBy(p => p.Nome);
foreach(var produto in ordenar){
    Console.WriteLine($"{produto.Nome}\t {produto.Preco} ");
}

//filtro

Console.WriteLine("\nLista de produtos filtrados\n");
var filtro = produtos.FindAll(p => p.Preco < 150);

foreach(var produto in filtro)
{
    Console.WriteLine($"{produto.Nome}\t{produto.Preco} ");
}


static void ExibirProdutos(List<Produto> produtos)
{
    double soma = 0;
    Console.WriteLine("\nLista dos produtos\n");
    Console.WriteLine("\nNome\tPreço");

    foreach(var produto in produtos)
    {
        Console.WriteLine($"{produto.Nome} {produto.Preco}");
        soma += produto.Preco;
    }

    Console.WriteLine($"A soma total dos produtos é de: {soma}");
    Console.WriteLine($"A quantidade total de produtos é de: {produtos.Count}");
    
}
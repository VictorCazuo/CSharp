using IS_AS;
using System.Collections.Generic;

// Exercicio 1 - Pedágio
Console.WriteLine("Exercicio 1 - Pedágio\n");

List<Veiculo> Veiculos = new List<Veiculo> 
{ 
    new Caminhao {Placa = "MUV-9183", QuantidadeEixos = 4},
    new Caminhao {Placa = "MMR-5822", QuantidadeEixos = 3},
    new Motocicleta {Placa = "JCE-6856", Cilindradas = 200},
    new Motocicleta {Placa = "HPQ-9626", Cilindradas = 300}
};

foreach(var v in Veiculos)
{
    if (v is Caminhao caminhao)
    {
        decimal valorPedagio = 10 * caminhao.QuantidadeEixos;

        Console.WriteLine($"O valor do pedágio para um caminhão de {caminhao.QuantidadeEixos} eixos é de {valorPedagio:C}. Boa viagem!");
    }

    if (v is Motocicleta motocicleta)
    {
        Console.WriteLine($"Pedagio para moto de placa ({motocicleta.Placa}) isento. Boa Viagem!");
    }
}

// Exercício 2 - Inspeção alfandegária
Console.WriteLine("\nExercício 2 - Inspeção Alfandegária");

EletronicoInternacional meuLaptop = new EletronicoInternacional();
InspecionarItem(meuLaptop);

string roupas = "Camiseta preta";
InspecionarItem(roupas);


static void InspecionarItem(object item)
{
    var conversao = item as EletronicoInternacional;

    if (conversao is not null)
    {
        Console.WriteLine("Eletrônico detectado! Verificando declaração");
    }

    if (conversao is null)
    {
        Console.WriteLine("Item comum liberado");
    }
}

//Exercício 3 - Arquivo de Log
Console.WriteLine("\nExercício 3 - Arquivo de Log");

List<object> logsBaguncados = new List<object>
{
    "Erro no servidor",
    404,
    "Conexão perdida",
    500,
    new Caminhao { Placa = "ABC-1234" } 
};

foreach (var i in logsBaguncados)
{
    var texto = i as string;
    if (texto is not null)
    {
        Console.WriteLine(texto.ToUpper());
    }

    if (i is int numero)
    {
        Console.WriteLine($"Código de Erro: {numero}");
    }

    if (i is Caminhao caminhao)
    {
        Console.WriteLine($"Placa do caminhão = {caminhao.Placa}");
    }
}

//Exercício 4 - Carrinho de compras
Console.WriteLine("\nExercício 4 - Carrinho de compras");

List<Produto> Produtos = new List<Produto>
{
    new Livro {Nome = "Metamorfose", Preco = 20, Autor = "Franz Kafka" },
    new Livro {Nome = "A vida é curta demais para viver o mínimo das coisas", Preco = 26.50m, Autor = "Iandê Albuquerque" },
    new Eletronico {Nome = "Controle 8bit-do", Preco = 149.99m, MesesGarantia = 3},
    new Eletronico {Nome = "Nintendo switch", Preco = 1649m, MesesGarantia = 12},
};

decimal valorTotal = 0;
decimal valorDesconto = 10;

foreach(var p in Produtos)
{
    if (p is Livro livro)
    {
        decimal precoComDesconto = livro.Preco - (livro.Preco / valorDesconto);
        Console.WriteLine($"Desconto aplicado para o livro do autor {livro.Autor}.");
        valorTotal += precoComDesconto;
    }

    if (p is Eletronico eletronico)
    {
        decimal precoComFrete = eletronico.Preco + 50m;
        Console.WriteLine($"Frete adicionado. Garantia de {eletronico.MesesGarantia} meses.");
        valorTotal += precoComFrete;
    }
}

Console.WriteLine($"O preço final do seu carrinho é de {valorTotal:C}");


//Exercício 5 - Veterinário
Console.WriteLine("\nExercício 5 - Veterinário");

Cachorro c1 = new Cachorro("Dog");
Gato g1 = new Gato("Bichano");

RealizarConsulta(c1);
RealizarConsulta(g1);

static void RealizarConsulta(Pet paciente)
{
    Console.WriteLine($"Atendendo o paciente: {paciente.Nome}");

    var cachorro = paciente as Cachorro;
    var gato = paciente as Gato;

    if (cachorro is not null)
    {
        cachorro.MorderOsso();
    }

    if (gato is not null)
    {
        gato.MiarAlto();
    }
}

//Exercício 6 - Simulador de Batalha
Console.WriteLine("\nExercício 6 - Simulador de Batalha");

Personagem jogador1 = new Mago();
//Guerreiro guerreiroFalso = (Guerreiro)jogador1; Se eu tentar fazer o downcasting tradicional aqui vai dar InvalidCastException
Guerreiro guerreiroFalso = jogador1 as Guerreiro;

if (guerreiroFalso is null)
{
    Console.WriteLine("Casting falhou em segurança, o personagem não era um guerreiro");
}


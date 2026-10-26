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


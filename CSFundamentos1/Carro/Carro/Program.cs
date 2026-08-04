using Cor;


Console.WriteLine("Cores de carro disponíveis: ");
Console.WriteLine($"{Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int)Cores.Azul}");


Console.WriteLine("Escolha o valor da cor que quer para seu carro: ");
int cor = Convert.ToInt32(Console.ReadLine());

Carro carro1 = new("Gol", "Volkswagen", "Volkswagen", 2020, 120, cor  );
carro1.ExibirInfo(carro1.Modelo, carro1.Montadora, carro1.Marca, carro1.Potencia, carro1.Ano, carro1.Cor);
public class Carro
{
    public string Modelo { get; set; }
    public string Montadora { get; set;}
    public string Marca { get; set; }
    public int Ano { get; set; }
    public int Potencia { get; set; }
    public int Cor { get; set; }
    public static double ValorIpva { get; set; }

    public Carro(string modelo, string montadora, string marca, int ano, int potencia, int cor)
    {
        Modelo = modelo;
        Montadora = montadora;
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
        Cor = cor;
        ValorIpva = 4;
    }

    public void ExibirInfo(string Modelo, string Montadora, string Marca, int Potencia, int Ano, int Cor = 1)
    {
        Console.WriteLine($"{Modelo} {Montadora} {Marca} {Potencia} {Ano} {(Cores)Cor}");
    }




}


//-Explique como poderíamos substituir o método ObterValorIPVA() de forma a inicializar o campo estático
//ValorIpva quando uma instância da classe fosse criada.

//Resposta
//Utilizariamos o construtor da classe para atribuir um valor assim que fosse instanciado ou substituir o método
//por um construtor estático

//- Implemente o código que realiza essa substituição
//- Qual o efeito de alterar o modificador de acesso do campo estático ValorIpva de public para internal ?

//Resposta = Que ele só poderá ser acessado dentro do mesmo assembly, outros projetos não poderão acessá-lo.

//-Qual o efeito de alterar o modificador de acesso do campo estático ValorIpva de public para private ?

//Resposta = Ele poderá ser acessado somente dentro da classe em que é criado.
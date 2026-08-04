using ConsoleApp2;
using System.IO;

//ContaBancaria c1 = new();
//c1.Depositar(100); 
//c1.Sacar(100);


//public class ContaBancaria
//{
//    public decimal Saldo { get; private set; }

//    public void Depositar(decimal valor)
//    {
//        if (valor > 0)
//        {
//            Saldo += valor;
//            Console.WriteLine($"Depósito no valor de {valor:c} realizado com sucesso.\nValor atual = {Saldo:c}");
//        }
//    }

//    public void Sacar(decimal valor)
//    {
//        if (valor <= Saldo - 5)
//        {
//            Saldo = Saldo - valor - 5;
//            Console.WriteLine($"Saque no valor de {valor:c} realizado com sucesso.\nValor atual = {Saldo:c}");

//        }
//    }
//}


//Ingresso i1 = new();
//Ingresso i2 = new();
//Ingresso i3 = new();
//Console.WriteLine(Ingresso.TotalIngressosVendidos);

//public class Ingresso
//{
//    public int NumeroDoBilhete { get; set; }
//    public static int TotalIngressosVendidos { get; set; }

//    public Ingresso()
//    {
//        TotalIngressosVendidos += 1;
//        NumeroDoBilhete = TotalIngressosVendidos;
//    }
//}

//Personagem p1 = new();
//p1.Vida = 50;

//Pocao pocao1 = new();
//pocao1.PocaoDeCura = 20;

//p1.TomarPocao(ref pocao1);
//Console.WriteLine(pocao1.PocaoDeCura);
//public struct Pocao
//{
//    public int PocaoDeCura { get; set; }
//}

//public class Personagem
//{
//    public int Vida { get; set; }

//    public void TomarPocao( ref Pocao garrafa)
//    {
//        Vida += garrafa.PocaoDeCura;
//        garrafa.PocaoDeCura = 0;
//    }
//}

//try
//{
//    Usuario u1 = new("123");
//    Console.WriteLine("Senha aceita!");
//}
//catch(ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}



//public class Usuario
//{
//    private string? Senha { get; set; }
//    public Usuario(string Senha)
//    {
//        if (Senha.Length < 8)
//        {
//            throw new ArgumentException("A senha é muito fraca!");
//        }

//        this.Senha = Senha;
//    }
//}


//try
//{
//    ConexaoBanco.Abrir();
//    int x = 2;
//    int y = 0;
//    int divisao = x / y;
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Não da para dividir por zero (Erro!)");
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    ConexaoBanco.Fechar();
//}

//public class ConexaoBanco
//{
//    public static void Abrir()
//    {
//        Console.WriteLine("Conexão Aberta!");
//    }

//    public static void Fechar()
//    {
//        Console.WriteLine("Conexão Fechada!");
//    }
//}


//Sistema s1 = new();
//s1.LerConfiguracao();
//public class Sistema
//{
//    public void LerConfiguracao()
//    {
//        try
//        {
//            Console.WriteLine("Buscando arquivo no Servidor...");

//            throw new FileNotFoundException("Arquivo de configuração não achado!");
//        }
//        catch(FileNotFoundException erroOriginal)
//        {
//            throw new Exception("Falha critica no sistema", erroOriginal);
//        }
//    }
//}

//Funcionario f1 = new();
//f1.Nome = "Victor";
//f1.Cargo = "Estagiario";
//f1.SalarioMensal = 1500m;

//var relatorio = new
//{
//    NomeExibicao = f1.Nome,
//    SalarioAnual = f1.SalarioMensal * 12,
//    BonusSugerido = (f1.SalarioMensal * 12) / 10,
//};

//Console.WriteLine($"{relatorio.NomeExibicao} {relatorio.SalarioAnual} {relatorio.BonusSugerido}");


//public class Funcionario
//{
//    public string? Nome { get; set; }
//    public string? Cargo { get; set; }
//    public decimal SalarioMensal { get; set; }
//}

Produto p1 = new();
p1.Nome = "Notebook";
p1.Preco = 3000m;
p1.AplicarDesconto(10);

Console.WriteLine($"{p1.Nome} {p1.Preco}");
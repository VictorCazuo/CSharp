using System;

namespace SeusExercicios.POO
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public string profissao;

        public void Apresentar() =>
            Console.WriteLine($"Olá, meu nome é {nome}, tenho {idade} anos e trabalho como {profissao}");
    }

    public class Aluno
    {
        public string nome;
        public int Matricula { get; set; }
        public double nota1;
        public double nota2;
        private double media = 0;

        // Construtor vazio para manter compatibilidade com o exercício de notas
        public Aluno() { }

        // Construtor com parâmetros para o exercício da Catraca
        public Aluno(string Nome, int Matricula)
        {
            this.nome = Nome;
            this.Matricula = Matricula;
        }

        public void CalcularMedia()
        {
            if ((nota1 >= 0 && nota1 <= 10) && (nota2 >= 0 && nota2 <= 10))
            {
                media = (nota1 + nota2) / 2;
                Console.WriteLine($"A média do aluno é: {media}");
                VerificarSituacao();
            }
        }

        public void VerificarSituacao()
        {
            if (media >= 7) Console.WriteLine("Aprovado");
            else Console.WriteLine("Reprovado");
        }
    }

    public class Funcionario
    {
        public string nome;
        public string cargo;
        public decimal salarioBruto;

        public decimal CalcularDescontoINSS()
        {
            return salarioBruto / 10;
        }

        public decimal CalcularSalarioLiquido()
        {
            return salarioBruto - CalcularDescontoINSS();
        }

        public void ExibirHolerite()
        {
            Console.WriteLine($"Nome: {nome}\nSalário Bruto: {salarioBruto:C}\nDesconto: {CalcularDescontoINSS():C}\nSalário Liquido: {CalcularSalarioLiquido():C}");
        }
    }

    public class ContaBancaria
    {
        public string Titular;
        public decimal Saldo;

        public decimal Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Você depositou {valor}.\nSaldo atual: {Saldo:C}");
            return Saldo;
        }

        public decimal Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Você sacou {valor}.\nSaldo atual: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }
            return Saldo;
        }
    }

    public class Empresa
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

        public Empresa(string RazaoSocial, string Cnpj)
        {
            if (Cnpj.Length != 14)
            {
                Console.WriteLine("Cnpj Inválido");
                this.Cnpj = "00000000000000";
            }
            else
            {
                this.Cnpj = Cnpj;
            }
            this.RazaoSocial = RazaoSocial;
        }
    }

    public class UsuarioLogin
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string NivelAcesso { get; set; }

        public UsuarioLogin(string Email, string Senha, string NivelAcesso)
        {
            this.Email = Email;
            this.Senha = Senha;
            this.NivelAcesso = NivelAcesso;
        }

        public UsuarioLogin(string Email, string Senha) : this(Email, Senha, "Comum")
        {
        }
    }
}
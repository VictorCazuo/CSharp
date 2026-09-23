using System;
using System.Collections.Generic;
using System.Text;
using Exercicios_Curso;

namespace Exercicios_Curso
{
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}");
        }


    }

    public class Produto
    {
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

    public class Aluno
    {
        string[] nomes = new string[10];

        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < nomes.Length)
                {
                    return nomes[i];
                }
                return "Erro";
            }
            set
            {
                if (i >= 0 && i < nomes.Length)
                {
                    nomes[i] = value;
                }
            }
        }
    }
}

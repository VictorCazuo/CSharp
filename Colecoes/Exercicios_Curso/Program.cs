using System;
using System.Collections;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicios_Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Exercícios sobre coleções do curso\n");

            //Console.WriteLine("=== Exercicio 1");
            //Exercicio1();

            //Console.WriteLine("=== Exercicio 2\n");
            //Exercicio2();

            //Console.WriteLine("=== Exercicio 3\n");
            //Exercicio3();

            //Console.WriteLine("=== Exercicio 4\n");
            //Exercicio4();

            //Console.WriteLine("=== Exercício 5\n");
            //Exercicio5();

            Console.WriteLine("=== Exercicio 7");
            Aluno aluno = new Aluno();
            aluno[0] = "Victor";
            aluno[1] = "Julia";
            aluno[2] = "João"; 
            aluno[3] = "Pedro"; 
            aluno[4] = "Midoriya"; 
            aluno[5] = "Bakugou"; 
            aluno[6] = "Todoroki"; 
            aluno[7] = "All Might"; 
            aluno[8] = "Saitama"; 
            aluno[9] = "Itadori";

            Console.WriteLine(aluno[1]); 
            Console.WriteLine(aluno[9]); 
            
        }



        /// <summary>
        //1- Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize
        //as seguintes operações : Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora
        //c- Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
        //a- Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
        /// </summary>
        static void Exercicio1()
        {
            string[] frutas = new string[] { "Maçã", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora" };

            Console.WriteLine("Array original:\n");
            retornarArray(frutas);
            Console.WriteLine("\n");

            Console.WriteLine("Quantidade de frutas no array: ");
            int quantidadeDeFrutas = frutas.Length;
            Console.WriteLine($"Existem {quantidadeDeFrutas} fruta(s) no array");

            Console.WriteLine($"\nA segunda fruta é {frutas[1]} e a penúltima é {frutas[quantidadeDeFrutas - 2]} \n");

            frutas[2] = "Kiwi";
            frutas[quantidadeDeFrutas - 1] = "Caqui";

            Console.WriteLine("\nArray atualizado: ");
            retornarArray(frutas);
            Console.WriteLine("\n");

            Array.Sort(frutas);
            var frutasInv = frutas.Reverse();
            Console.WriteLine("\nFrutas ordenadas do maior pro menor:");

            foreach (string fruta in frutasInv)
            {
                Console.Write($"{fruta} ");
            }
            Console.WriteLine("\n");

            static void retornarArray(string[] frutas)
            {
                foreach (string fruta in frutas)
                {
                    Console.Write($"{fruta} ");
                }
            }
        }

        /// <summary>
        //2- Crie um programa em C# que sirva para pesquisar um array de valores inteiros. Para fazer isso, siga estas 
        //etapas a seguir
        //a-) Solicite via teclado o número de valores do array(deve ser um número inteiro)
        //b-) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados
        //c-) Solicite ao usuário um valor de um número inteiro a procurar no array
        //d-) Exiba se o número informado existe no array de inteiros ou não
        //e-) Repita até que o texto ‘fim’ seja inserido via teclado
        /// </summary>
        
        static void Exercicio2()
        {
            Console.WriteLine("Digite a quantidade de itens que seu array terá: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[quantidade];

            Console.WriteLine("Array gerado com números aleatórios:");
            Random numeroArray = new Random();

            for(int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = numeroArray.Next(0, 50);
                Console.Write($"{numeros[i]} ");
            }
            Console.WriteLine("\n");

            while (true)
            {
                Console.WriteLine("Digite um número de 0 à 50 para procurar em seu array ou digite fim se quiser sair: ");
                var procurarArray = Console.ReadLine();
                bool existe = false;
                if (procurarArray != "fim")
                {
                    int itemInteiro = Convert.ToInt32(procurarArray);
                    foreach(int numero in numeros)
                    {
                        if (numero == itemInteiro)
                            existe = true;
                    }

                    if (existe)
                    {
                       Console.WriteLine($"O numero {itemInteiro} existe no array");
                    }
                    else
                    {
                        Console.WriteLine($"O número {itemInteiro} não existe no array");
                    }

                }
                else
                {
                    Console.WriteLine("Encerrando o programa...");
                    break;
                }
            }
        }

        /// <summary>
        //3- Escreva um programa em C# que solicite ao usuário que informe o valor das notas, do tipo float , para 10 
        //alunos divididos em 2 grupos de 5 alunos cada.Armazene as informações em um array bidimensional e a
        //seguir exiba no console a média aritmética de cada grupo de alunos (grupo1 e grupo2).
        /// </summary>

        static void Exercicio3()
        {
            float[,] alunos = new float[2, 5];
            float somagrupo1 = 0;
            float somagrupo2 = 0;

            for(int linha = 0; linha < alunos.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < alunos.GetLength(1); coluna++)
                {

                    Console.WriteLine($"Digite a nota do {coluna + 1}° aluno do grupo {linha + 1}");
                    string entrada = Console.ReadLine();
                    float nota;

                    while (!float.TryParse(entrada, out nota))
                    {
                        Console.WriteLine("Entrada incorreta. Digite apenas número.");
                        Console.WriteLine($"Digite a nota do {coluna + 1}° aluno do grupo {linha + 1}");
                        entrada = Console.ReadLine();
                    }
                    alunos[linha, coluna] = nota;

                    if(linha == 0)
                    {
                        somagrupo1 += nota;
                    }
                    else
                    {
                        somagrupo2 += nota;
                    }
                }
            }

            Console.WriteLine("Array das notas dos alunos: ");
            for (int linha = 0; linha < alunos.GetLength(0); linha++)
            {
                Console.WriteLine($"Grupo {linha+1}");
                for (int coluna = 0; coluna < alunos.GetLength(1); coluna++)
                {
                    Console.Write(alunos[linha, coluna] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("\n");

            Console.WriteLine($"Média do grupo 1 = {somagrupo1 / alunos.GetLength(1)}");
            Console.WriteLine($"Média do grupo 2 = {somagrupo2 / alunos.GetLength(1)}");


        }

        /// <summary>
        //4- Crie um programa C# que usa uma ArrayList para armazenar uma lista de objetos pessoas. 
        //a-) Primeiro crie uma classe chamada Pessoa.cs com duas propriedades (nome e idade) e um método Exibir()
        //para imprimir o nome e a idade;
        //b-) A seguir crie uma ArrayList e solicite a informação dos nomes e idades de 3 pessoas via teclado
        //armazenando as informações na ArrayList.
        //c-) A seguir exiba no console a lista das pessoas com nome e idade
        //d-) Inclua mais dois objetos Pessoa na lista e exiba a nova lista de pessoas
        //e-) Remova o último elemento da coleção e exiba a lista completa
        //Use seguintes dados iniciais:   Ana, 22  - Diná, 21  - Maria, 19
        //Ao incluir os objetos pessoa use os dados :   Jaime,20  - Tânia,18
        /// </summary>

        static void Exercicio4()
        {
            ArrayList Pessoas = new ArrayList();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Digite o nome da {i + 1}ª pessoa: ");
                string nome = Console.ReadLine();

                Console.WriteLine($"Digite a idade da {i + 1}ª pessoa: ");
                int idade = Convert.ToInt32(Console.ReadLine());

                Pessoas.Add(new Pessoa(nome, idade));
            }

            Console.WriteLine("\nArrayList original:");
            ExibirListaPessoas(Pessoas);

            Pessoas.Add(new Pessoa("Jaime", 20));
            Pessoas.Add(new Pessoa("Tânia", 18));

            Console.WriteLine("\nArrayList com adicional:");
            ExibirListaPessoas(Pessoas);

            Pessoas.RemoveAt(Pessoas.Count - 1);

            Console.WriteLine("\nArrayList com remoção da ultima pessoa:");
            ExibirListaPessoas(Pessoas);

            static void ExibirListaPessoas(ArrayList lista)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Pessoa pessoaAtual = (Pessoa)lista[i];
                    pessoaAtual.Exibir();
                }
            }
        }

        /// <summary>
        //5- Dada uma classe Produto contendo duas propriedades :  Nome(string) e Preco(decimal). Crie uma lista
        //de objetos do tipo Produto usando os seguinte dados:
        //Clips, R$ 3,95 - Caneta, R$ 5,99 -- Lápis,  R$ 4,15 - Estojo, R$ 6,99 e Caderno, R$ 7,55 
        //A seguir realize as seguintes operações na lista de objetos Produto criada : 
        //1- Crie um método para exibir a relação de produtos , a soma total dos preços dos produtos, a média do 
        //preço dos produtos e a quantidade de produtos na lista
        //2 - Inclua na lista o seguinte produto :  Mochila, R$ 22,44  e exiba novamente a lista de produtos
        //3- Ordene a lista pelo nome do produto e exiba a lista ordenada
        //4 - Obtenha e exiba no console os produtos com preço inferior a R$ 5,00 
        //5- Localize na lista o produto com nome Estojo
        /// </summary>
        /// 

        static void Exercicio5()
        {
            List<Produto> produtos = new List<Produto>()
            {
                new Produto("Clips", 3.95m),
                new Produto("Caneta", 5.99m),
                new Produto("Lápis", 4.15m),
                new Produto("Estojo", 6.99m),
                new Produto("Caderno", 7.55m),
            };

            ExibirInfo(produtos);

            Console.WriteLine("\nLista após adição de item");
            produtos.Add(new Produto("Mochila", 22.44m));
            ExibirInfo(produtos);

            Console.WriteLine("\nLista após ordenação dos itens");
            var produtosOrdenados = produtos.OrderBy(p => p.Nome);
            foreach (var produto in produtosOrdenados)
            {
                Console.WriteLine($"{produto.Nome} | {produto.Preco}");
            }

            var precosAnalise = produtos.FindAll(p => p.Preco < 5.00m);
            Console.WriteLine("\nProdutos com preço menor que R$5.00");
            foreach (var produto in precosAnalise)
            {
                Console.WriteLine($"{produto.Nome} | {produto.Preco}");
            }

            Console.WriteLine($"O produto estojo esta no índice: {produtos.FindIndex(p => p.Nome == "Estojo")}");


            static void ExibirInfo(List<Produto> produtos)
            {
                decimal soma = 0;
                Console.WriteLine("Nome\tPreço");
                foreach(var produto in produtos)
                {
                    Console.WriteLine($"{produto.Nome} | {produto.Preco}");
                    soma += produto.Preco;
                }

                Console.WriteLine($"A soma dos preços dos produtos é = R${soma}");
                Console.WriteLine($"A média dos preços dos produtos é = {soma / produtos.Count}");
                Console.WriteLine($"A lista possui {produtos.Count} itens");

                
            }
        }

        /// <summary>
        //6- Crie um programa C# e defina um método chamado ProcessaObjetos() que possa receber um número 
        //variáveis de argumentos e que possa exibir os seus valores e também o tipo do objeto(Use o método
        //GetType() herdado de Object) no console.
        //Passe os seguintes argumentos ao invocar o método : ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null) 
        /// </summary>
        
        static void Exercicio6()
        {
            ProcessaObjetos(1, "Maria", 3.45m, new Pessoa("Julia", 12), null);
        }

        static void ProcessaObjetos(params object[] argumentos)
        {
            if(argumentos != null)
            {
                foreach(var objeto in argumentos)
                {
                   Console.WriteLine($"Esse é o objeto: {objeto}\nEsse é o seu tipo: {objeto?.GetType()}");
                }
            }
        }

        /// <summary>
        //7- Crie um indexador para uma classe Aluno para gerenciar uma coleção de nomes de alunos com no máximo
        //10 elementos.
        //Para testar a implementação atribua nomes e obtenha os valores atribuídos usando o indexador criado.
        /// </summary>
    

    }

}
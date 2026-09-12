using Simulacao_RPG;

namespace Simulacao_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personagem> personagens = DadosPersonagens.GetPersonagens();

            ExibirDados(personagens);

            //Adicionando novo personagem do RPG
            Console.WriteLine("\nLista depois do personagem ser adicionado");
            personagens.Add(new Personagem { Nome = "Frodo", ClasseRPG = "Ladino", Nivel = 5 });
            ExibirDados(personagens);

            //Removendo personagem que se perdeu
            Console.WriteLine("\nLista depois da remoção do personagem");
            personagens.RemoveAll(p => p.Nome == "Gimli");
            ExibirDados(personagens);

            //Ordenar lista pelo nivel dos personagens em ordem crescente
            Console.WriteLine("\nLista depois da ordenação");
            var ordenacaoNivel = personagens.OrderBy(p => p.Nivel);
            foreach(var personagem in ordenacaoNivel)
            {
                Console.WriteLine($"{personagem.Nome, -5}\t{personagem.ClasseRPG, -10}\t{personagem.Nivel, -15}");
            }

            //Lista pela classe
            Console.WriteLine("\nPersonagens da classe guerreiro");
            var classeGuerreiro = personagens.FindAll(p => p.ClasseRPG == "Guerreiro");
            foreach (var personagem in classeGuerreiro)
            {
                Console.WriteLine($"{personagem.Nome,-5}\t{personagem.ClasseRPG,-10}\t{personagem.Nivel,-15}");
            }


            static void ExibirDados(List<Personagem> personagens)
            {
                int somanivel = 0;
                Console.WriteLine("Nome\tClasse\t\tNível");
                foreach(var personagem in personagens)
                {
                    Console.WriteLine($"{personagem.Nome, -5}\t{personagem.ClasseRPG,-10}\t{personagem.Nivel,-15}");
                    somanivel += personagem.Nivel;
                }

                Console.WriteLine($"\nO nível médio da guilda é de = {somanivel / personagens.Count}");

            }
        }
    }
}

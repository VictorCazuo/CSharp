using System;
using System.Collections.Generic;
using System.Text;

namespace Simulacao_RPG
{
    public class DadosPersonagens
    {
        public static List<Personagem> GetPersonagens()
        {
            List<Personagem> personagens = new List<Personagem>()
            {
                new Personagem() {Nome = "Aragon", ClasseRPG = "Guerreiro", Nivel = 15},
                new Personagem() {Nome = "Legolas", ClasseRPG = "Arqueiro", Nivel = 16},
                new Personagem() {Nome = "Gandalf", ClasseRPG = "Mago", Nivel = 20},
                new Personagem() {Nome = "Gimli", ClasseRPG = "Guerreiro", Nivel = 14}
            };

            return personagens;
        }
    }
}

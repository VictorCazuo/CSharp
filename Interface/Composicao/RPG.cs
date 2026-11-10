using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao
{
    public class Arma
    {
        public string Nome { get; set; } = string.Empty;
        public int DanoBase { get; set; }

        public Arma(string nome, int danoBase)
        {
            Nome = nome;
            DanoBase = danoBase;
        }
    }

    public class Personagem
    {
        public string Nome { get; set; } = string.Empty;
        public int Vida { get; set; }
        public Arma ArmaEquipada { get; set; }

        public Personagem(string nome, int vida, Arma armaInicial)
        {
            Nome = nome;
            Vida = vida;
            ArmaEquipada = armaInicial;
        }

        public void Atacar()
        {
            Console.WriteLine($"{Nome} ataca com {ArmaEquipada.Nome} causando {ArmaEquipada.DanoBase} de dano!");
        }
    }


}

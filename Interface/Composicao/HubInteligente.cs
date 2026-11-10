using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao
{
    internal class Lampada
    {
        public void MudarCor(string cor)
        {
            Console.WriteLine($"Mudando a cor para {cor}");
        }
    }

    internal class ArCondicionado
    {
        public void DefinirTemperatura(int graus)
        {
            Console.WriteLine($"Mudando temperatura para {graus}°");
        }
    }

    public class HubInteligente
    {
        private readonly Lampada lampada;
        private readonly ArCondicionado arCondicionado;

        public HubInteligente()
        {
            lampada = new Lampada();
            arCondicionado = new ArCondicionado();
        }

        public void AtivarModoCinema()
        {
            lampada.MudarCor("Azul Escuro");
            arCondicionado.DefinirTemperatura(20);
        }
    }
}

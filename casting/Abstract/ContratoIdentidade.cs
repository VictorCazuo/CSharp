using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    public interface IInspecionavel
    {
        void RealizarInspecao();
    }

    public abstract class Veiculo
    {
        public string Placa { get; set; } = string.Empty;
    }

    public class CarroForte : Veiculo, IInspecionavel
    {
        public void RealizarInspecao()
        {
            Console.WriteLine("Realizando Inspeção...");
        }
    }
}

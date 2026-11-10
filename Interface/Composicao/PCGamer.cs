using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao
{
    public enum TipoMemoria
    {
        DDR4, //0
        DDR5 //1
    }

    public class Processador
    {
        public string Marca { get; set; } = string.Empty;
        public double FrequenciaEmGHz { get; set; }

        public Processador(string marca, double frequenciaEmGHz)
        {
            Marca = marca;
            FrequenciaEmGHz = frequenciaEmGHz;
        }
    }

    public class MemoriaRAM
    {
        public int CapacidadeGB { get; set; }
        public TipoMemoria Tipo { get; set; }

        public MemoriaRAM(int capacidadeGB, TipoMemoria tipo)
        {
            CapacidadeGB = capacidadeGB;
            Tipo = tipo;
        }
    }

    public class Computador
    {
        private readonly Processador Processador;
        private List<MemoriaRAM> memoriaRAM { get; set; }

        public Computador(Processador processador)
        {
            Processador = processador;
            memoriaRAM = new List<MemoriaRAM>();
        }

        public void InstalarMemoria(MemoriaRAM ram)
        {
            memoriaRAM.Add(ram);
            Console.WriteLine($"Intalando memória ram do tipo {ram.Tipo} com {ram.CapacidadeGB}GB");
        }

        public void ExibirEspecificacoes()
        {
            decimal soma = 0;
            foreach(var memoria in memoriaRAM)
            {
                soma += memoria.CapacidadeGB;
            }
            Console.WriteLine($"O processador de marca {Processador.Marca} possui {soma}GB de memória instalada");
        }
    }
}

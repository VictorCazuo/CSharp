using System;
using System.Collections.Generic;
using System.Text;

namespace Agregacao
{
    public class PenDrive
    {
        public int CapacidadeGB { get; set; }

        public PenDrive(int capacidadeGB)
        {
            CapacidadeGB = capacidadeGB; 
        }

        public void LerArquivos()
        {
            Console.WriteLine("Lendo dados do dispositivo...");
        }
    }

    public class Computador
    {
        public PenDrive? DispositivoUSB;

        public void ConectarUSB(PenDrive pendrive)
        {
            DispositivoUSB = pendrive;
            Console.WriteLine("Dispositivo USB conectado");
        }

        public void AcessarDados()
        {
            if (DispositivoUSB is not null)
                DispositivoUSB.LerArquivos();
            else Console.WriteLine("Nenhum dispositivo conectado");
        }

        public void DesconectarUSB()
        {
            DispositivoUSB = null;
            Console.WriteLine("Dispositivo desconectado");
        }
    }

}

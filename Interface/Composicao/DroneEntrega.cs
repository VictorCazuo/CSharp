using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao
{
    public interface IMotor
    {
        public void Acionar();
    }

    public class MotorEletrico : IMotor
    {
        public void Acionar()
        {
            Console.WriteLine("Zumbido elétrico silencioso");
        }
    }

    public class MotorCombustao : IMotor
    {
        public void Acionar()
        {
            Console.WriteLine("Ronco alto com fumaça");
        }
    }

    public class Drone
    {
        public IMotor MotorEquipado { get; set; }
        public Drone(IMotor motorEquipado)
        {
            MotorEquipado = motorEquipado;
        }

        public void Voar()
        {
            MotorEquipado.Acionar();
        }
    }
}

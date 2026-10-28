using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    public abstract class Funcionario
    {
        public string Nome { get; set; } = string.Empty;

        public Funcionario(string nome)
        {
            Nome = nome;
        }

        public abstract decimal CalcularSalario();

    }

    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string nome) : base(nome)
        {

        }

        public override decimal CalcularSalario()
        {
            return 3000m;
        }
    }

    public class Gerente : Funcionario
    {
        public decimal BonusAnual { get; set; }

        public Gerente(string nome, decimal bonusAnual) : base(nome)
        {
            BonusAnual = bonusAnual;
        }

        public override decimal CalcularSalario()
        {
            return 5000m + BonusAnual;
        }
    }
}

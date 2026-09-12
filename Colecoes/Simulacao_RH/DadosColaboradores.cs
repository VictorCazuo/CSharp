using System;
using System.Collections.Generic;
using System.Text;

namespace Simulacao_RH
{
    public class DadosColaboradores
    {
        public static List<Funcionario> GetFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>()
            {
                new Funcionario() { Nome = "Lucas", Salario = 3500.50 },
                new Funcionario() { Nome = "Mariana", Salario = 4200.00 },
                new Funcionario() { Nome = "Felipe", Salario = 2800.75 },
                new Funcionario() { Nome = "Juliana", Salario = 5500.00 },
                new Funcionario() { Nome = "Roberto", Salario = 3100.00 }
            };

            return funcionarios;
        }
    }
}

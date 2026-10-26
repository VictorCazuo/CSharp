using System;
using System.Collections.Generic;
using System.Text;

namespace casting
{
    public class Funcionario
    {
        public string Nome { get; set; } = string.Empty;

        public virtual void Trabalhar()
        {
            Console.WriteLine("Trabalhando");
        }
    }

    public class Desenvolvedor : Funcionario
    {
        public string LinguagemFavorita { get; set; } =  string.Empty;

        public override void Trabalhar()
        {
            Console.WriteLine("Escrevendo Código");
        }
    }

    public class Gerente : Funcionario
    {
        public decimal BonusAnual { get; set; }

        public override void Trabalhar()
        {
            Console.WriteLine("Gerenciando a equipe");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    public abstract class ProdutoVirtual{
        private decimal preco;
        public decimal Preco
        {
            get { return preco; }
            set
            {
                if(value >= 0)
                {
                    preco = value;
                }
            }
        }

        public abstract void ObterDescricao();
    }

    public class Ebook : ProdutoVirtual
    {
        public decimal TamanhoMB { get; set; }

        public override void ObterDescricao()
        {
            Console.WriteLine($"Ebook de {TamanhoMB}MB");
        }
    }

    public class CursoOnline : ProdutoVirtual
    {
        public decimal HorasDeAula { get; set; }

        public override void ObterDescricao()
        {
            Console.WriteLine($"Curso com {HorasDeAula}hrs");
        }
    }
}

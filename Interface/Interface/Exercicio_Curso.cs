using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface ISalvar
    {
        public void Salvar();
        
        public void Compactar()
        {
            Console.WriteLine("Compactando Arquivo...");
        }
    }

    public abstract class ArquivoBase()
    {
        public virtual void Nome()
        {
            Console.WriteLine("Definir o nome do arquivo");
        }
    }

    public class SalvarXml : ArquivoBase, ISalvar
    {
        public void Salvar()
        {
            Console.WriteLine("Salvando arquivo XML...");
        }

        public override void Nome()
        {
            Console.WriteLine("XML");
        }
    }

    public class SalvarJson : ArquivoBase, ISalvar
    {
        public void Salvar()
        {
            Console.WriteLine("Salvando Arquivo JSON...");
        }

        public override void Nome()
        {
            Console.WriteLine("JSON");
        }
    }
}

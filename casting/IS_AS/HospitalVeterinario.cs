using System;
using System.Collections.Generic;
using System.Text;

namespace IS_AS
{
    public class Pet
    {
        public string Nome { get; }

        public Pet(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Pet
    {
        public Cachorro (string nome) : base(nome)
        {

        }

        public void MorderOsso()
        {

        }
    }

    public class Gato : Pet
    {
        public Gato (string nome) : base(nome)
        {

        }

        public void MiarAlto()
        {

        }
    }
}

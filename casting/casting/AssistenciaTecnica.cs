using System;
using System.Collections.Generic;
using System.Text;

namespace casting
{
    public class Eletronico
    {
        public string Marca { get; set; } = string.Empty;
    }

    public class Celular : Eletronico
    {
        public string NumeroLinha { get; set; } = string.Empty;
    }

    public class Televisao : Eletronico
    {
        public int Polegadas { get; set; }
    }
}

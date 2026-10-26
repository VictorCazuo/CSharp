using System;
using System.Collections.Generic;
using System.Text;

namespace IS_AS
{
    public class Veiculo
    {
        public string Placa { get; set; } = string.Empty;
    }

    public class Caminhao : Veiculo
    {
        public int QuantidadeEixos { get; set; }
    }

    public class Motocicleta : Veiculo
    {
        public int Cilindradas { get; set; }
    }

}

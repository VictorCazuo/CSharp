using System;
using System.Collections.Generic;
using System.Text;

namespace Agregacao
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }

    public class CarrinhoDeCompras
    {
        private Cliente _cliente;
        private List<string> _itens;

        public CarrinhoDeCompras(Cliente cliente)
        {
            _cliente = cliente;
            _itens = new List<string>();
        }

        public void AdicionarItem(string item)
        {
            _itens.Add(item);
        }

        public void FecharPedido()
        {
            Console.WriteLine($"Pedido fechado para o cliente {_cliente.Nome}.\nTotal de itens: {_itens.Count}");
        }
    }
}

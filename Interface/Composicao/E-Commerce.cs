using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Composicao
{
    public class Cliente
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }

    public class Item
    {
        public string Descricao { get; set; } = string.Empty;
        public decimal Valor { get; set; }

        public Item (string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
    }

    public class Pedido
    {
        private Cliente Cliente;
        private List<Item> Itens { get; set; }

        public Pedido (Cliente cliente)
        {
            Cliente = cliente;
            Itens = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }

        public decimal CalcularTotal()
        {
            decimal soma = 0;
            foreach (var item in Itens)
            {
                soma += item.Valor;
            }

            return soma;
        }

        public void ExibirItens()
        {
            foreach(var item in Itens)
            {
                Console.WriteLine($"{item.Descricao}\t{item.Valor:C}");
            }
        }
    }
}

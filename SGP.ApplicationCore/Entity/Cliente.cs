using System;
using System.Collections.Generic;
using System.Text;

namespace SGP.ApplicationCore.Entity
{
    public class Cliente
    {

        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public List<Pedido> Pedidos { get; set; }

    }
}

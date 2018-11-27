using System;
using System.Collections.Generic;
using System.Text;

namespace SGP.ApplicationCore.Entity
{
   public class Pedido
    {

        public int PedidoId { get; set; }

        public int ClienteId { get; set; }

        public int MyProperty { get; set; }

        public DateTime DataDoPedido { get; set; }

        public DateTime? DataDoEnvio { get; set; }

        public DateTime? DataDeEntrega { get; set; }

        public Cliente Cliente { get; set; }

        public List<ItemDoPedido> Itens { get; set; }

    }
}

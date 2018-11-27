using System;
using System.Collections.Generic;
using System.Text;

namespace SGP.ApplicationCore.Entity
{
   public class ItemDoPedido
    {
        public int ItemDoPedidoId { get; set; }

        public int PedidoId { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public Pedido Pedido { get; set; }

        public Produto Produto { get; set; }
    }
}

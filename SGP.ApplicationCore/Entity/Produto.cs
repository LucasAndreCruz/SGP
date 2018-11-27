using System;
using System.Collections.Generic;
using System.Text;

namespace SGP.ApplicationCore.Entity
{
   public class Produto
    {

        public int ProdutoId { get; set; }

        public int CategoriaId { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public Categoria Categoria { get; set; }

        public List<ItemDoPedido> Itens { get; set; }

    }
}

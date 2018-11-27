using System;
using System.Collections.Generic;
using System.Text;

namespace SGP.ApplicationCore.Entity
{
  public  class Categoria
    {
        //Chave Primária (PK) seguindo a convenção NomeDaClasse seguido de Id
        public int CategoriaId { get; set; }

        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; }

    }
}

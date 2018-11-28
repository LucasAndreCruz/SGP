using Microsoft.EntityFrameworkCore;
using SGP.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGP.Infrastructure.Data
{
    public class SGPContext : DbContext
    {

        public SGPContext()
        {

        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<ItemDoPedido> ItensDosPedidos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<Produto> Produtos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BdSGP;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().ToTable("tbCategoria");
            modelBuilder.Entity<Categoria>()
                .Property(x => x.Descricao)
                .HasColumnType("varchar(200)");

            modelBuilder.Entity<Produto>().ToTable("tbProduto");
       
        }

    }
}

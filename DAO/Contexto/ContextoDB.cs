using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Mapping;
using PbStore.Domain.Pedidos;

namespace DAO.Contexto
{
    public class ContextoDB : DbContext
    {

                                     // Connection String de Intancia padrão do SQL Server
        public ContextoDB() : base (@"Server=(LocalDb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=D:\PbStore.mdf;") {}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMapping());
            modelBuilder.Configurations.Add(new ProdutoMapping());
            modelBuilder.Configurations.Add(new PedidosMapping());
            modelBuilder.Configurations.Add(new ItemPedidoMapping());
        }
    }
}

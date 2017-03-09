using PbStore.Dao.Mapping;
using PbStore.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbStore.Dao.Context
{
    public class PbStoreContext : DbContext
    {
        public PbStoreContext() : base()
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PbStore.Domain.Pedidos;
using PbStore.Infra.Mappings;

namespace PbStore.Infra.Contexts
{
    public class PbStoreDataContext : DbContext
    {
        public PbStoreDataContext(): base(@"Server=ANDRBALTIER8D5E\SQLEXPRESS;Database=pbstore;Integrated Security=SSPI;")
        {}

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
        }
    }
}

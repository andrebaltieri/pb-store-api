namespace PbStore.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PrimeiroNome = c.String(nullable: false, maxLength: 30),
                        SegundoNome = c.String(nullable: false, maxLength: 30),
                        Email = c.String(nullable: false, maxLength: 100),
                        CPF = c.String(nullable: false, maxLength: 11),
                        CEP = c.String(nullable: false, maxLength: 8),
                        Logradouro = c.String(nullable: false, maxLength: 80),
                        Numero = c.String(maxLength: 5),
                        Bairro = c.String(nullable: false, maxLength: 30),
                        Cidade = c.String(nullable: false, maxLength: 50),
                        Estado = c.String(nullable: false, maxLength: 50),
                        Pais = c.String(nullable: false, maxLength: 50),
                        Telefone = c.String(maxLength: 10),
                        DataNascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 200),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuantidadeEmEstoque = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produto");
            DropTable("dbo.Cliente");
        }
    }
}

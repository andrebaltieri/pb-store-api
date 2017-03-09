namespace DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome_PrimeiroNome = c.String(nullable: false, maxLength: 20, unicode: false),
                        Nome_SegundoNome = c.String(nullable: false, maxLength: 20, unicode: false),
                        Email = c.String(nullable: false, maxLength: 200, unicode: false),
                        CPF = c.String(nullable: false, maxLength: 11, unicode: false),
                        Endereco_CEP = c.String(nullable: false, maxLength: 8, unicode: false),
                        Endereco_Logradouro = c.String(nullable: false, maxLength: 120, unicode: false),
                        Endereco_Numero = c.String(nullable: false, maxLength: 10, unicode: false),
                        Endereco_Bairro = c.String(nullable: false, maxLength: 60, unicode: false),
                        Endereco_Cidade = c.String(nullable: false, maxLength: 60, unicode: false),
                        Endereco_Estado = c.String(nullable: false, maxLength: 60, unicode: false),
                        Endereco_Pais = c.String(nullable: false, maxLength: 60, unicode: false),
                        Telefone = c.String(nullable: false, maxLength: 14, unicode: false),
                        DataNascimento = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemPedido",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantidade = c.Int(nullable: false),
                        Produto_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtos", t => t.Produto_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        Descricao = c.String(maxLength: 160, unicode: false),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuantidadeEmEstoque = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pedidos",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Data = c.DateTime(nullable: false),
                        TipoPagamento = c.Int(nullable: false),
                        Desconto = c.Decimal(precision: 18, scale: 2),
                        Cliente_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .Index(t => t.Cliente_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedidos", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.ItemPedido", "Produto_Id", "dbo.Produtos");
            DropIndex("dbo.Pedidos", new[] { "Cliente_Id" });
            DropIndex("dbo.ItemPedido", new[] { "Produto_Id" });
            DropTable("dbo.Pedidos");
            DropTable("dbo.Produtos");
            DropTable("dbo.ItemPedido");
            DropTable("dbo.Clientes");
        }
    }
}

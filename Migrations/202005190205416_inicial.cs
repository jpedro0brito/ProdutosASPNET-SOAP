namespace PRODUTO.ASP.NET.MVC.SOAP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaID);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ProdutoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoriaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoID)
                .ForeignKey("dbo.Categorias", t => t.CategoriaID, cascadeDelete: true)
                .Index(t => t.CategoriaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtos", "CategoriaID", "dbo.Categorias");
            DropIndex("dbo.Produtos", new[] { "CategoriaID" });
            DropTable("dbo.Produtos");
            DropTable("dbo.Categorias");
        }
    }
}

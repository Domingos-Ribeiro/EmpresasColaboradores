namespace EmpresasColaboradores.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versao1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colaboradors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        EmpresaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empresas", t => t.EmpresaId, cascadeDelete: true)
                .Index(t => t.EmpresaId);
            
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Localidade = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Colaboradors", "EmpresaId", "dbo.Empresas");
            DropIndex("dbo.Colaboradors", new[] { "EmpresaId" });
            DropTable("dbo.Empresas");
            DropTable("dbo.Colaboradors");
        }
    }
}

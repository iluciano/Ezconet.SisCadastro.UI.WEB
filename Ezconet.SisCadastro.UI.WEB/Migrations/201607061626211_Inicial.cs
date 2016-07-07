namespace Ezconet.SisCadastro.UI.WEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        CodPessoa = c.Int(nullable: false, identity: true),
                        NomePessoa = c.String(nullable: false, maxLength: 100, unicode: false),
                        SexoPessoa = c.Byte(nullable: false),
                        IdadePessoa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CodPessoa);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pessoa");
        }
    }
}

namespace Ezconet.SisCadastro.UI.WEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Segundo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animal",
                c => new
                    {
                        CodAnimal = c.Int(nullable: false, identity: true),
                        NomeAnimal = c.String(nullable: false, maxLength: 250, unicode: false),
                        SexoAnimal = c.Byte(nullable: false),
                        IdadeAnimal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CodAnimal);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Animal");
        }
    }
}

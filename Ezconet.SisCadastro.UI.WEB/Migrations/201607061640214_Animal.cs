namespace Ezconet.SisCadastro.UI.WEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Animal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoa", "NomePessoa", c => c.String(nullable: false, maxLength: 250, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoa", "NomePessoa", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
    }
}

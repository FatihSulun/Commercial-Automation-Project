namespace CommercialAutomationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pwstring4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EMPLOYEEs", "Password", c => c.String(maxLength: 4));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EMPLOYEEs", "Password", c => c.String(maxLength: 30));
        }
    }
}

namespace CommercialAutomationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phonestring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EMPLOYEEs", "phone", c => c.String(maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EMPLOYEEs", "phone", c => c.Int(nullable: false));
        }
    }
}

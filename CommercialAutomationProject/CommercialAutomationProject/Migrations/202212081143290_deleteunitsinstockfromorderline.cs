namespace CommercialAutomationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteunitsinstockfromorderline : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ORDERLINEs", "unitsInStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ORDERLINEs", "unitsInStock", c => c.Int(nullable: false));
        }
    }
}

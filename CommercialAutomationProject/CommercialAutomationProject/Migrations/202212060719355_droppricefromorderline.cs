namespace CommercialAutomationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class droppricefromorderline : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ORDERLINEs", "price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ORDERLINEs", "price", c => c.Double(nullable: false));
        }
    }
}

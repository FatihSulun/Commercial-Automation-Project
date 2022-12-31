namespace CommercialAutomationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tryyy : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ORDERS", "ORDERLINE_Id", "dbo.ORDERLINEs");
            DropIndex("dbo.ORDERS", new[] { "ORDERLINE_Id" });
            DropColumn("dbo.ORDERS", "ORDERLINE_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ORDERS", "ORDERLINE_Id", c => c.Int());
            CreateIndex("dbo.ORDERS", "ORDERLINE_Id");
            AddForeignKey("dbo.ORDERS", "ORDERLINE_Id", "dbo.ORDERLINEs", "Id");
        }
    }
}

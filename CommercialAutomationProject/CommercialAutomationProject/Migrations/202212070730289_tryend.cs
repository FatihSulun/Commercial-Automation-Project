namespace CommercialAutomationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tryend : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ORDERLINEs", "OrdersId", c => c.String());
            AddColumn("dbo.ORDERLINEs", "Orders_Id", c => c.Int());
            CreateIndex("dbo.ORDERLINEs", "Orders_Id");
            AddForeignKey("dbo.ORDERLINEs", "Orders_Id", "dbo.ORDERS", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ORDERLINEs", "Orders_Id", "dbo.ORDERS");
            DropIndex("dbo.ORDERLINEs", new[] { "Orders_Id" });
            DropColumn("dbo.ORDERLINEs", "Orders_Id");
            DropColumn("dbo.ORDERLINEs", "OrdersId");
        }
    }
}

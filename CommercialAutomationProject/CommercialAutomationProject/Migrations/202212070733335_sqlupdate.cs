namespace CommercialAutomationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sqlupdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ORDERLINEs", "Orders_Id", "dbo.ORDERS");
            DropIndex("dbo.ORDERLINEs", new[] { "Orders_Id" });
            DropColumn("dbo.ORDERLINEs", "OrdersId");
            RenameColumn(table: "dbo.ORDERLINEs", name: "Orders_Id", newName: "OrdersId");
            AlterColumn("dbo.ORDERLINEs", "OrdersId", c => c.Int(nullable: false));
            AlterColumn("dbo.ORDERLINEs", "OrdersId", c => c.Int(nullable: false));
            CreateIndex("dbo.ORDERLINEs", "OrdersId");
            AddForeignKey("dbo.ORDERLINEs", "OrdersId", "dbo.ORDERS", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ORDERLINEs", "OrdersId", "dbo.ORDERS");
            DropIndex("dbo.ORDERLINEs", new[] { "OrdersId" });
            AlterColumn("dbo.ORDERLINEs", "OrdersId", c => c.Int());
            AlterColumn("dbo.ORDERLINEs", "OrdersId", c => c.String());
            RenameColumn(table: "dbo.ORDERLINEs", name: "OrdersId", newName: "Orders_Id");
            AddColumn("dbo.ORDERLINEs", "OrdersId", c => c.String());
            CreateIndex("dbo.ORDERLINEs", "Orders_Id");
            AddForeignKey("dbo.ORDERLINEs", "Orders_Id", "dbo.ORDERS", "Id");
        }
    }
}

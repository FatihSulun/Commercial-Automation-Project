namespace CommercialAutomationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customerphoneadd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CUSTOMERs", "phone", c => c.String(maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CUSTOMERs", "phone", c => c.Int(nullable: false));
        }
    }
}

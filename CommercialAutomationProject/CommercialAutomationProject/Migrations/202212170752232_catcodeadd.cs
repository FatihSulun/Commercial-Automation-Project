namespace CommercialAutomationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class catcodeadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CATEGORies", "CategoryCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CATEGORies", "CategoryCode");
        }
    }
}

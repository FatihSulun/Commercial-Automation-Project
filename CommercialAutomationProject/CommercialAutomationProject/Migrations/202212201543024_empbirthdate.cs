namespace CommercialAutomationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class empbirthdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EMPLOYEEs", "EmployeeBirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EMPLOYEEs", "EmployeeBirthDate");
        }
    }
}

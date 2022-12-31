namespace CommercialAutomationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class genderadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EMPLOYEEs", "EmployeeGender", c => c.String());
            AddColumn("dbo.CUSTOMERs", "CustomerGender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CUSTOMERs", "CustomerGender");
            DropColumn("dbo.EMPLOYEEs", "EmployeeGender");
        }
    }
}

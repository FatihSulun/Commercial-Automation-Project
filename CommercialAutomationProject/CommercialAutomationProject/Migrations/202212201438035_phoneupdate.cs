namespace CommercialAutomationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phoneupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EMPLOYEEs", "Employeephone", c => c.String(maxLength: 10));
            AlterColumn("dbo.CUSTOMERs", "Customerphone", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CUSTOMERs", "Customerphone", c => c.String(maxLength: 11));
            AlterColumn("dbo.EMPLOYEEs", "Employeephone", c => c.String(maxLength: 11));
        }
    }
}

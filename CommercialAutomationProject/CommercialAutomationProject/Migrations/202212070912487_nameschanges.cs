namespace CommercialAutomationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nameschanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BRANCHes", "BranchCode", c => c.Int(nullable: false));
            AddColumn("dbo.BRANCHes", "BranchName", c => c.String(maxLength: 50));
            AddColumn("dbo.CITies", "CityCode", c => c.Int(nullable: false));
            AddColumn("dbo.CITies", "CityName", c => c.String(maxLength: 50));
            AddColumn("dbo.REGIONs", "RegionName", c => c.String(maxLength: 30));
            AddColumn("dbo.EMPLOYEEs", "EmployeeName", c => c.String(maxLength: 50));
            AddColumn("dbo.EMPLOYEEs", "EmployeeUsername", c => c.String(maxLength: 30));
            AddColumn("dbo.EMPLOYEEs", "EmployeePassword", c => c.String(maxLength: 4));
            AddColumn("dbo.EMPLOYEEs", "Employeephone", c => c.String(maxLength: 11));
            AddColumn("dbo.ORDERS", "OrderCode", c => c.String(maxLength: 50));
            AddColumn("dbo.CUSTOMERs", "CustomerCode", c => c.String(maxLength: 50));
            AddColumn("dbo.CUSTOMERs", "CustomerName", c => c.String(maxLength: 50));
            AddColumn("dbo.CUSTOMERs", "Customerphone", c => c.String(maxLength: 11));
            AddColumn("dbo.ORDERLINEs", "OrderLineCode", c => c.String(maxLength: 50));
            AddColumn("dbo.PRODUCTs", "ProductCode", c => c.String(maxLength: 50));
            AddColumn("dbo.PRODUCTs", "ProductName", c => c.String(maxLength: 50));
            AddColumn("dbo.CATEGORies", "CategoryName", c => c.String(maxLength: 50));
            DropColumn("dbo.BRANCHes", "Code");
            DropColumn("dbo.BRANCHes", "Name");
            DropColumn("dbo.CITies", "Code");
            DropColumn("dbo.CITies", "Name");
            DropColumn("dbo.REGIONs", "Name");
            DropColumn("dbo.EMPLOYEEs", "Name");
            DropColumn("dbo.EMPLOYEEs", "Username");
            DropColumn("dbo.EMPLOYEEs", "Password");
            DropColumn("dbo.EMPLOYEEs", "phone");
            DropColumn("dbo.ORDERS", "Code");
            DropColumn("dbo.CUSTOMERs", "Code");
            DropColumn("dbo.CUSTOMERs", "Name");
            DropColumn("dbo.CUSTOMERs", "phone");
            DropColumn("dbo.ORDERLINEs", "Code");
            DropColumn("dbo.PRODUCTs", "Code");
            DropColumn("dbo.PRODUCTs", "Name");
            DropColumn("dbo.CATEGORies", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CATEGORies", "Name", c => c.String(maxLength: 50));
            AddColumn("dbo.PRODUCTs", "Name", c => c.String(maxLength: 50));
            AddColumn("dbo.PRODUCTs", "Code", c => c.String(maxLength: 50));
            AddColumn("dbo.ORDERLINEs", "Code", c => c.String(maxLength: 50));
            AddColumn("dbo.CUSTOMERs", "phone", c => c.String(maxLength: 11));
            AddColumn("dbo.CUSTOMERs", "Name", c => c.String(maxLength: 50));
            AddColumn("dbo.CUSTOMERs", "Code", c => c.String(maxLength: 50));
            AddColumn("dbo.ORDERS", "Code", c => c.String(maxLength: 50));
            AddColumn("dbo.EMPLOYEEs", "phone", c => c.String(maxLength: 11));
            AddColumn("dbo.EMPLOYEEs", "Password", c => c.String(maxLength: 4));
            AddColumn("dbo.EMPLOYEEs", "Username", c => c.String(maxLength: 30));
            AddColumn("dbo.EMPLOYEEs", "Name", c => c.String(maxLength: 50));
            AddColumn("dbo.REGIONs", "Name", c => c.String(maxLength: 30));
            AddColumn("dbo.CITies", "Name", c => c.String(maxLength: 50));
            AddColumn("dbo.CITies", "Code", c => c.Int(nullable: false));
            AddColumn("dbo.BRANCHes", "Name", c => c.String(maxLength: 50));
            AddColumn("dbo.BRANCHes", "Code", c => c.Int(nullable: false));
            DropColumn("dbo.CATEGORies", "CategoryName");
            DropColumn("dbo.PRODUCTs", "ProductName");
            DropColumn("dbo.PRODUCTs", "ProductCode");
            DropColumn("dbo.ORDERLINEs", "OrderLineCode");
            DropColumn("dbo.CUSTOMERs", "Customerphone");
            DropColumn("dbo.CUSTOMERs", "CustomerName");
            DropColumn("dbo.CUSTOMERs", "CustomerCode");
            DropColumn("dbo.ORDERS", "OrderCode");
            DropColumn("dbo.EMPLOYEEs", "Employeephone");
            DropColumn("dbo.EMPLOYEEs", "EmployeePassword");
            DropColumn("dbo.EMPLOYEEs", "EmployeeUsername");
            DropColumn("dbo.EMPLOYEEs", "EmployeeName");
            DropColumn("dbo.REGIONs", "RegionName");
            DropColumn("dbo.CITies", "CityName");
            DropColumn("dbo.CITies", "CityCode");
            DropColumn("dbo.BRANCHes", "BranchName");
            DropColumn("dbo.BRANCHes", "BranchCode");
        }
    }
}

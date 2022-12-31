using CommercialAutomationProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialAutomationProject.Contexts
{
    public class CommercialAutomationCONTEXTS : DbContext
    {
        public DbSet<REGION> Regions { get; set; }
        public DbSet<CITY> Cities { get; set; }
        public DbSet<BRANCH> Branches { get; set; }
        public DbSet<CATEGORY> Categories { get; set; }
        public DbSet<PRODUCT> Products { get; set; }
        public DbSet<CUSTOMER> Customers { get; set; }
        public DbSet<EMPLOYEE> Employees { get; set; }
        public DbSet<ORDERS> Orders { get; set; }
        public DbSet<ORDERLINE> OrdersLine { get; set; }
        public CommercialAutomationCONTEXTS(): base("CAPConn") { }

        
    }
}

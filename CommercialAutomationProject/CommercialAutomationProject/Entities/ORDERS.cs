using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialAutomationProject.Entities
{
    public class ORDERS
    {
        public ORDERS()
        {
            OrderLınes = new List<ORDERLINE>();
        }
        public int Id { get; set; }
        [StringLength(50)]
        public string OrderCode { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        //public int BranchId { get; set; }
        public DateTime orderDate { get; set; }
        public CUSTOMER Customer { get; set; }
        public EMPLOYEE Employee { get; set; }
        public List<ORDERLINE> OrderLınes { get; set; }
        //public BRANCH Branch { get; set; }


    }
}

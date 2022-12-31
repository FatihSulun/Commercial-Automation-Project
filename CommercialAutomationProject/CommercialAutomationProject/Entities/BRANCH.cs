using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialAutomationProject.Entities
{
    public class BRANCH
    {
        public BRANCH()
        {
            //Orders = new List<ORDERS>();
            Employees = new List<EMPLOYEE>();
        }
        public int Id{ get; set; }
        public int BranchCode { get; set; }
        [StringLength(50)]
        public string BranchName{ get; set; }
        public int CityId { get; set; }
        public CITY City { get; set; }
        //public List<ORDERS> Orders { get; set; }

        public List<EMPLOYEE> Employees { get; set; }
        
    }
}

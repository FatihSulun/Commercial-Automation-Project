using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialAutomationProject.Entities
{
    public class CUSTOMER
    {
        public CUSTOMER()
        {
            Orders = new List<ORDERS>();
        }
        public int Id { get; set; }
        [StringLength(50)]
        public string CustomerCode { get; set; }
        [StringLength(50)]
        public string CustomerName { get; set; }
        //public int CityId { get; set; }
        //public CITY City { get; set; }
        public string CustomerGender { get; set; }
        public DateTime BirthDate { get; set; }
        [StringLength(10)]
        public string Customerphone { get; set; }
        public List<ORDERS> Orders { get; set; }


    }
}

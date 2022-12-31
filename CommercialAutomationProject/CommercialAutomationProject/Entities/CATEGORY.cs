using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialAutomationProject.Entities
{
    public class CATEGORY
    {
        public CATEGORY()
        {
            Products = new List<PRODUCT>();
            //OrderLines = new List<ORDERLINE>();
        }
        public int Id { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public List<PRODUCT> Products { get; set; }
        //public List<ORDERLINE> OrderLines { get; set; }
    }
}

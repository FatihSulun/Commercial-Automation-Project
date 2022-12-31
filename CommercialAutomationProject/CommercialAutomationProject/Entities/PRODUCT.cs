using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialAutomationProject.Entities
{
    public class PRODUCT
    {    
        public PRODUCT()
        {
            OrderLines = new List<ORDERLINE>();
        }
        public int Id { get; set; }
        [StringLength(50)]
        public string ProductCode { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public CATEGORY Category { get; set; } //1 ürünün 1 kategorisi olabilir.
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public List<ORDERLINE> OrderLines { get; set; }
    }
}

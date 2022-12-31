using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialAutomationProject.Entities
{
    public class ORDERLINE
    {
        public int Id { get; set; }       
        [StringLength(50)]
        public string OrderLineCode { get; set; }
        public int OrdersId { get; set; }
        public int ProductId { get; set; }
        //public int CategoryId { get; set; }
        //public double price { get; set; }
        public int quantity { get; set; }
        public double totalPrice { get; set; }
        //public int unitsInStock { get; set; }
        public PRODUCT Product { get; set; }
        public ORDERS Orders { get; set; }
        //public CATEGORY Category { get; set; }


    }
}

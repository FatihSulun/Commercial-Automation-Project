using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialAutomationProject.Entities
{
    public class REGION
    {
        public REGION()
        {
            Cities = new List<CITY>();
        }
        public int ID { get; set; }
        [StringLength(30)]
        public string RegionName { get; set; }
        public List<CITY> Cities { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialAutomationProject.Entities
{
    public class CITY
    {
        public CITY()
        {
            //Customers = new List<CUSTOMER>();
            Branches = new List<BRANCH>();
        }
        public int Id { get; set; }
        public int CityCode { get; set; }
        [StringLength(50)]
        public string CityName { get; set; }
        public int RegionId { get; set; }
        public REGION Region { get; set; }
        //public List<CUSTOMER> Customers { get; set; }
        public List<BRANCH> Branches { get; set; }


    }
}

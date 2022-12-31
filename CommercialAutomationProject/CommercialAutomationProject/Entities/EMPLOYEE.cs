using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialAutomationProject.Entities
{
    public class EMPLOYEE
    {
        public EMPLOYEE()
        {
            Orders = new List<ORDERS>();
        }
        public int Id { get; set; }
        [StringLength(50)]
        public string EmployeeName { get; set; }
        [StringLength(30)]
        public string EmployeeUsername { get; set; }
        [StringLength(4)]
        public string EmployeePassword { get; set; }
        public string EmployeeGender { get; set; }
        public int BranchId { get; set; }
        public BRANCH Branch { get; set; }
        [StringLength(10)]
        public string Employeephone { get; set; }
        public bool statu { get; set; }
        public DateTime EmployeeBirthDate { get; set; }
        public List<ORDERS> Orders { get; set; }



    }
}

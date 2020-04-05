using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class ContributionDisplayModel
    {
        public int ContributionID { get; set; }
        public int CWID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string Division { get; set; }
        public string DepartmentName { get; set; }
        public string AgencyName { get; set; }
        public string UWType { get; set; }
        public double UWMonthly { get; set; }
        public int UWMonths { get; set; }
        public double uwcontributionamount { get; set; }
        public int UWYear { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace UnitedWayPrototypeApplication.Models
{
    public class ContributionListModel
    {
        [Display(Name = "Contribution ID")]
        public int ContributionID { get; set; }

        //     [DataType(DataType.Text)]
        [Display(Name = "CWID")]
        public int CWID { get; set; }

        [Display(Name = "First Name")]
        public string EmployeeFirstName { get; set; }

        [Display(Name = "Last Name")]
        public string EmployeeLastName { get; set; }

        [Display(Name = "Division")]
        public string Division { get; set; }

        [Display(Name = "Department")]
        public string DepartmentName { get; set; }

        [Display(Name = "Agency ID")]
        public int AgencyID { get; set; }

        [Display(Name = "Agency Name")]
        public string AgencyName { get; set; }

        [Display(Name = "Type of Contribution")]
        public string UWType { get; set; }

        [Display(Name = "Check Number (optional)")]
        public string CheckNumber { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Monthly Amount")]
        public double UWMonthly { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Number of Months")]
        public int UWMonths { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Total Contribution Amount")]
        public double uwcontributionamount { get; set; }

        [Display(Name = "Giving Year")]
        public int UWYear { get; set; }


    }
}
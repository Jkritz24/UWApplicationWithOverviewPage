using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UnitedWayPrototypeApplication.Models
{
    public class ContributionModel
    {
        [Key] [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Display(Name = "Contribution ID")]
        public int ContributionID { get; set; }

   //     [DataType(DataType.Text)]
        [Display(Name = "CWID")]
        [Range(10000000, 99999999, ErrorMessage = "You need to enter a valid CWID")]
        [Required(ErrorMessage = "You must enter an employee CWID.")]
        [ForeignKey("CWID")]
        public int CWID { get; set; }
        /*
        [DataType(DataType.Text)]
        [Display(Name = "Employee First Name")]
        [Required(ErrorMessage = "You must enter an employee first name.")]
        public string contributionfname { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Employee Last Name")]
        [Required(ErrorMessage = "You must enter an employee last name.")]
        public string contributionlname { get; set; }
        */
     //   [DataType(DataType.Text)]
        [Display(Name = "Agency ID")]
        [Required(ErrorMessage = "You must enter an Agency ID (Enter '0' if there is no agency).")]
        [Range(0,10000000, ErrorMessage = "Agency ID must be valid (Enter '0' if there is no agency).")]
        public int AgencyID { get; set; }

        [Display(Name = "Type of Contribution")]
        [Required(ErrorMessage = "You must select a contribution type.")]
        public string UWType { get; set; }

        [Display(Name = "Check Number (optional)")]
        public string CheckNumber { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Monthly Amount")]
        [Required(ErrorMessage ="You must enter the monthly amount.")]
        public double UWMonthly { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Number of Months")]
        [Range(0, 12, ErrorMessage = "Number of Months must be a valid number.")]
        [Required(ErrorMessage = "You must enter the number of months.")]
        public int UWMonths { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Total Contribution Amount")]
        public double uwcontributionamount { get; set; }

        [Display(Name = "Giving Year")]
        public int UWYear { get; set; }

        // Commented out in HTML
        [DataType(DataType.Date)]
        [Display(Name = "Date of Contribution")]
        public System.DateTime UWDateCreated { get; set; } = DateTime.Now;

        // Commented out in HTML
        [DataType(DataType.Date)]
        [Display(Name = "Date of Edit")]
        public System.DateTime UWDateLastEdited { get; set; } = DateTime.Now;
    }
}
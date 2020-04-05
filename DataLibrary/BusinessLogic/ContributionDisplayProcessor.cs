using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public class ContributionDisplayProcessor
    {
        public static List<ContributionDisplayModel> LoadContributionDisplay()
        {
            string sql = @"SELECT contributionid, cwid, employeefirstname, employeelastname, division, departmentname, agencyname, uwmonthly, uwmonths, uwcontributionamount, uwtype, uwyear
                            FROM ContributionDisplay;";

            return SQLDataAccess.LoadData<ContributionDisplayModel>(sql);
        }
    }
}

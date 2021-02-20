using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Momenty.Web.DAL.Entities
{
    public class FundReturnRate
    {
        public int Id { get; set; }
        public string FundName { get; set; }
        public double? OneWeekReturn { get; set; }
        public double? OneMonthReturn { get; set; }
        public double? ThreeMonthReturn { get; set; }
        public double? OneYearReturn { get; set; }
        public string SortedOn { get; set; }
        public DateTime DateOfScrape { get; set; }
    }
}
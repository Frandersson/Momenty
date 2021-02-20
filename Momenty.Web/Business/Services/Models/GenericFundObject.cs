using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Momenty.Web.Business.Services.Models
{
    public class GenericFundObject
    {
        public string Name { get; set; }
        public double? OneWeekReturnRate { get; set; }
        public double? OneMonthReturnRate { get; set; }
        public double? ThreeMonthReturnRate { get; set; }
        public double? OneYearReturnRate { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Momenty.Web.DAL.Entities
{
    public class FundReturnRate
    {
        public int FundId { get; set; }
        public decimal OneMonthReturn { get; set; }
        public decimal ThreeMonthReturn { get; set; }
        public decimal OneYearReturn { get; set; }
        public DateTime DateOfScrape { get; set; }
    }
}
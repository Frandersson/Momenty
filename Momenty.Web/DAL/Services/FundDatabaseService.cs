using Momenty.Web.Business.Services.Models;
using Momenty.Web.DAL.Entities;
using Momenty.Web.DAL.Constants;
using Momenty.Web.DAL.Repositories;
using System;
using System.Collections.Generic;

namespace Momenty.Web.DAL.Services
{
    public class FundDatabaseService : IFundDatabaseService
    {
        private IFundRepository _fundRepository;

        public FundDatabaseService()
        {
            _fundRepository = new FundRepository();
        }

        public void Save(GenericFundObject fund)
        {
            FundReturnRate fundToBeInserted = new FundReturnRate
            {
                FundName = fund.Name,
                ThreeMonthReturn = fund.ThreeMonthReturnRate,
                SortedOn = SortedOnTypes.ThreeMonths,
                DateOfScrape = DateTime.Now
            };

            _fundRepository.Insert(fundToBeInserted);
        }
    }
}
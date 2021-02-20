using Momenty.Web.Business.Services.Interfaces;
using Momenty.Web.Business.Services.Models;
using Momenty.Web.DAL.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;

namespace Momenty.Web.Business.Services
{
    public class ScrapeService : IScrapeService
    {
        private HttpClient _client;
        private IFundDatabaseService _fundDbService;

        public ScrapeService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(ConfigurationManager.AppSettings["MomentyScraperBaseUrl"]);
            _fundDbService = new FundDatabaseService();
        }

        public List<GenericFundObject> ScrapeFunds()
        {
            List<GenericFundObject> fundList = new List<GenericFundObject>();

            var response = _client.GetAsync("getreturnrates").Result;
            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync();

                if (ValidateScrape(jsonString.Result))
                {
                    fundList = JsonConvert.DeserializeObject<List<GenericFundObject>>(jsonString.Result);
                }
            } 

            foreach(var fund in fundList)
            {
                _fundDbService.Save(fund);
            }

            return fundList;
        }

        private bool ValidateScrape(string jsonString)
        {
            // Validation...
            return true;
        }
    }
}
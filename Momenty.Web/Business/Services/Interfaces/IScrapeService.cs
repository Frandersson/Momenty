using Momenty.Web.Business.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Momenty.Web.Business.Services.Interfaces
{
    public interface IScrapeService
    {
        List<GenericFundObject> ScrapeFunds();
    }
}
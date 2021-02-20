using Momenty.Web.Business.Services.Models;
using System.Collections.Generic;

namespace Momenty.Web.DAL.Services
{
    public interface IFundDatabaseService
    {
        void Save(GenericFundObject fund);
    }
}
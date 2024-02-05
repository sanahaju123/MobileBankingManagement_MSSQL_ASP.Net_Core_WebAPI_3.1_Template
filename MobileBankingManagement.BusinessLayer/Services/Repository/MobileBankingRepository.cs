using MobileBankingManagement.BusinessLayer.ViewModels;
using MobileBankingManagement.DataLayer;
using MobileBankingManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBankingManagement.BusinessLayer.Services.Repository
{
    public class MobileBankingRepository : IMobileBankingRepository
    {
        private readonly InsuranceDbContext _dbContext;
        public MobileBankingRepository(InsuranceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<MobileBanking> CreateFeature(MobileBanking MobileBanking)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteFeatureById(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<MobileBanking> GetAllFeatures()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<MobileBanking> GetFeatureById(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<MobileBanking> UpdateFeature(MobileBankingViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
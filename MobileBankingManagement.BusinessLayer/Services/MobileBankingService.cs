using MobileBankingManagement.BusinessLayer.interfaces;
using MobileBankingManagement.BusinessLayer.Services.Repository;
using MobileBankingManagement.BusinessLayer.ViewModels;
using MobileBankingManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileBankingManagement.BusinessLayer.Services
{
    public class MobileBankingService : IMobileBankingService
    {
        private readonly IMobileBankingRepository _MobileBankingRepository;

        public MobileBankingService(IMobileBankingRepository MobileBankingRepository)
        {
            _MobileBankingRepository = MobileBankingRepository;
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
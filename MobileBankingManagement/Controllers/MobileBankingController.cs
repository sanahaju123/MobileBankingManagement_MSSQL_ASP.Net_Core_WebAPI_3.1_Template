using MobileBankingManagement.BusinessLayer.interfaces;
using MobileBankingManagement.BusinessLayer.ViewModels;
using MobileBankingManagement.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace MobileBankingManagement.Controllers
{
    [ApiController]
    public class MobileBankingController : ControllerBase
    {
        private readonly IMobileBankingService _MobileBankingService;
        public MobileBankingController(IMobileBankingService MobileBankingService)
        {
            _MobileBankingService = MobileBankingService;
        }

        [HttpPost]
        [Route("create-feature")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateFeature([FromBody] MobileBanking model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("update-feature")]
        public async Task<IActionResult> UpdateFeature([FromBody] MobileBankingViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("delete-feature")]
        public async Task<IActionResult> DeleteFeature(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("get-feature-by-id")]
        public async Task<IActionResult> GetFeatureById(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("get-all-features")]
        public async Task<IEnumerable<MobileBanking>> GetAllFeatures()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
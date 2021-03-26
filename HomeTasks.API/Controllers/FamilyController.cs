using System;
using HomeTasks.Business.Family;
using HomeTasks.Models.Entities.MethodModels.FamilyModel;
using HomeTasks.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeTasks.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FamilyController : ControllerBase, IFamily
    {
        private readonly ILogger<FamilyController> _logger;
        private readonly IFamilyBusiness _business;

        public FamilyController(ILogger<FamilyController> logger, IFamilyBusiness business)
        {
            _logger = logger;
            _business = business;
        }

        /// <summary>
        /// Register a new family
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        [Route("")]
        public FamilyRegisterNewResponseModel RegisterNew([FromBody] FamilyRegisterNewRequestModel request)
        {
            try
            {
                return _business.RegisterNew(request);
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
                throw new NotImplementedException();
            }
        }
    }
}
using System;
using HomeTasks.Models.Entities;
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

        public FamilyController(ILogger<FamilyController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("[action]")]
        public BaseResponse RegisterNew(BaseRequest request)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
                throw new NotImplementedException();
            }
        }
    }
}
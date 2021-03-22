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
        public int RegisterNew(BaseRequest request)
        {
            try
            {
                return 0;
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
                return -1;
            }
        }
    }
}
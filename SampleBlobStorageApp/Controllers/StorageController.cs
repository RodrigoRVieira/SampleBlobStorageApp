using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SampleBlobStorageApp.Interfaces;

namespace SampleBlobStorageApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorageController : Controller
    {
        IStorage _storageService;
        IConfiguration _configuration;

        public StorageController(
            IStorage storageService,
            IConfiguration configuration)
        {
            _storageService = storageService;
            _configuration = configuration;
        }

        [HttpGet("GetToken")]
        public ActionResult<string> GetToken()
        {
            return _storageService.GetToken(_configuration["AzureStorage:ConnectionString"]);
        }
    }
}
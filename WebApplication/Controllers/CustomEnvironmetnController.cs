namespace WebApplication.Controllers
{
    #region

    using Microsoft.AspNetCore.Mvc;

    #endregion

    [ApiController]
    [Route("api/[controller]")]
    public class CustomEnvironmetnController : Controller
    {
        #region Fields

        private readonly ILogger<CustomEnvironmetnController> _logger;
        private readonly IConfiguration _configuration;

        #endregion

        #region Constructor

        public CustomEnvironmetnController(
            ILogger<CustomEnvironmetnController> logger,
            IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        #endregion

        #region Methods

        [HttpGet]
        public async Task<IActionResult> GetEnvironmentConfig()
        {
            var confg = await Task.Run(() => _configuration.GetSection("TheConfiguration").Value);

            return Ok(confg);
        }

        #endregion
    }
}

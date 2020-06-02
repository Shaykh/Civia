using Civia.WebLocal.Localize;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Civia.WebLocal.Controllers
{
    [Route("{culture:culture}/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IStringLocalizer<Resource> localizer;
        public HomeController(IStringLocalizer<Resource> localizer)
        {
            this.localizer = localizer;
        }

        public string Get()
        {
            return $"Message : '{localizer["Message"]}'";
        }
        
    }
}

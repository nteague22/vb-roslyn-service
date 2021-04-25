using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VbRoslynService.Services;

namespace VbRoslynService.Controllers
{
    [Route("web/{action}")]
    public class WebController : Controller
    {
        private readonly ILogger<WebController> _logger;
        private readonly IAnalysisLoader _analysisLoader;

        public WebController(ILogger<WebController> logger, IAnalysisLoader analysisLoader)
        {
            this._logger = logger;
            this._analysisLoader = analysisLoader;
        }

        [Route("project/{id:alpha}")]
        public Task<IActionResult> Project(string id)
        {
            // loads the project as current analysis target
            return Task.FromResult<IActionResult>(Ok());
        }
    }
}
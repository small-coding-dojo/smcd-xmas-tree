using Microsoft.AspNetCore.Mvc;
using smcd_xmas_tree.tests;

namespace SmcdXmasTree.API.Controllers
{
    [ApiController]
    [Route("SmcdXmasTree/")]
    public class SmcdXmasTreeController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<SmcdXmasTreeController> _logger;

        public SmcdXmasTreeController(ILogger<SmcdXmasTreeController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        [Route("{n:int=1}")]
        public object GetTree(int n)
        {
            return new {tree = ChristmasTreeGenerator.ChristmasTree(n)};
        }

    
    }

}
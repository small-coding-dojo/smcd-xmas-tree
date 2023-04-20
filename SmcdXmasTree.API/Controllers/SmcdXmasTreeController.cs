using Microsoft.AspNetCore.Mvc;
using smcd_xmas_tree.tests;

namespace SmcdXmasTree.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SmcdXmasTreeController : ControllerBase
    {
        [HttpGet()]
        [Route("{n:int=1}")]
        public object GetTree(int n)
        {
            return new { tree = ChristmasTreeGenerator.ChristmasTree(n) };
        }
    }
}

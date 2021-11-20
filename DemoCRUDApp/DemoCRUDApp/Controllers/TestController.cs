using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DemoCRUDApp.Interfaces;

namespace DemoCRUDApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTests()
        {
            try
            {
                var tests = await _testService.GetTestList();
                return Ok(tests);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

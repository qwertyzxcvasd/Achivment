using Microsoft.AspNetCore.Mvc;

namespace zxc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AchivmentController : ControllerBase
    {
        private static List<string> Summaries = new()
        {

        };

        private readonly ILogger<AchivmentController> _logger;

        public AchivmentController(ILogger<AchivmentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<string> Get()
        {
            return Summaries;
        }
        [HttpPost]
        public IActionResult Add(string name)
        {
            Summaries.Add(name);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(int index, string name)
        {
            if (index < 0 || index >= Summaries.Count)
            {
                return BadRequest("Такой индекс неверный!");
            }
            Summaries[index] = name;
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int index)
        {
            if (index < 0 || index >= Summaries.Count)
            {
                return BadRequest("Такой индекс неверный!");
            }
            Summaries.RemoveAt(index);
            return Ok();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using SalaryCalculator.Contract.IServices;

namespace SalaryCalculator.UI.Controllers
{
    [Route("api/[dataType]/[controller]")]
    [ApiController]
    public class SalariesController : ControllerBase
    {
        private readonly ISalaryService salaryService;

        public SalariesController(ISalaryService salaryService)
        {
            this.salaryService = salaryService;
        }
        [HttpPost]
        public IActionResult Add()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(salaryService.Get());
        }

        [HttpGet("{id}")]
        public IActionResult GetRange(int id)
        {
            return Ok(salaryService.GetById(id));
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SalaryCalculator.Contract.Dtos;
using SalaryCalculator.Contract.IServices;
using SalaryCalculator.OvertimePolicies;
using SalaryCalculator.UI.Convertors;
using SalaryCalculator.UI.Enums;
using static System.Net.Mime.MediaTypeNames;

namespace SalaryCalculator.UI.Controllers
{
    [Route("api")]
    [ApiController]
    public class SalariesController : ControllerBase
    {
        private readonly ISalaryService salaryService;
        private readonly ConvertFactory convertFactory;
        private readonly IOverTimeCalculator overTimeCalculator;
        private readonly ICalculatorInvoker calculatorInvoker;

        public SalariesController(ISalaryService salaryService,
                                  ConvertFactory convertFactory,
                                  IOverTimeCalculator overTimeCalculator,
                                  ICalculatorInvoker calculatorInvoker)
        {
            this.salaryService = salaryService;
            this.convertFactory = convertFactory;
            this.overTimeCalculator = overTimeCalculator;
            this.calculatorInvoker = calculatorInvoker;
        }

        [HttpPost("{dataType}/[controller]")]
        public IActionResult Add(InputDataType dataType, [FromForm] MonthlySalaryAddDto dto)
        {
            var convertedData = convertFactory.GetConvertorInstance(dataType).Convert(dto.Data);
            
            salaryService.Add(convertedData, calculatorInvoker.SelectMethod(dto.OverTimeCalculator));
            return Created("", dto);
        }


        [HttpPut("{dataType}/[controller]")]
        public IActionResult Update([FromForm] MonthlySalaryAddDto dto)
        {
            return Ok();
        }

        [HttpDelete("[controller]")]
        public IActionResult Delete(int id)
        {
            return Ok(salaryService.Delete(id));
        }

        [HttpGet("[controller]")]
        public IActionResult Get()
        {
            return Ok(salaryService.Get());
        }

        [HttpGet("[controller]/GetRange")]
        public IActionResult GetRange()
        {
            return Ok();
        }
    }
}

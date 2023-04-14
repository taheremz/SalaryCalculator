using AutoMapper;
using SalaryCalculator.Contract.Dtos;
using SalaryCalculator.Contract.IServices;
using SalaryCalculator.Infrustructure.IRepositories;
using SalaryCalculator.Infrustructure.Models;

namespace SalaryCalculator.Application.Services
{
    public class SalaryService : ISalaryService
    {

        private const int tax = 9;
        private readonly IReadRepository readRepository;
        private readonly IWriteRepository writeRepository;
        private readonly IMapper mapper;

        public SalaryService(IReadRepository readRepository, IWriteRepository writeRepository, IMapper mapper)
        {
            this.readRepository = readRepository;
            this.writeRepository = writeRepository;
            this.mapper = mapper;
        }
        public bool Add(MonthlySalaryDto dto, decimal OverTime)
        {
            bool result = false;
            decimal monthlySalaryMinusTax = dto.BasicSalary + dto.Allowance + dto.Transportation + OverTime;
            dto.MonthlySalary = monthlySalaryMinusTax - CalculateTax(monthlySalaryMinusTax);
            var mapped = mapper.Map<SalaryDetails>(dto);
            var rowAffected = writeRepository.Add(mapped);
            if (rowAffected > 0)
                result = true;
            return result;
        }
        private decimal CalculateTax(decimal wholeSalary)
        {
            return wholeSalary / tax;
        }

        public bool Delete(int id)
        {
            return writeRepository.Delete(id);
        }
        public bool Update(MonthlySalaryDto dto)
        {
            bool result = false;
            var mapped = mapper.Map<SalaryDetails>(dto);
            var rowAffected = writeRepository.Update(mapped);
            if (rowAffected > 0)
                result = true;
            return result;
        }

        public List<MonthlySalaryDto> Get()
        {

            var details = readRepository.GetAll().ToList();
            var result = mapper.Map<List<MonthlySalaryDto>>(details);
            return result;
        }

        public List<MonthlySalaryDto> GetByDate(DateTime? fromDate, DateTime? toDate)
        {
            var details = readRepository.GetByDate(fromDate, toDate).ToList();
            var result = mapper.Map<List<MonthlySalaryDto>>(details);
            return result;
        }

    }
}

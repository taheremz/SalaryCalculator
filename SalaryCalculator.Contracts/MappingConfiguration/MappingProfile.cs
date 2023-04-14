using AutoMapper;
using SalaryCalculator.Contract.Dtos;
using SalaryCalculator.Infrustructure.Models;

namespace SalaryCalculator.Contract.MappingConfiguration
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<SalaryDetails, MonthlySalaryDto>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Lab.Domain.Dtos.Responses;
using Lab.Domain.Model.EmployeeAggregate;

namespace Lab.Business.Mapper
{
    public class EmployeeMapper : Profile
    {
        
        public EmployeeMapper() {
            CreateMap<Employee, EmployeeResponse>()
                .ForMember(empResponse => empResponse
                .NameEmployee, m=> m.MapFrom(empOrigin => empOrigin
                .name));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Lab.Business.Interfaces;
using Lab.Domain.Dtos.Responses;
using Lab.Domain.Model.EmployeeAggregate;
using Lab.Infra.Repository.implements;

namespace Lab.Business.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository();
        private readonly IMapper _mapper;

        public EmployeeService(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public void Add(Employee employee)
        {
            _employeeRepository.Add(employee);
            
        }

        public EmployeeResponse? Get(int id)
        {
            var employee = _employeeRepository.Get(id);
            var employeeResponse = _mapper.Map<EmployeeResponse>(employee);
            return employeeResponse;
        }

        public List<EmployeeResponse> GetAll(int pageNumber, int itemQuantity)
        {
            return _employeeRepository.GetAll(pageNumber, itemQuantity);
        }
    }
}

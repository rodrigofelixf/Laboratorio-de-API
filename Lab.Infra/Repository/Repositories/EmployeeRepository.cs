using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Domain.Dtos.Responses;
using Lab.Domain.Model.EmployeeAggregate;
using Lab.Infra.Connection;
using Lab.Infra.Repository.interfaces;

namespace Lab.Infra.Repository.implements
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly ConnectionContext _connectionContext = new ConnectionContext();



        public void Add(Employee employee)
        {
            _connectionContext.Employees.Add(employee);
            _connectionContext.SaveChanges();
        }


        public List<EmployeeResponse> GetAll(int pageNumber, int itemQuantity)
        {
            return _connectionContext.Employees
                .Select(employee => new EmployeeResponse
                {
                    Id = employee.id,
                    NameEmployee = employee.name,
                    Photo = employee.photo,
                })
                .Skip(pageNumber
                 * itemQuantity)
                .Take(itemQuantity)
                .ToList();
        }

        public Employee? Get(int id)
        {
            return _connectionContext.Employees.Find(id);
        }
    }
}

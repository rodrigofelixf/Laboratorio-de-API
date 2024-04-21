using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Domain.Dtos.Responses;
using Lab.Domain.Model.EmployeeAggregate;

namespace Lab.Business.Interfaces
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        List<EmployeeResponse> GetAll(int pageNumber, int itemQuantity);

        EmployeeResponse? Get(int id);
    }
}

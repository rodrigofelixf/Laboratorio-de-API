using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Domain.Dtos.Responses
{
    public record EmployeeResponse
    {
        public int Id { get; init; }
        public string NameEmployee { get; init; }
        public string? Photo { get; init; }
    }
}

using Lab.Api.ViewModel;
using Lab.Business.Interfaces;
using Lab.Domain.Model.EmployeeAggregate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Api.Controllers
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(IEmployeeService employeeService, ILogger<EmployeeController> logger)
        {
            _employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

      
        [HttpPost]
        public IActionResult Add([FromForm] EmployeeViewModel employeeView) {
            var filePath = Path.Combine("Storage", employeeView.Photo.FileName);
            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            employeeView.Photo.CopyTo(fileStream);

            var employee = new Employee(employeeView.Name, employeeView.Age,filePath);
           _employeeService.Add(employee);

           return Ok();
        }

      
        [HttpPost]
        [Route("{id}/download")]
        public IActionResult DownloadPhoto(int id)
        {
            var employee = _employeeService.Get(id);
            var dataBytes = System.IO.File.ReadAllBytes(employee.Photo);

            return File(dataBytes, "image/png");

        } 

       
        [HttpGet]
        public IActionResult GetAll(int pageNumber, int itemQuantity)
        {
            var employees = _employeeService.GetAll(pageNumber, itemQuantity);
            _logger.LogInformation("test");
            return Ok(employees); 
        }
        

        [HttpGet]
        [Route("{id}")]
        public IActionResult FindEmployeeById(int id)
        {
            var employeeResponse = _employeeService.Get(id);
            _logger.LogInformation("test");
            return Ok(employeeResponse);
        }
    }
}

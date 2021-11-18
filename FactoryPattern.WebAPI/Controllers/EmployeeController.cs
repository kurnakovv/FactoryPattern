using FactoryPattern.BL.Employees.Abstract;
using FactoryPattern.BL.Factories.Employees;
using FactoryPattern.WebAPI.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FactoryPattern.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly ICollection<IEmployee> _employees = new List<IEmployee>();
    private IEmployeeFactory _employeeFactory;

    [HttpGet]
    public ActionResult<ICollection<IEmployee>> Get()
    {
        return Ok(_employees);
    }

    [HttpPost]
    public ActionResult<IEmployee> Create(EmployeeDTO employeeDTO)
    {
        _employeeFactory = new EmployeeFactory(employeeDTO.Name, employeeDTO.Salary);
        var employee = _employeeFactory.Create(employeeDTO.Type);
        _employees.Add(employee);

        return Ok(employee);
    }
}

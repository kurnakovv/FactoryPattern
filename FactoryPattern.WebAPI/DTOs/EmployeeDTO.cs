
using FactoryPattern.BL.Factories.Employees;

namespace FactoryPattern.WebAPI.DTOs;

public class EmployeeDTO
{
    public string Name { get; set; }
    public int Salary { get; set; }
    public EmployeeType Type { get; set; }
}

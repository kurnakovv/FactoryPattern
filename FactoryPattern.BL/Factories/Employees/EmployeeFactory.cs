using FactoryPattern.BL.Employees;
using FactoryPattern.BL.Employees.Abstract;

namespace FactoryPattern.BL.Factories.Employees
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public EmployeeFactory(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public IEmployee Create(EmployeeType type)
        {
            return type switch
            {
                EmployeeType.Developer => new Developer(Name, Salary),
                EmployeeType.Manager => new Manager(Name, Salary),
                EmployeeType.Plumber => new Plumber(Name, Salary),
                _ => throw new ArgumentException(nameof(type)),
            };
        }
    }
}

using FactoryPattern.BL.Employees.Abstract;

namespace FactoryPattern.BL.Factories.Employees
{
    // You can use Generic<T>.
    public interface IEmployeeFactory
    {
        string Name { get; set; }
        int Salary { get; set; }
        IEmployee Create(EmployeeType type);
    }
}

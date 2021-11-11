using FactoryPattern.BL.Employees.Abstract;

namespace FactoryPattern.BL.Factories.Employees
{
    // You can use Generic<T>.
    public interface IEmployeeFactory
    {
        string Name { get; }
        int Salary { get; }
        IEmployee Create(EmployeeType type);
    }
}

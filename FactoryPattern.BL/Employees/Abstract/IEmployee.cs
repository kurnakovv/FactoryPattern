namespace FactoryPattern.BL.Employees.Abstract
{
    public interface IEmployee
    {
        string Name { get; }
        int Salary { get; }
        DateTime HiringDate { get; }
        string Type { get; }
        void Work();
    }
}

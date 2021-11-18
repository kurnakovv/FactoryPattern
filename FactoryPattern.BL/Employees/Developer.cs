using FactoryPattern.BL.Employees.Abstract;

namespace FactoryPattern.BL.Employees
{
    public class Developer : IEmployee
    {
        public string Name { get; }

        public int Salary { get; set; }

        public DateTime HiringDate { get; } = DateTime.Now;

        public string Type => GetType().Name;

        public Developer(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public void Work()
        {
            // Logic.
        }
    }
}

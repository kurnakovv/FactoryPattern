using FactoryPattern.BL.Employees.Abstract;

namespace FactoryPattern.BL.Employees
{
    public class Plumber : IEmployee
    {
        public string Name { get; }

        public int Salary { get; set; }

        public DateTime HiringDate { get; } = DateTime.Now;

        public Plumber(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}

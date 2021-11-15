using FactoryPattern.BL.Employees;
using FactoryPattern.BL.Employees.Abstract;
using FactoryPattern.BL.Factories.Employees;
using Xunit;

namespace FactoryPattern.Tests.Factories.Employees
{
    public class EmployeeFactoryTest
    {
        [Fact]
        public void Create_CanCreateDeveloper_Developer()
        {
            // Arrange
            IEmployeeFactory employeeFactory = new EmployeeFactory("Maksim", 100);

            // Act
            IEmployee result = employeeFactory.Create(EmployeeType.Developer);

            // Assert
            Assert.IsType<Developer>(result);
            Assert.IsNotType<Manager>(result);
            Assert.IsNotType<Plumber>(result);
        }

        [Fact]
        public void Create_CanCreateManager_Manager()
        {
            // Arrange
            IEmployeeFactory employeeFactory = new EmployeeFactory("Vasia", 150);

            // Act
            IEmployee result = employeeFactory.Create(EmployeeType.Manager);

            // Assert
            Assert.IsType<Manager>(result);
            Assert.IsNotType<Developer>(result);
            Assert.IsNotType<Plumber>(result);
        }

        [Fact]
        public void Create_CanCreatePlumber_Plumber()
        {
            // Arrange
            IEmployeeFactory employeeFactory = new EmployeeFactory("Peter", 50);

            // Act
            IEmployee result = employeeFactory.Create(EmployeeType.Plumber);

            // Assert
            Assert.IsType<Plumber>(result);
            Assert.IsNotType<Manager>(result);
            Assert.IsNotType<Developer>(result);
        }

        [Fact]
        public void Create_CannotCreateInvalidEmployee_ArgumentException()
        {
            // Arrange
            IEmployeeFactory employeeFactory = new EmployeeFactory("Invalid employee", 100);

            // Act
            Action act = () => employeeFactory.Create(EmployeeType.InvalidEmployee);

            // Assert
            Assert.Throws<ArgumentException>(act);
        }
    }
}

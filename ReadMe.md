# FactoryPattern

## How to use:

``` cs
IEmployeeFactory employeeFactory = new EmployeeFactory("Employee name", 100);
IEmployee employee1 = employeeFactory.Create(EmployeeType.Developer);

employeeFactory.Name = "New employee name";
employeeFactory.Salary = 150;
IEmployee employee2 = employeeFactory.Create(EmployeeType.Plumber);

employee1.Work();
employee2.Work();
```

``` cs
IEmployeeFactory employeeFactory = new EmployeeFactory("Employee name", 100);
IEmployee employee1 = employeeFactory.Create(EmployeeType.Developer);
IEmployee employee2 = employeeFactory.Create(EmployeeType.Manager);

employee1.Work();
employee2.Work();
```

## How it is work:

``` cs
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
```
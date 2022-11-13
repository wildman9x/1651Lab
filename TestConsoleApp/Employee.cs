// Employee class with int ID readonly
//  string firstname, lastname readonly
// int salary read-write
namespace TestConsoleApp{
public class Employee {
    public int ID { get; }
    public string FirstName { get;  }
    public string LastName { get; }
    public int Salary { get; set; }

    public Employee(int id, string firstName, string lastName, int salary) {
        ID = id;
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public string fullName() {
        return FirstName + " " + LastName;
    }

    public int annualSalary() {
        return Salary * 12;
    }

    public int raiseSalary(int percent) {
        return Salary += (Salary * percent / 100);
    }

    public override string ToString() {
        return "Employee[id=" + ID + ", name=" + fullName() + ", salary=" + Salary + "]";
    }
}}
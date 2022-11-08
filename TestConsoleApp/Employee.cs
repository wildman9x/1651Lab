// Employee class with int ID readonly
//  string firstname, lastname readonly
// int salary read-write

public class Employee {
    private int ID { get; }
    private string FirstName { get; }
    private string LastName { get; }
    private int Salary { get; set; }

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
}
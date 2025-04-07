public class Manager : Employee
{
    public Manager(string firstName, string lastName, int age, bool isEmployeeOfMonth) : base(firstName, lastName, age, isEmployeeOfMonth) { }

    public void FirePerson(Employee employee)
    {
        employee.isFired = true;
    }

    public override string ToString()
    {
        return base.ToString() + $" Manager";
    }
}

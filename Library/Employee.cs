namespace Library
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public int age;
        public string position;

        public Employee(string name, string lastName, int age, string position)
        {
            this.firstName = name;
            this.lastName = lastName;
            this.age = age;
            this.position = position;
        }

        public void EmployeeInfoPrint() => Console.WriteLine($"Name: {firstName}, LastName: {lastName}, age: {age}, Position: {position}");
    }
}

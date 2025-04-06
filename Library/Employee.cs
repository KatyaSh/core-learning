namespace Library
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public Employee(string name, string lastName, int age, string position)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
            Position = position;
        }

        public void EmployeeInfoPrint() => Console.WriteLine($"Name: {FirstName}, LastName: {LastName}, age: {Age}, Position: {Position}");
    }
}

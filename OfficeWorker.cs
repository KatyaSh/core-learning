public class OfficeWorker : Employee
{
    public string WorkerType { get; set; }
    public OfficeWorker(string firstName, string lastName, int age, bool isEmployeeOfMonth, string workerType) : base(firstName, lastName, age, isEmployeeOfMonth) 
    { 
        WorkerType = workerType;
    }

    public override string ToString()
    {
        return base.ToString() + $" Worker type: {WorkerType}";
    }
}

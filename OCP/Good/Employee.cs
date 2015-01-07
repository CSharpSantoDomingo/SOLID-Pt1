namespace OCP.Good
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal TotalOfSales { get; set; }
        public abstract decimal CalculateComission();
    }
}

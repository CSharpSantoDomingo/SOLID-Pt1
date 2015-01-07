namespace OCP.Good
{
    public class EmployeePaymentService
    {
        public double GetNetSalary(Employee employee)
        {
            double netSalary = employee.Salary + employee.CalculateComission();
            return netSalary;
        }
    }
}

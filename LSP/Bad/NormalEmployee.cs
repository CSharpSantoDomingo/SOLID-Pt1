namespace OCP.Good
{
    public class NormalEmployee : Employee
    {
        public override decimal CalculateComission()
        {
            var result = TotalOfSales * 0.5M;
            return result;
        }

        public override decimal CalculateHealthInsurancePayment()
        {
            throw new System.NotImplementedException();
        }
    }
}

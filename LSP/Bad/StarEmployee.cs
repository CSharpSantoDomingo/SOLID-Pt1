namespace OCP.Good
{
    public class StarEmployee : Employee
    {
        public override decimal CalculateComission()
        {
            var result = TotalOfSales * 0.10M;
            return result;
        }

        public override decimal CalculateHealthInsurancePayment()
        {
            //Logic for Insurance calculation

            return 0;
        }
    }
}

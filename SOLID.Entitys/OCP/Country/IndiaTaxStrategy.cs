using SOLID.Entitys.OCP.Interfaces;

namespace SOLID.Entitys.OCP.Country
{
    public class IndiaTaxStrategy : ITaxStrategy
    {
        public string CountryCode => "India";

        public decimal CalculateTax(decimal income, decimal deduction)
        {
            decimal taxableIncome = income - deduction;
            return taxableIncome * 0.10m;
        }
    }
}

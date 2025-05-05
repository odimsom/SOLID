using SOLID.Entitys.OCP.Interfaces;

namespace SOLID.Entitys.OCP.Country
{
    public class USATaxStrategy : ITaxStrategy
    {
        public string CountryCode => "USA";

        public decimal CalculateTax(decimal income, decimal deduction)
        {
            decimal taxableIncome = income - deduction;
            return taxableIncome * 0.15m;
        }
    }
}

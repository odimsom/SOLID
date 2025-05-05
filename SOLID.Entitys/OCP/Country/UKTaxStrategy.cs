using SOLID.Entitys.OCP.Interfaces;

namespace SOLID.Entitys.OCP.Country
{
    public class UKTaxStrategy : ITaxStrategy
    {
        public string CountryCode => "UK";

        public decimal CalculateTax(decimal income, decimal deduction)
        {
            decimal taxableIncome = income - deduction;
            return taxableIncome * 0.12m;
        }
    }
}

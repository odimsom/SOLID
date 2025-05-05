using SOLID.Entitys.OCP.Interfaces;

namespace SOLID.Entitys.OCP
{
    public class TaxCalculator
    {
        private readonly Dictionary<string, ITaxStrategy> _strategies;

        public TaxCalculator(IEnumerable<ITaxStrategy> strategies)
        {
            _strategies = strategies.ToDictionary(s => s.CountryCode);
        }

        public decimal Calculate(decimal income, decimal deduction, string country)
        {
            if (!_strategies.TryGetValue(country, out var strategy))
                throw new NotSupportedException($"No se soporta el país '{country}'.");

            return strategy.CalculateTax(income, deduction);
        }
    }

}

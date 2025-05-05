
namespace SOLID.Entitys.OCP.Interfaces
{
    public interface ITaxStrategy
    {
        string CountryCode { get; }
        decimal CalculateTax(decimal income, decimal deduction);
    }

}

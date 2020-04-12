using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppForSOLIDAndDesignPatterns.Core.Core.OCP
{
    public class TaxCalculatorForUs : ICountryTaxCalculator
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }
        public decimal CalculateTaxAmount()
        {
            var taxableIncome = TotalIncome - TotalDeduction;
            return taxableIncome * 30 / 100;
        }
    }
}

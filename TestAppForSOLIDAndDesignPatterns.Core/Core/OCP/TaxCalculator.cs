using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppForSOLIDAndDesignPatterns.Core.Core.OCP
{
    public class TaxCalculator
    {
        public decimal Calculate(ICountryTaxCalculator obj)
        {
            decimal taxAmount = obj.CalculateTaxAmount();
            return taxAmount;
        }
    }
}

using System;

namespace ComposingMethods
{
    public class SalaryProgram
    {
        private decimal _belowTaxSalaryLevel;
        private decimal _percentOfIncomeTaxation;

        public SalaryProgram(decimal belowTaxSalaryLevel, decimal percentOfIncomeTaxation)
        {
            _belowTaxSalaryLevel = belowTaxSalaryLevel;
            _percentOfIncomeTaxation = percentOfIncomeTaxation;
        }

        public decimal CalculateSalary(decimal higherSalaryLevel)
        {
            Console.WriteLine("Please input gross salary:");
            string userInput = Console.ReadLine();

            decimal grossSalary;
            while (!decimal.TryParse(userInput, out grossSalary) || grossSalary < 0)
            {
                Console.WriteLine("Gross salary should be between 0 to {0}", decimal.MaxValue);
                userInput = Console.ReadLine();
            }

            return CalculateNetSalary(grossSalary, higherSalaryLevel);
        }

        private decimal CalculateNetSalary(decimal grossSalary, decimal higherSalaryLevel)
        {
            if (grossSalary < 0)
            {
                throw new ArgumentException("Provided gross salary is not correct.");
            }

            if (_belowTaxSalaryLevel == 0 || _percentOfIncomeTaxation == 0)
            {
                return grossSalary;
            }

            decimal taxSum = 0m;

            if (grossSalary <= _belowTaxSalaryLevel)
            {
                return grossSalary;
            }
            decimal tax = (grossSalary - _belowTaxSalaryLevel) * (_percentOfIncomeTaxation / 100);
            taxSum += tax;

            decimal taxableSalary = grossSalary;

            if (taxableSalary > higherSalaryLevel)
            {
                taxableSalary = higherSalaryLevel;
            }

            tax = (taxableSalary - _belowTaxSalaryLevel) * (_percentOfIncomeTaxation / 100);
            taxSum += tax;

            return grossSalary - taxSum;
        }
    }
}

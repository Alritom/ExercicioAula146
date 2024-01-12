using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseMod10Ex146.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {

        }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax = 0.0;
            if (NumberOfEmployees > 10)
            {
                tax += AnualIncome / 100.0 * 14.0;
            }
            else
            {
                tax += AnualIncome / 100.0 * 16.0;
            }
            return tax;
        }

        public override string ToString()
        {
            return Name
                + " : $ "
                + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

using System.Globalization;

namespace CourseMod10Ex146.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual() 
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0.0;
            if (AnualIncome < 20000.0 && HealthExpenditures == 0.0)
            {
                tax += AnualIncome / 100 * 15.0;
            }
            else if (AnualIncome < 20000.0 && HealthExpenditures != 0.0)
            {
                tax += (AnualIncome / 100 * 15) - (HealthExpenditures / 2);
            }
            else
            {
                tax += (AnualIncome / 100 * 25) - (HealthExpenditures / 2);
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

using Models;

namespace Services.Factories
{
    public static class Factory
    {
        /// <summary>
        /// Decides which class to instantiate.
        /// </summary>
        public static Salary GetAnualSalary(string type, double hourlySalary, double monthlySalary)
        {
            switch (type)
            {
                case "HourlySalaryEmployee":
                    return new HourSalary(hourlySalary);
                case "MonthlySalaryEmployee":
                    return new MontlySalary(monthlySalary);
                default:
                    return null;
            }
        }
    }
}

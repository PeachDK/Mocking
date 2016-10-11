using System;

namespace Mocking
{
    public class Employee
    {
        public int Id { get; internal set; }
        public MailBox MailBox { get; internal set; }
        public string Name { get; internal set; }
        public string Type { get; internal set; }
        public double Wage { get; internal set; }

        internal double CalculateWeeklySalary(int hours, double wage)
        {
            return hours * wage;
        }

        internal double CalulateAverageWeeklySalery(int hours, double wage, int person)
        {
            return (hours * wage) / person;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class FixedSalaryEmployee : Employee
    {
        public decimal MonthlySalary { get; set; }
        public int MonthsWorked { get; set; } = 1;

        public FixedSalaryEmployee(int id, string fullName, string email,
                                  ISystemAccess role, decimal monthlySalary)
            : base(id, fullName, email, role)
        {
            MonthlySalary = monthlySalary;
        }

        public override decimal CalculateSalary()
        {
            return MonthlySalary * MonthsWorked;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип оплаты: Фиксированная месячная оплата");
            Console.WriteLine($"Месячный оклад: {MonthlySalary:C}");
            Console.WriteLine($"Отработано месяцев: {MonthsWorked}");
        }
    }
}

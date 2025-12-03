using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class HourlySalaryEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }
        public int OvertimeHours { get; set; }
        public decimal OvertimeMultiplier { get; set; } = 1.5m;

        public HourlySalaryEmployee(int id, string fullName, string email,
                                   ISystemAccess role, decimal hourlyRate)
            : base(id, fullName, email, role)
        {
            HourlyRate = hourlyRate;
        }

        public override decimal CalculateSalary()
        {
            decimal regularPay = HoursWorked * HourlyRate;
            decimal overtimePay = OvertimeHours * HourlyRate * OvertimeMultiplier;
            return regularPay + overtimePay;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип оплаты: Почасовая оплата");
            Console.WriteLine($"Часовая ставка: {HourlyRate:C}/час");
            Console.WriteLine($"Отработано часов: {HoursWorked}");
            Console.WriteLine($"Сверхурочные часы: {OvertimeHours}");
            Console.WriteLine($"Коэффициент сверхурочных: {OvertimeMultiplier}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class FreelancerEmployee
    {
        public decimal ProjectRate { get; set; }
        public int CompletedProjects { get; set; }
        public decimal TaxRate { get; set; } = 0.13m; // Ставка НДФЛ 13%

        public FreelancerEmployee(int id, string fullName, string email,
                                 ISystemAccess role, decimal projectRate)
            : base(id, fullName, email, role)
        {
            ProjectRate = projectRate;
        }

        public override decimal CalculateSalary()
        {
            decimal grossSalary = ProjectRate * CompletedProjects;
            decimal taxAmount = grossSalary * TaxRate;
            return grossSalary - taxAmount; // Чистая зарплата после вычета НДФЛ
        }

        public decimal CalculateTaxAmount()
        {
            return ProjectRate * CompletedProjects * TaxRate;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип оплаты: Оплата за проект");
            Console.WriteLine($"Ставка за проект: {ProjectRate:C}");
            Console.WriteLine($"Завершено проектов: {CompletedProjects}");
            Console.WriteLine($"Ставка НДФЛ: {TaxRate:P0}");
            Console.WriteLine($"Сумма НДФЛ: {CalculateTaxAmount():C}");
        }
    }
}

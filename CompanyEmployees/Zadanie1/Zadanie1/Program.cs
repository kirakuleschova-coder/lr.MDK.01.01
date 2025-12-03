using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Login();
            void Logout();
            bool HasAccessToModule(string moduleName);
        }
        public class ManagerRole : ISystemAccess
        {
            private readonly List<string> _accessibleModules = new List<string>
    {
        "Dashboard",
        "Employees",
        "Reports",
        "Settings"
    };
            public void Login()
            {
                Console.WriteLine("Менеджер выполнил вход в систему");
            }
            public void Logout()
            {
                Console.WriteLine("Менеджер выполнил выход из системы");
            }

            public bool HasAccessToModule(string moduleName)
            {
                return _accessibleModules.Contains(moduleName);
            }

            public override string ToString() => "Роль: Менеджер";
        }
        public class AccountantRole : ISystemAccess
        {
            private readonly List<string> _accessibleModules = new List<string>
    {
        "Dashboard",
        "Payroll",
        "Invoices",
        "Reports",
        "Taxes"
    };

            public void Login()
            {
                Console.WriteLine("Бухгалтер выполнил вход в систему");
            }

            public void Logout()
            {
                Console.WriteLine("Бухгалтер выполнил выход из системы");
            }

            public bool HasAccessToModule(string moduleName)
            {
                return _accessibleModules.Contains(moduleName);
            }

            public override string ToString() => "Роль: Бухгалтер";
        }
        public class DeveloperRole : ISystemAccess
        {
            private readonly List<string> _accessibleModules = new List<string>
    {
        "Dashboard",
        "CodeRepository",
        "Tasks",
        "Documentation"
    };

            public void Login()
            {
                Console.WriteLine("Разработчик выполнил вход в систему");
            }

            public void Logout()
            {
                Console.WriteLine("Разработчик выполнил выход из системы");
            }

            public bool HasAccessToModule(string moduleName)
            {
                return _accessibleModules.Contains(moduleName);
            }

            public override string ToString() => "Роль: Разработчик";
        }
        public abstract class Employee
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public ISystemAccess SystemRole { get; set; }
            protected Employee(int id, string fullName, string email, ISystemAccess role)
            {
                Id = id;
                FullName = fullName;
                Email = email;
                SystemRole = role;
            }
            public abstract decimal CalculateSalary();
            public void Login() => SystemRole?.Login();
            public void Logout() => SystemRole?.Logout();
            public bool HasAccessToModule(string moduleName) =>
                SystemRole?.HasAccessToModule(moduleName) ?? false;

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"ФИО: {FullName}");
                Console.WriteLine($"Email: {Email}");
                Console.WriteLine(SystemRole?.ToString() ?? "Роль не назначена");
                Console.WriteLine($"Зарплата: {CalculateSalary():C}");
                Console.WriteLine();
            }
        }

    }
}

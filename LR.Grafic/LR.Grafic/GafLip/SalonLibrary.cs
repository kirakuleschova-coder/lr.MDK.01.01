using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GafLip
{
    public class SalonLibrary
    {
        public class Service
        {
            public string Name { get; set; }        
            public decimal Price { get; set; }      
            public int[] DailyCount { get; set; }    

            public decimal TotalRevenue
            {
                get
                {
                    if (DailyCount == null || DailyCount.Length == 0)
                        return 0;

                    return Price * DailyCount.Sum();
                }
            }

            public Service(string name, decimal price, int[] dailyCount)
            {
                Name = name;
                Price = price;
                DailyCount = dailyCount;
            }

            public Service() { }
        }

        public class Statistics
        {
            private List<Service> services = new List<Service>();

            public void AddService(Service service)
            {
                services.Add(service);
            }

            public List<Service> GetAllServices()
            {
                return services;
            }

            public Service GetServiceByName(string name)
            {
                return services.FirstOrDefault(s =>
                    s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            }

            public decimal GetTotalRevenue()
            {
                return services.Sum(s => s.TotalRevenue);
            }

            public void LoadTestData()
            {
                services.Clear();

                services.Add(new Service("Стрижка", 500m,
                    new int[] { 5, 6, 4, 7, 8, 5, 6 }));    

                services.Add(new Service("Окрашивание", 34000m,
                    new int[] { 2, 1, 3, 2, 4, 2, 1 }));

                services.Add(new Service("Маникюр", 4560m,
                    new int[] { 4, 5, 6, 5, 7, 6, 5 }));

                services.Add(new Service("Массаж", 15500m,
                    new int[] { 1, 2, 2, 1, 3, 2, 2 }));
            }
        }
    }
}
        
    


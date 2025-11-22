using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infested
{
    internal class Program
    {
        //Функция
        static void PrintModel(Car model)
        {
            Console.WriteLine(model.GetModel());
        }
        static void Main(string[] args)
        {
            //Первый автобобил
            Car avtomobil = new Car();

            avtomobil.SetModel("Lada");
            avtomobil.SetSpeed(150);
            //Console.WriteLine(avtomobil.GetModel() + "" + avtomobil.GetSpeed());
            PrintModel(avtomobil);

            //Второй автомобил
            Car avtomobil1 = new Car();
            avtomobil1.SetModel("Mersedez");
            avtomobil1.SetSpeed(300);
            //Console.WriteLine(avtomobil.GetModel() + "" + avtomobil.GetSpeed());

            PrintModel(avtomobil1);

            List<Car> avtomobili = new List<Car>();
            avtomobili.Add(avtomobil);
            avtomobili.Add(avtomobil1);


        }
    }
}

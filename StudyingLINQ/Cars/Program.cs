using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = ReadCarsFromFile("fuel.csv");
            var query = cars.Where(car => car.Manufacturer == "BMW")
                            .OrderByDescending(car => car.CityFE)
                            .ThenBy(car => car.Name)
                            .Select(car => new
                                {
                                    car.Name,
                                    car.CityFE,
                                    car.CombFE
                                }
                                );
            foreach (var car in query.Take(20))
            {
                Console.WriteLine($"{car.Name}: {car.CityFE}, {car.CombFE}");
            }

        }

        private static List<Car> ReadCarsFromFile(string path)
        {
            return File.ReadAllLines(path)
                .Skip(1)
                .Where(line => line.Length > 1)
                .Select(line => Car.ParseCarInfo(line))
                .ToList();

        }
    }
}

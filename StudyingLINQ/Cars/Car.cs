using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Car
    {
        public int Year { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Displacement { get; set; }
        public int NumCylinders { get; set; }
        public int CityFE { get; set; }
        public int HighwayFE { get; set; }
        public int CombFE { get; set; }


        internal static Car ParseCarInfo(string data)
        {
            var columns = data.Split(',');
            return new Car
            {
                Year = Int32.Parse(columns[0]),
                Manufacturer = columns[1],
                Name = columns[2],
                Displacement = Double.Parse(columns[3]),
                NumCylinders = Int32.Parse(columns[4]),
                CityFE = Int32.Parse(columns[5]),
                HighwayFE = Int32.Parse(columns[6]),
                CombFE = Int32.Parse(columns[7])

            };
        }
    }
}

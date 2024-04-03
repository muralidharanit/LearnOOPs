using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var house = new HouseBuilder()
                .BedRooms(2)
                .Garage(true)
                .Amenities("Swimming Pool", "Home Theater")
                .Build();

            Console.ReadLine();
        }
    }

    public class House
    {
        public int BedRooms { get; set; }
        public bool HasGarage { get; set; }
        public List<string> Amenities { get; set; }
    }

    public class HouseBuilder
    {
        private House _house = new House();
        public HouseBuilder BedRooms(int count)
        {
            _house.BedRooms = count;
            return this;
        }
        public HouseBuilder Garage(bool isGarage)
        {
            _house.HasGarage = isGarage;
            return this;
        }
        public HouseBuilder Amenities(params string[] amenities)
        {
            _house.Amenities = new List<string>();
            foreach (var amenitie in amenities)
            {
                _house.Amenities.Add(amenitie);
            }
            return this;
        }
        public House Build()
        {
            return _house;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework18._11._23
{
    internal class Building
    {
        public int number;
        public double height { get; set; }
        public int flats { get; set; }
        public int floors { get; set; }
        public int entrances { get; set; }
        private static int lastnumber = 0;

        internal Building(double height, int flats, int floors, int entrances)
        {
            number = BuildingNumber();
            this.height = height;
            this.flats = flats;
            this.floors = floors;
            this.entrances = entrances;
        }
        internal Building(int flats, int floors, int entrances)
        {
            this.flats = flats;
            this.floors = floors;
            this.entrances = entrances;
            number = BuildingNumber();
        }
        internal Building(double height)
        {
            number = BuildingNumber();
            this.height = height;
        }

        private static int BuildingNumber()
        {
            lastnumber++;
            return lastnumber;
        }

        public double FloorHeight()
        {
            return height / floors;
        }
        public int FlatsEntr()
        {
            return flats / entrances;
        }
        public int FlatsFloor()
        {
            return flats / floors;
        }
        public void Print()
        {
            Console.WriteLine($"Number of building: {number} \nHight of building: {height} \nAmount of flats: {flats} \nAmount of floors: {floors} \nAmount f entrances: {entrances}");
            Console.WriteLine("Floor height:" + FloorHeight());
            Console.WriteLine("Flats in entrance:" + FlatsEntr());
            Console.WriteLine("Flats on the floor:" + FlatsFloor());
        }
    }
}

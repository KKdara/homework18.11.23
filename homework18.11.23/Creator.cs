using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework18._11._23
{
    public class Creator
    {
        protected static Hashtable buildings = new Hashtable();
        private Creator() { } 
        static public int CreateBuild(double height)
        {
            Building building = new Building(height);
            buildings.Add(building.number, building);
            return building.number;
        }
        public static int CreateBuild(int flats, int floors, int entrances)
        {
            Building building = new Building(flats, floors, entrances);
            buildings.Add(building.number, building);
            return building.number;
        }
        public static int CreateBuild(double height, int flats, int floors, int entrances) 
        {
            Building building = new Building(height);
            buildings.Add(building.number, building);
            return building.number;
        }
        public static void DeleteBuilding(int number)
        {
            if (buildings.ContainsKey(number))
            {
                buildings.Remove(number);
            }
            else
            {
                Console.WriteLine("Number of building wasn't found.");
            }
        }
    }
}

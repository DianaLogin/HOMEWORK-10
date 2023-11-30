using System.Collections.Generic;

namespace HOMEWORK_10
{
    internal class Creator
    {
        private Creator() { }
        private static readonly Dictionary<uint, Building> buildings = new Dictionary<uint, Building>();

        public static uint CreateBuild(double height,uint floors)
        {
            Building building = new Building(height, floors);
            buildings.Add(building.number, building);
            return building.number;
        }
        public static uint CreateBuild(double height, uint apartments,uint enters)
        {
            Building building = new Building(height, apartments, enters);
            buildings.Add(building.number, building);
            return building.number;
        }

        public static uint CreateBuild(double height, uint apartments, uint floors, uint enters)
        {
            Building building = new Building(height, apartments, floors, enters);
            buildings.Add(building.number, building);
            return building.number;
        }

        public static void Remove_Build(uint number)
        {
            buildings.Remove(number);
        }



    }
}

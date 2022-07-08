using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_4
{
    public class Creator
    {
        private Creator()
        {

        }
        public static Building CreateBuild(int Height, int Floors, int Flats, int Entrance)
        {
            Building building = new Building();
            Building.IdCreator();
            building.Height = Height;
            building.Floors = Floors;
            building.Entrance = Entrance;
            building.Flats = Flats;
            return building;
        }
        public static Building CreateBuild(int Height)
        {
            Building building = new Building();
            Building.IdCreator();
            building.Height = Height;
            return building;
        }
        public static Building CreateBuild(int Height, int Floors)
        {
            Building building = new Building();
            Building.IdCreator();
            building.Height = Height;
            building.Floors = Floors;
            return building;
        }
        public static Building CreateBuild(int Height, int Floors, int Entrance)
        {
            Building building = new Building();
            Building.IdCreator();
            building.Height = Height;
            building.Floors = Floors;
            building.Entrance = Entrance;
            return building;
        }
    }
}

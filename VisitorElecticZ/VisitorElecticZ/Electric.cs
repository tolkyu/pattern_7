using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace VisitorElecticZ
{
    public class Electric : IVisitor
    {
        public void VisitBuilding(Building building)
        {
            if (building.checkElectricity())
                WriteLine($"Building No {building.Number} is cheacked. Everything is good");
            else
                WriteLine($"Building No {building.Number} has problem");
            foreach (Floor floor in building.Floors)
            {
                VisitFloor(floor);
            }

        }
        public void VisitFloor(Floor floor)
        {
            if (floor.checkElectricity())
                WriteLine($"Floor No {floor.Number} is cheacked. Everything is good");
            else
                WriteLine($"Floor No {floor.Number} is defect.");
            foreach (Room room in floor.Rooms)
            {
                VisitRoom(room);
            }
        }

        public void VisitRoom(Room room)
        {

            if (room.checkElectricity())
            {
                WriteLine($"In room {room.Number} all is fine.");
            }
            else
                WriteLine($"In room {room.Number} is defect.");
        }
    }
}

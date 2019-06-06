using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace VisitorElecticZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building();
            Electric electric = new Electric();
            Floor floor1 = new Floor() { Number = 1 };
            floor1.addRoom(new Room { Number = 102 });
            floor1.addRoom(new Room { Number = 103 });
            floor1.addRoom(new Room { Number = 104 });
            floor1.addRoom(new Room { Number = 105 });
            Floor floor2 = new Floor() { Number = 2 };
            floor1.addRoom(new Room { Number = 202 });
            floor1.addRoom(new Room { Number = 203 });
            floor1.addRoom(new Room { Number = 204 });
            building.addFloor(floor1);
            building.addFloor(floor2);
            IVisitor visitor = new Electric();
            visitor.VisitBuilding(building);
        }
    }
    
    
}

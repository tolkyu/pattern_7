using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorElecticZ
{
    public interface IVisitor
    {
        void VisitRoom(Room room);
        void VisitFloor(Floor floor);
        void VisitBuilding(Building building);
    }
}

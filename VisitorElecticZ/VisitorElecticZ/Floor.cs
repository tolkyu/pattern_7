using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VisitorElecticZ
{
    public class Floor : IElement
    {
        public int Number { get; set; }
        public List<Room> Rooms { private set; get; } = new List<Room>();
        public void Accept(IVisitor visitor)
        {
            visitor.VisitFloor(this);
        }
        public void addRoom(Room room)
        {
            Rooms.Add(room);
        }
        public bool checkElectricity()
        {
            Random rnd = new Random();
            int n = rnd.Next(10);
            Thread.Sleep(50);
            if (n < 6)
                return true;
            else
                return false;
        }
    }
}

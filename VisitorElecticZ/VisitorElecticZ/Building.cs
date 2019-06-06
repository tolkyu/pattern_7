using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VisitorElecticZ
{
    public class Building : IElement
    {
        public List<Floor> Floors { private set; get; } = new List<Floor>();
        public int Number { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitBuilding(this);
        }
        public void addFloor(Floor floor)
        {
            Floors.Add(floor);
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

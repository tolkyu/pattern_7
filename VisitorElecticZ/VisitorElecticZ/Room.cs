using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace VisitorElecticZ
{
    public class Room : IElement
    {
        public int Number { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitRoom(this);
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

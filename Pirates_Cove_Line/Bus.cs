using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pirates_Cove_Line
{
    internal class Bus
    {
        Queue<Golfer> Qgolfers = new Queue<Golfer>();
        Stack<Golfer> Sgolfer = new Stack<Golfer>();
        private bool tuer;
        public bool tuer() { }


        public void Buseinsteigen(Golfer g)
        {
            Qgolfers.Enqueue(g);

            Console.WriteLine(g.Name+"Golfer steigt in Bus");
        }

        public Golfer Golferaussteigen()
        {
            return Qgolfers.Dequeue();
        }

        public void ListevonBus()
        {
            if (Qgolfers.Count>0)
            {
                foreach (var item in Qgolfers)
                {
                    Console.WriteLine("Golfers: " + item.Name);
                }
            }
            else
            {
                foreach (var item in Sgolfer)
                {
                    Console.WriteLine("Golfers: " + item.Name);
                }
            }
            
        }

        public void türkaputt() 
        {
            while (Qgolfers.Count>0)
            { Sgolfer.Push(Qgolfers.Dequeue()); }

            tuer = false;
            //foreach(var item in Qgolfers)
            //{
            //    Sgolfer.Push(item.);
            //}
            //if (Qgolfers.Count>0)
            //{
            //    Qgolfers.Dequeue();
            //}
        }


    }
}

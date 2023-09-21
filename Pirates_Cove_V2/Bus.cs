using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates_Cove_V2
{
    internal class Bus
    {
        public Queue<Golfer> GolferWarteschlange { get; set; } = new Queue<Golfer>();
        public int MaxAnzahlGolfer { get; set; } = 5;
        public void Einsteigen(Golfer g)
        {
            if (GolferWarteschlange.Count <= MaxAnzahlGolfer)
            {
                GolferWarteschlange.Enqueue(g);
            }
        }
        public Golfer Aussteigen()
        {
            Golfer golfer = GolferWarteschlange.Dequeue();
            return golfer;
        }

        public Golfer TuerKlemmt()
        {

            List<Golfer> golfers = GolferWarteschlange.ToList<Golfer>();
            Golfer g = golfers.Last();  // der letzte Golfer
            GolferWarteschlange.Clear();
            Console.WriteLine("Warteschlange gelöscht");

            for (int i = 0; i < golfers.Count - 1; i++)
            {   // vergiß den letzten Golfer/ Count-1
                GolferWarteschlange.Enqueue(golfers[i]);
                Console.WriteLine("in Queue " + golfers[i].Name);
            }
            return g;  // der letzte Golfer
        }
    }
}

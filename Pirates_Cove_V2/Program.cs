using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates_Cove_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Golfer g1 = new Golfer() { Name = "Nader" };
            Golfer g2 = new Golfer() { Name = "Joe" };
            Golfer g3 = new Golfer() { Name = "Pistolen-Joe" };

            Bus bus = new Bus();
            bus.GolferWarteschlange.Enqueue(g1);
            //bus.GolferWarteschlange.Enqueue(g2);
            //bus.GolferWarteschlange.Enqueue(g3);
            //Console.WriteLine( "Eingefügt: "+bus.GolferWarteschlange.Peek().Name );
            //Console.WriteLine("Anzahl vor Entfernen" +bus.GolferWarteschlange.Count);
            //Golfer GolferAusDerWS =  bus.GolferWarteschlange.Dequeue();
            //Golfer GolferAusDerWS = bus.Aussteigen();
            //Console.WriteLine("Anzahl nach Entfernung"+bus.GolferWarteschlange.Count);
            //Console.WriteLine(GolferAusDerWS.Name);

            //Station station1 = new Station();
            //station1.AufnehmenInStation(g1);
            //Console.WriteLine(station1.VerlasseStation().Name);

            //List<Station> Strecke = new List<Station>();
            //Strecke.Add(station1);
            //Strecke.Add(new Station());
            //Console.WriteLine(bus.GolferWarteschlange.Count);

            Golfer g = bus.TuerKlemmt();

            Console.WriteLine("Hauptprogramm Tür ----- " + g.Name);

            bus.GolferWarteschlange.Enqueue(g2);
            bus.GolferWarteschlange.Enqueue(g3);

            Console.WriteLine(bus.GolferWarteschlange.Count);

            // bus.Aussteigen();
            //foreach (var item in bus.GolferWarteschlange) {
            //    Console.WriteLine(bus.GolferWarteschlange.Peek().Name);
            //}

            List<Golfer> golfers = bus.GolferWarteschlange.ToList<Golfer>();
            foreach (var item in golfers)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
        }
    }
}

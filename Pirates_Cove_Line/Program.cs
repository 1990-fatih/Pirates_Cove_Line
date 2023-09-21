using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates_Cove_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();

            Golfer n = new Golfer() { Name="Golfer1"};
            Golfer n2 = new Golfer() { Name="Golfer2" };
            Golfer n3= new Golfer() { Name="Golfer3" };
            Golfer n4 = new Golfer() { Name="Golfer4" };
            Golfer n5 = new Golfer() { Name="Golfer5" };
            Golfer n6 = new Golfer() { Name="Golfer6" };
            Golfer n7 = new Golfer() { Name="Golfer7" };

            bus.Buseinsteigen(n);
            bus.Buseinsteigen(n2);
            bus.Buseinsteigen(n3);
            bus.Buseinsteigen(n4);
            bus.Buseinsteigen(n5);
            bus.Buseinsteigen(n6);
            bus.Buseinsteigen(n7);


            Console.WriteLine();
            
            bus.ListevonBus();
            Console.WriteLine();

            bus.GolferAussteigen();

            Console.WriteLine();

            Console.WriteLine("Tür kaput");

            bus.türkaputt();

            bus.ListevonBus();


        }
    }
}

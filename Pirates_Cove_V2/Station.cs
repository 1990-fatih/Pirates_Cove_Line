using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates_Cove_V2
{
    internal class Station
    {
        public List<Golfer> GolferInDerStation { get; set; } = new List<Golfer>();
        public void AufnehmenInStation(Golfer g)
        {
            GolferInDerStation.Add(g);
        }
        public Golfer VerlasseStation()
        {

            return GolferInDerStation[0];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coalitie.Classes
{
    public class Party
    {
        public string Name { get; set; }
        public int Votes { get; set; }
        public int Seats { get; set; }
        public double VotesPerSeat { get; set; }

        public Party()
        {

        }
    }
}

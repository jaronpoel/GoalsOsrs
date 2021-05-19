using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coalitie.Classes
{
    class Election
    {
        //lists van party en coalition
        public List<Party> party;
        public List<Party> coaltion;
        public int MaxSeats { get; private set; }

        public Election()
        {

        }
    }
}

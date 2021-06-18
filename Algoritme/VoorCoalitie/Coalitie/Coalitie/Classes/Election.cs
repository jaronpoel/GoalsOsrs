using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coalitie.Classes
{
    public class Election
    {
        //lists van party en coalition
        public List<Party> partyList;
        public List<Party> coalitionList;
        public int MaxSeats { get; set; }
        public double Threshold { get; set; }

        private int TotalAssignedSeats;

        public Election()
        {
            partyList = new List<Party>();
            coalitionList = new List<Party>();
            TotalAssignedSeats = 0;
        }

        public void AddParty(string name, int votes)
        {
            Party party = new Party();
            party.Name = name;
            party.Votes = votes;
            partyList.Add(party);
        }

        public bool AddPartyToCoalition(string name)
        {
            Party party = partyList.Find(p => p.Name == name);
            if(party.Seats > 0)
            {
                coalitionList.Add(party);
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show( name + " zit onder de kiesdrempel en kan niet worden toegevoegd worden");
                return false;
            }
        }

        //Som maken van de totaal aantal stemmen.
        private int CalculateTotalVotes(int threshold)
        {
            int TotalVotes = 0;

            foreach(Party party in partyList)
            {
                TotalVotes += party.Votes;
            }

            //threshold in aantal votes
            int thresholdVotes = (int)((double)TotalVotes * ((double)threshold / (double)100));

            TotalVotes = 0;

            foreach (Party party in partyList)
            {
                if (party.Votes >= thresholdVotes)
                {
                    TotalVotes += party.Votes;
                }
                else
                {
                    int index = partyList.IndexOf(party);
                    partyList[index].Votes = 0;
                }
            }
            return TotalVotes;
        }

        //zetels uitgerekend worden
        public void CalculateSeats(int maxseats, int threshold)
        {
            TotalAssignedSeats = 0;
            int totalvotes = CalculateTotalVotes(threshold);

            foreach (Party party in partyList)
            {
                //seats uitrekenen en rond af naar benenden voor de restzetels
                int seats = (int)((double)party.Votes / (double)totalvotes * (double)maxseats);

                int index = partyList.IndexOf(party);
                partyList[index].Seats = seats;

                TotalAssignedSeats += seats;
            }
        }

        //rest zetels uitgerekend worden
        public void CalculateRestSeats(int maxseats)
        {
            if(TotalAssignedSeats < maxseats)
            {
                double votesperSeats;

                //stemmen van de partij delen door de aantal zetels+1
                foreach (Party party in partyList)
                {
                    votesperSeats = (double)party.Votes / (double)(party.Seats + 1);

                    int index = partyList.IndexOf(party);
                    partyList[index].VotesPerSeat = votesperSeats;
                }

                while (TotalAssignedSeats < maxseats)
                {
                    partyList = partyList.OrderByDescending(p => p.VotesPerSeat).ToList();
                    partyList[0].Seats += 1;

                    votesperSeats = (double)partyList[0].Votes / (double)(partyList[0].Seats + 1);

                    partyList[0].VotesPerSeat = votesperSeats;
                    TotalAssignedSeats += 1;
                }
            }
        }

        //Meerderheid uitrekenen.
        public bool CalculateMajority(int maxseats)
        {
            int totalseats = 0;

            foreach (Party party in coalitionList)
            {
                totalseats += party.Seats;
            }

            return totalseats >= maxseats/2;
        }
    }
}

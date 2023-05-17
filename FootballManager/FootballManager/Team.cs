using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    internal class Team
    {
        private List<FootballPlayer> players;

        public Coach Coach { get; private set; }
        public List<FootballPlayer> Players 
        {
            get { return players; }
            private set { if (value.Count >= 11 && value.Count <= 22) players = value; }
        }
        public int AverageAge 
        {
            get { return Players.Select(x => x.Age).Sum() / Players.Count; }
        }
        public Team(Coach coach)
        {
            Players = new List<FootballPlayer>();
        }

        public Team(Coach coach, params FootballPlayer[] players)
        {
            Coach = coach;
            Players = players.ToList();
        }
        public Team(Coach coach, List<FootballPlayer> players)
        {
            Coach = coach;
            Players = players;
        }


        public void AddPlayer(FootballPlayer player)
        {
            Players.Add(player);
        }

    }
}

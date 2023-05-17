using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    internal class Game
    {
        private Team team1;
        private Team team2;

        public Team Team1 
        { 
            get { return team1; }
            private set { if (value.Players.Count >= 0 && value.Players.Count <= 11) team1 = value; } 
        }
        public Team Team2
        {
            get { return team2; }
            private set { if (value.Players.Count >= 0 && value.Players.Count <= 11) team2 = value; }
        }
        public Referee Referee { get; private set; }
        public Referee AssistantReferee1 { get; private set; }
        public Referee AssistantReferee2 { get; private set; }
        public List<Goal> Goals { get; private set; }
        public int[] GameResult 
        { 
            // Counts the goals of both teams
            get 
            {
                int[] output = new int[2];
                output[0] = Goals.Where(x => Team1.Players.Contains(x.Player)).Count();
                output[1] = Goals.Where(x => Team2.Players.Contains(x.Player)).Count();
                return output;
            }
            //private set { GameResult = value; } 
        }
        public Team Winner 
        {
            get 
            {
                if (GameResult[0] > GameResult[1]) return Team1;
                else if(GameResult[1] > GameResult[0]) return Team2;
                return null;
            }
            //private set { Winner = value; }
        }

        public Game(Team team1, Team team2, Referee referee, Referee assistant1, Referee assistant2, List<Goal> goals/*, int[,] gameResult, Team winner*/)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferee1 = assistant1;
            AssistantReferee2 = assistant2;
            Goals = goals;
            //GameResult = gameResult;
            //Winner = winner;
        }
        public void AddGoal(Goal goal)
        {
            if(Team1.Players.Contains(goal.Player) || Team2.Players.Contains(goal.Player))
            {
                Goals.Add(goal);
            }
        }
        public string PrintResult()
        {
            return $"{GameResult[0]}-{GameResult[1]}";
        }

        public string PrintWinner()
        {
            switch (Winner)
            {
                case var value when value == Team1:
                    return "Team1";
                case var value1 when value1 == Team2:
                    return "Team2";
                default:
                    return "Draw";
            }
        }
    }
}

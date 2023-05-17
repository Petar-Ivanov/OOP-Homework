using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    internal class Goal
    {
        public FootballPlayer Player { get; set; }
        public double Minute { get; set; }

        public Goal(FootballPlayer player, double minute)
        {
            Player = player;
            Minute = minute;
        }
    }
}

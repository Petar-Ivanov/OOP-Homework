using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach coach1 = new Coach("Joe", 47);
            Coach coach2 = new Coach("Joe", 42);

            Referee r1 = new Referee("Joe", 49);
            Referee r2 = new Referee("Joe", 58);
            Referee r3 = new Referee("Joe", 37);
            Referee r4 = new Referee("Another Joe", 55);
            Referee r5 = new Referee("Joe", 68);
            Referee r6 = new Referee("Joe", 32);

            FootballPlayer d1 = new Defender("Joe1", 25, 1, 180);
            FootballPlayer d2 = new Defender("Joe2", 20, 2, 190);
            FootballPlayer d3 = new Defender("Joe3", 25, 3, 178);
            FootballPlayer d4 = new Defender("Joe4", 20, 4, 190);
            FootballPlayer d5 = new Defender("Joe5", 25, 5, 178);

            FootballPlayer g1 = new Goalkeeper("Joe6", 26, 6, 200);
            FootballPlayer g2 = new Goalkeeper("Joe7", 19, 7, 182);
            FootballPlayer g3 = new Goalkeeper("Joe8", 30, 8, 194);

            FootballPlayer m1 = new Midfield("Joe9", 19, 9, 170);
            FootballPlayer m2 = new Midfield("Joe10", 29, 10, 198);
            FootballPlayer m3 = new Midfield("Joe11", 22, 11, 191);
            FootballPlayer m5 = new Midfield("Joe12", 19, 12, 170);
            FootballPlayer m6 = new Midfield("Joe13", 29, 13, 198);
            FootballPlayer m7 = new Midfield("Joe14", 22, 14, 191);

            FootballPlayer s1 = new Striker("Joe15", 32, 15, 199);
            FootballPlayer s2 = new Striker("Joe16", 33, 16, 193);
            FootballPlayer s3 = new Striker("Joe17", 30, 17, 180);
            FootballPlayer s4 = new Striker("Joe18", 33, 18, 193);
            FootballPlayer s5 = new Striker("Joe19", 30, 19, 180);
            FootballPlayer s6 = new Striker("Joe20", 30, 20, 180);
            FootballPlayer s7 = new Striker("Joe21", 33, 21, 193);

            List<FootballPlayer> players1 = new List<FootballPlayer> { d1, d2, d3, g1, g2, m1, m2, m3, s1, s2, s3 };
            List<FootballPlayer> players2 = new List<FootballPlayer> { d4, d5, g1, g3, m5, m6, m7, s4, s5, s6, s7 };

            Team team1 = new Team(coach1, players1);
            Team team2 = new Team(coach2, players2);

            List<Goal> goals1 = new List<Goal> { new Goal(s1, 5), new Goal(s2, 10), new Goal(s4, 16) };
            Game game1 = new Game(team1, team2, r1, r2, r3, goals1);

            List<Goal> goals2 = new List<Goal> { new Goal(m7, 3), new Goal(s6, 11), new Goal(s6, 30) };
            Game game2 = new Game(team1, team2, r4, r5, r6, goals2);

            List<Goal> goals3 = new List<Goal> { new Goal(m7, 3), new Goal(s3, 30) };
            Game game3 = new Game(team1, team2, r4, r5, r6, goals3);

            Console.WriteLine($"Team 1 Average Age: {team1.AverageAge}");
            Console.WriteLine($"Team 2 Average Age: {team2.AverageAge}");

            Console.WriteLine();

            Console.WriteLine("Game 1:");
            Console.WriteLine("Referee: " + game1.Referee.Name);
            Console.WriteLine("Team1-Team2: " + game1.PrintResult());
            Console.WriteLine("Winner: " + game1.PrintWinner());

            Console.WriteLine();

            Console.WriteLine("Game 2:");
            Console.WriteLine("Referee: " + game2.Referee.Name);
            Console.WriteLine("Team1-Team2: " + game2.PrintResult());
            Console.WriteLine("Winner: " + game2.PrintWinner());

            Console.WriteLine();

            Console.WriteLine("Game 3:");
            Console.WriteLine("Referee: " + game3.Referee.Name);
            Console.WriteLine("Team1-Team2: " + game3.PrintResult());
            Console.WriteLine("Winner: " + game3.PrintWinner());

            Console.ReadKey();
        }
    }
}

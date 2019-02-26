using System;

namespace DecouplingClasses
{
    public class SportsTeam
    {
        public string Sport { get; set; }
        public string TeamName { get; set; }

        private IConsole Console { get; }

        public SportsTeam(string sport, string teamName, IConsole console)
        {
            if(console == null)
                throw new ArgumentNullException(nameof(console));
            
            Sport = sport;
            TeamName = teamName;
            Console = console;
        }

        public void PrintTeamInfo()
        {
            Console.WriteLine(Sport + " - " + TeamName);
        }

        public void UpdateTeam()
        {
            Console.Write("Enter new team name --> ");
            var newName = Console.ReadLine();
            TeamName = newName;
        }
    }
}
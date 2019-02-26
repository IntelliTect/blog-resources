using System;

namespace DecouplingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var productionConsole = new ProductionConsole();
            SportsTeam myTeam = new SportsTeam("Hockey", "Bruins", productionConsole);
            myTeam.PrintTeamInfo();
            productionConsole.ReadLine();

            myTeam.UpdateTeam();
            myTeam.PrintTeamInfo();
            productionConsole.ReadLine();
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecouplingClasses.Tests
{
    [TestClass]
    public class SportsTeamTests
    {
        [TestMethod]
        public void PrintTeamInfo_PrintsCorrectInformation()
        {
            var testConsole = new TestableConsole();
            var myTeam = new SportsTeam("Hockey", "Bruins", testConsole);

            myTeam.PrintTeamInfo();

            Assert.AreEqual<string>("Hockey - Bruins", testConsole.WrittenLines[0]);
        }

        [TestMethod]
        public void UpdateTeam_TeamIsUpdated()
        {
            var testConsole = new TestableConsole();
            var myTeam = new SportsTeam("Hockey", "Bruins", testConsole);
            
            testConsole.LineToRead = "Rangers";

            myTeam.UpdateTeam();

            Assert.AreEqual<string>("Rangers", myTeam.TeamName);
            Assert.AreEqual<string>("Enter new team name --> ", testConsole.WrittenLines[0]);
        }
    }
}

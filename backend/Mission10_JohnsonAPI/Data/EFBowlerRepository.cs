using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace Mission10_JohnsonAPI.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerContext _bowlerContext;
        public EFBowlerRepository(BowlerContext temp)
        {
            _bowlerContext = temp;
        }
        //[HttpGet]
        public IEnumerable<object> GetBowlerTeams()
        {
            var joinedData = from Bowler in _bowlerContext.Bowlers
                             join Team in _bowlerContext.Teams
                             on Bowler.TeamID equals Team.TeamID
                             where Team.TeamName == "Marlins" || Team.TeamName == "Sharks"
                             select new
                             {
                                 BowlerID = Bowler.BowlerID,
                                 BowlerLastName = Bowler.BowlerLastName,
                                 BowlerFirstName = Bowler.BowlerFirstName,
                                 BowlerMiddleInit = Bowler.BowlerMiddleInit,
                                 BowlerAddress = Bowler.BowlerAddress,
                                 BowlerCity = Bowler.BowlerCity,
                                 BowlerState = Bowler.BowlerState,
                                 BowlerZip = Bowler.BowlerZip,
                                 BowlerPhoneNumber = Bowler.BowlerPhoneNumber,
                                 TeamName = Team.TeamName
                             };
            return joinedData.ToList();
        }



        //CHANGE TO object
        //public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;
        //public IEnumerable<Team> Teams => _bowlerContext.Teams;
    }
}
namespace Mission10_JohnsonAPI.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<object> GetBowlerTeams();
        //IEnumerable<Bowler> Bowlers { get; }
        //IEnumerable<Team> Teams { get; }
    }

}

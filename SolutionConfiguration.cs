using COPC.Common;

namespace COPC.Solution
{
    public class SolutionConfiguration : ISolutionConfiguration
    {
        public string TeamName => "Team Name";       // TODO: Return your team's "friendly" name here. This will show on the leaderboard.      

        public Challenge Challenge => Challenge.AlphaMath;          // TODO: Return the Challenge that this solution is for.
        public ChallengeLevel ChallengeLevel => ChallengeLevel.NonBeginner;     // TODO: Return the level at which you're competing.
    }
}
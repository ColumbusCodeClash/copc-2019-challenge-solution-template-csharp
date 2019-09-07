using COPC.Common;

namespace COPC.Solution
{
    public class SolutionConfiguration : ISolutionConfiguration
    {
        public string TeamName => "Team Name";
        public Challenge Challenge => Challenge.AlphaMath;
        public ChallengeLevel ChallengeLevel => ChallengeLevel.NonBeginner;
    }
}
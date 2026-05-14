using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Company.TestProject1;

[TestClass]
public class PenaltyTests
{
    [TestMethod]
    public void Construct()
    {
        var penalty = new FootballSim_lib.Penalty
        {
            Accepted = true, 
            Description = "test",
            PenaltyYards = -1,
            AutomaticFirstDown = true,
            LossOfDown = false,
            DuringPlay = false
        };
    }
}

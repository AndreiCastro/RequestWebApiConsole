using NUnit.Framework;
using RequestWebApi;

namespace TestRequestWebApi
{
    [TestFixture]
    public class GoalCounterTest
    {
        [Test]
        [Category("Paris Saint-Germain")]
        public void ScoredTestPSG()
        {
            // Act
            int countGoals = GoalsCounter.GetTotalScoredGoalsForTeam("Paris Saint-Germain", 2013);

            // Assert
            Assert.That(countGoals, Is.EqualTo(109));
        }

        [Test]
        [Category("Chelsea")]
        public void ScoredTestChelsea()
        {
            // Act
            int countGoals = GoalsCounter.GetTotalScoredGoalsForTeam("Chelsea", 2014);

            // Assert
            Assert.That(countGoals, Is.EqualTo(92));
        }
    }
}
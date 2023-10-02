using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestWebApi
{
    public static class ShowScored
    {
        internal static void ShowCalculeScored()
        {
            string teamName = "Paris Saint-Germain";
            int year = 2013;
            int totalGoals = getTotalScoredGoals(teamName, year);
            Console.WriteLine("Team " + teamName + " scored " + totalGoals.ToString() + " goals in " + year);

            teamName = "Chelsea";
            year = 2014;
            totalGoals = getTotalScoredGoals(teamName, year);
            Console.WriteLine("Team " + teamName + " scored " + totalGoals.ToString() + " goals in " + year);

            // Output expected:
            // Team Paris Saint - Germain scored 109 goals in 2013
            // Team Chelsea scored 92 goals in 2014
        }

        private static int getTotalScoredGoals(string team, int year)
        {
            return GoalsCounter.GetTotalScoredGoalsForTeam(team, year);
        }
    }
}

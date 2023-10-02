using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestWebApi
{
    public class GoalsCounter
    {
        private static int CountGoals(DeserializeJson? jsonDeserialize, bool team1)
        {
            var countGoals = 0;
            foreach (var item in jsonDeserialize.Data)
                countGoals += team1 == true ? Convert.ToInt32(item.Team1goals) : Convert.ToInt32(item.Team2goals);

            return countGoals;
        }

        internal static int GetTotalScoredGoalsForTeam(string team, int year)
        {
            DeserializeJson? jsonDeserialize = new DeserializeJson();
            jsonDeserialize = RequestApi.Resquisicao(team, year, "team1"); 
            var countPage = jsonDeserialize.Total_Pages;
            var countTotalGoals = CountGoals(jsonDeserialize, true);
            for (var i = countPage; i > 1; i--)
            {
                jsonDeserialize = RequestApi.Resquisicao(team, year, "team1", countPage);
                countTotalGoals += CountGoals(jsonDeserialize, true);
                countPage--;
            }

            jsonDeserialize = RequestApi.Resquisicao(team, year, "team2");
            countPage = jsonDeserialize.Total_Pages;
            countTotalGoals += CountGoals(jsonDeserialize, false);
            for (var i = countPage; i > 1; i--)
            {
                jsonDeserialize = RequestApi.Resquisicao(team, year, "team2", countPage);
                countTotalGoals += CountGoals(jsonDeserialize, false);
                countPage--;
            }
            return countTotalGoals;
        }
    }
}

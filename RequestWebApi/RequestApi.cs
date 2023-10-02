using Newtonsoft.Json;
using System.Net;

namespace RequestWebApi
{
    internal class RequestApi
    {
        public static DeserializeJson? Resquisicao(string team, int year, string numberTeam, int? page = null)
        {
            var retornoApi = new DeserializeJson();
            string uri = "";

            if (page == null)
                uri = $"https://jsonmock.hackerrank.com/api/football_matches?{numberTeam}={team}&year={year}";
            else
                uri = $"https://jsonmock.hackerrank.com/api/football_matches?{numberTeam}={team}&year={year}&page={page}";

            var requisicaoWeb = WebRequest.CreateHttp(uri);
            requisicaoWeb.Method = "GET";
            requisicaoWeb.UserAgent = "RequisicaoWebDemo";

            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();
                retornoApi = JsonConvert.DeserializeObject<DeserializeJson>(objResponse.ToString());
            }
            return retornoApi;
        }
    }
}

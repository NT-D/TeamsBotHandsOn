using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Cognitive.LUIS;
using System.Threading.Tasks;

namespace TeamsBot.Services
{
    public class LuisService
    {
        private LuisClient luisClient;

        public LuisService()
        {
            luisClient = new LuisClient("<App IDを入れてください>", "<App Keyを入れてください。>");
        }

        public async Task<string> GetTopIntent(string input)
        {
            LuisResult luisResult = await luisClient.Predict(input);
            return luisResult.TopScoringIntent.Name.ToString();
        }
    }
}
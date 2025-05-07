using HtmlAgilityPack;
using InfoTrack.Services.Config;

namespace InfoTrack.Services.Parser
{
    public class BingParser : IParser
    {
        private readonly IBingConfig _bingConfig;

        public BingParser(IBingConfig bingConfig)
        {
            _bingConfig = bingConfig;
        }

        public List<int> ParseResponse(string response, string url)
        {
            List<int> resultPlace = new List<int>();
            var doc = new HtmlDocument();
            doc.LoadHtml(response);

            //Could do with a better way of getting these instead of using classes 
            var listResultNodes = doc.DocumentNode.SelectNodes($"//div[contains(@class, '{_bingConfig.ResultClasses}')]");

            if (listResultNodes != null)
            {
                for (int i = 0; i < listResultNodes.Count; i++)
                {
                    if (listResultNodes[i].InnerHtml.Contains(url))
                    {
                        resultPlace.Add(i + 1);
                    }
                }
            }

            return resultPlace;
        }
    }
}

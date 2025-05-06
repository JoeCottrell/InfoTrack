using Flurl;
using Flurl.Http;
using InfoTrack.Services.Config;

namespace InfoTrack.Services.Query
{
    public class BingQuery : IQuery
    {
        private readonly IBingConfig _bingConfig;

        public BingQuery(IBingConfig bingConfig)
        {
            _bingConfig = bingConfig;
        }

        public async Task<string> Search(string query)
        {

            //Need to find a better way to get these keys when they expire
            //Needed here to get to a version of google without cookie consent pop up
            var url = _bingConfig.BingURL + query;
            var response = await new Url(url)
                .GetStringAsync().ConfigureAwait(false);

            return response;
        }
    }
}



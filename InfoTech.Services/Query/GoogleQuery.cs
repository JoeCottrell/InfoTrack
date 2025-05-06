using Flurl;
using Flurl.Http;
using InfoTrack.Services.Config;

namespace InfoTrack.Services.Query
{
    public class GoogleQuery : IQuery
    {
        private readonly IGoogleConfig _googleConfig;

        public GoogleQuery(IGoogleConfig googleConfig)
        {
            _googleConfig = googleConfig;
        }

        public async Task<string> Search(string query)
        {

            //Need to find a better way to get these keys when they expire
            //Needed here to get to a version of google without cookie consent pop up
            var url = _googleConfig.GoogleURL + query;
            var response = await new Url(url)
                .WithCookie("SOCS", _googleConfig.SOCSToken)
                .WithCookie("NID", _googleConfig.NID)
                .GetStringAsync().ConfigureAwait(false);

            return response;
        }
    }
}



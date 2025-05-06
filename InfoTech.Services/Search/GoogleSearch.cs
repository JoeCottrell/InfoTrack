using InfoTrack.Services.Helper;
using InfoTrack.Services.Parser;
using InfoTrack.Services.Query;

namespace InfoTrack.Services.Search
{
    public class GoogleSearch : ISearch
    {
        private readonly IQuery _query;
        private readonly IParser _parser;

        public GoogleSearch(IQuery query,
                IParser parser)
        {
            _query = query;
            _parser = parser;
        }

        public async Task<string> GetSearchResults(string query, string url)
        {
            try
            {
                url = UrlHelper.stripStartUrl(url);

                var queryResult = await _query.Search(query);

                var listResults = _parser.ParseResponse(queryResult, url);

                return String.Join(",", listResults);
            }
            catch (Exception ex)
            {
                //Need some actual logging in here to DD or other provider. 
                throw;
            }
        }
    }

}

using InfoTrack.Services.Config;
using InfoTrack.Services.Parser;
using InfoTrack.Services.Query;
using InfoTrack.Services.Search;

namespace InfoTrack.Services.Factory
{
    public class SearchFactory : ISearchFactory
    {
        private readonly IGoogleConfig _googleConfig;
        private readonly IBingConfig _bingConfig;

        public SearchFactory(IGoogleConfig googleConfig,
            IBingConfig bingConfig)
        {
            _googleConfig = googleConfig;
            _bingConfig = bingConfig;
        }


        public SearchContainer Build()
        {
            //Id prefer a more config driven way to get these.
            var searchProviders = new Dictionary<Enums.SearchProvider, ISearch>();
            searchProviders.Add(Enums.SearchProvider.Google, new GoogleSearch(new GoogleQuery(_googleConfig), new GoogleParser(_googleConfig)));
            searchProviders.Add(Enums.SearchProvider.Bing, new BingSearch(new BingQuery(_bingConfig), new BingParser(_bingConfig)));

            return new SearchContainer(searchProviders);
        }
    }


}

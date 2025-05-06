using InfoTrack.Services.Search;

namespace InfoTrack.Services.Factory
{
    public class SearchContainer
    {
        private readonly Dictionary<Enums.SearchProvider, ISearch> _searchProviders;

        public SearchContainer(Dictionary<Enums.SearchProvider, ISearch> searchProviders)
        {
            _searchProviders = searchProviders;
        }

        public ISearch GetBySearchProvider(Enums.SearchProvider searchProvider)
        {
            return _searchProviders[searchProvider];
        }

    }
}

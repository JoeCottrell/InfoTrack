using InfoTrack.Services.Factory;
using Microsoft.AspNetCore.Components;
using static InfoTrack.Services.Factory.Enums;

namespace InfoTrack.Components.Pages
{
    public partial class Home
    {
        private string searchTerm = string.Empty;
        private string url = string.Empty;
        private bool hideResults = true;
        private bool hideError = true;
        private bool hideNoResults = true;
        private SearchProvider selectedSearchProvider = SearchProvider.Google;

        private SearchContainer _searchContainer;


        private string result = string.Empty;

        [Inject]
        private ISearchFactory _searchFactory { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            _searchContainer = _searchFactory.Build();
        }


        private async Task Query()
        {
            try
            {
                hideError = true;
                var search = _searchContainer.GetBySearchProvider(selectedSearchProvider);
                result = await search.GetSearchResults(searchTerm, url);
                HideResult();
            }
            catch (Exception ex)
            {
                hideError = false;
                hideResults = true;
                hideNoResults = true;
            }
        }

        private void HideResult()
        {
            hideResults = result.Length == 0;
            hideNoResults = result.Length != 0;
        }

    }
}
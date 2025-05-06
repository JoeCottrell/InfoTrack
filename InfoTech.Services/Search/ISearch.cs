namespace InfoTrack.Services.Search
{
    public interface ISearch
    {
        public Task<string> GetSearchResults(string query, string url);
    }
}

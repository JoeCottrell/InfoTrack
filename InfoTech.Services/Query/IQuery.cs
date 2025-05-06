namespace InfoTrack.Services.Query
{
    public interface IQuery
    {
        public Task<string> Search(string query);
    }
}



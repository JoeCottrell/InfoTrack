namespace InfoTrack.Services.Parser
{
    public interface IParser
    {
        public List<int> ParseResponse(string response, string url);
    }
}

namespace InfoTrack.Services.Config
{
    public interface IGoogleConfig
    {
        string GoogleURL { get; }
        int ResultCount { get; }
        string SOCSToken { get; }
        string NID { get; }
        string ResultClasses { get; }
    }
}

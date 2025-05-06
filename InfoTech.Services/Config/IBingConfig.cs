namespace InfoTrack.Services.Config
{
    public interface IBingConfig
    {
        string BingURL { get; }
        int ResultCount { get; }
        string ResultClasses { get; }
    }
}

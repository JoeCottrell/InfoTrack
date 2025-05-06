namespace InfoTrack.Services.Config
{
    public class BingOptions
    {
        public const string SECTION = "BING";

        public string BingURL { get; set; } = string.Empty;
        public int ResultCount { get; set; } = 0;
        public string ResultClasses { get; set; } = string.Empty;
    }
}

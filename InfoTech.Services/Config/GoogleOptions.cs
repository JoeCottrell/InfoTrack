namespace InfoTrack.Services.Config
{
    public class GoogleOptions
    {
        public const string SECTION = "GOOGLE";

        public string GoogleURL { get; set; } = string.Empty;
        public int ResultCount { get; set; } = 0;
        public string SOCSToken { get; set; } = string.Empty;
        public string NID { get; set; } = string.Empty;
        public string ResultClasses { get; set; } = string.Empty;
    }
}

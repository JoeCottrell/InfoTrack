using Microsoft.Extensions.Options;

namespace InfoTrack.Services.Config
{
    public class GoogleConfig : IGoogleConfig
    {
        public GoogleConfig(IOptions<GoogleOptions> options)
        {
            GoogleURL = string.Format(options.Value.GoogleURL, options.Value.ResultCount);
            ResultCount = options.Value.ResultCount;
            SOCSToken = options.Value.SOCSToken;
            NID = options.Value.NID;
            ResultClasses = options.Value.ResultClasses;
        }

        public string GoogleURL { get; }
        public int ResultCount { get; }
        public string SOCSToken { get; }
        public string NID { get; }
        public string ResultClasses { get; }
    }


    public class BingConfig : IBingConfig
    {
        public BingConfig(IOptions<BingOptions> options)
        {
            BingURL = string.Format(options.Value.BingURL, options.Value.ResultCount);
            ResultCount = options.Value.ResultCount;
            ResultClasses = options.Value.ResultClasses;
        }

        public string BingURL { get; }
        public int ResultCount { get; }
        public string ResultClasses { get; }
    }

}

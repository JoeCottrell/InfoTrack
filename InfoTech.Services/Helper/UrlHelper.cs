namespace InfoTrack.Services.Helper
{
    public static class UrlHelper
    {
        private static readonly string[] _urlRemoval = ["https://", "http://", "www."];

        /// <summary>
        /// We dont need these at the start so we can normalise results
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string stripStartUrl(string url)
        {
            foreach (var item in _urlRemoval)
            {
                url = url.Replace(item, "");
            }

            return url;
        }
    }
}

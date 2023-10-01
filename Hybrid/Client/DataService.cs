using Hybrid.Shared;

namespace Hybrid.Client
{
    public class DataService : IDataService
    {
        private HttpClient _httpClient { get; set; }
        public DataService(HttpClient HttpClient) { _httpClient = HttpClient; }
        public string GetString()
        {
            return "web";
        }
    }
}

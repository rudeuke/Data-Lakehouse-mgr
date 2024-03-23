namespace application.api_helper
{
    public class Request
    {
        public static HttpResponseMessage Get(string url)
        {
            var response = new HttpClient().GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            return null;
        }
    }
}
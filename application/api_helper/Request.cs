namespace application.Api_helper
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
            else
            {
                throw new Exception("Failed to get response from the API");
            }
        }
    }
}
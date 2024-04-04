namespace application.Api_helper
{
    public class Serialization
    {
        public static string ReturnTextFromResponse(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                return content;
            }
            return string.Empty;
        }
    }
}
namespace application.api_helper
{
    public class Serialization
    {
        public static string ReturnTextFromRequest(HttpResponseMessage response)
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
namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            file_helper.Save.TextFile(
                api_helper.Serialization.ReturnTextFromRequest(
                    api_helper.Request.Get("https://ec.europa.eu/eurostat/api/dissemination/catalogue/toc/txt?lang=en")));
        }
    }
}
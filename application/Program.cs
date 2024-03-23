namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //get list of files from the API
            //check if the files exist (and DB)
                //if not, save the files

            file_helper.Save.TextFile(
                api_helper.Serialization.ReturnTextFromRequest(
                    api_helper.Request.Get("https://ec.europa.eu/eurostat/api/dissemination/catalogue/toc/txt?lang=en")));
        }
    }
}
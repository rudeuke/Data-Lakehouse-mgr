namespace application.file_helper
{
    public class Save
    {
        public static bool TextFile(string content)
        {
            try
            {
                File.WriteAllText("../test.txt", content);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
    }
}
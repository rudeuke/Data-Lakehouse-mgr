namespace application.File_helper
{
    public class Check
    {
        public static bool IsExisting(string filename)
        {
            return File.Exists("../" + filename);
        }
    }
}
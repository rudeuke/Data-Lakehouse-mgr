using application.Enums;

namespace application.File_helper
{
    public class Save
    {
        public static bool ToFile(string content, string fileName, FileExtension fileExtension)
        {
            var path = $"../{fileName}.{fileExtension}";
            try
            {
                File.WriteAllText(path, content);
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
namespace application.Db_helper
{
    public class Files
    {
        public static bool Create(Models.File file)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                try
                {
                    dbContext.Files.Add(file);
                    dbContext.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return false;
                }
                return true;
            }
        }
    }
}
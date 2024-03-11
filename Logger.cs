namespace FoodPantryApp
{
    using System.Security.Policy;

    public static class Logger
    {
        public static void WriteLog(string message)
        {
            string logPath = $"{Directory.GetCurrentDirectory()}.log.txt";
            using (StreamWriter sw = new StreamWriter(logPath, true)) { sw.WriteLine($"{DateTime.Now} : {message}"); }
        }
    }
}

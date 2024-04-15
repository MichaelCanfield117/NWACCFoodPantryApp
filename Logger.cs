namespace FoodPantryApp
{
    /// <summary>
    /// Class that models a Logging system.
    /// </summary>
    public static class Logger
    {
        /// <summary>
        /// The function that writes a log to a given logPath.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="logPath">
        /// The log path.
        /// </param>
        public static void WriteLog(string message, string logPath)
        {
            using (StreamWriter sw = new StreamWriter(logPath, true)) { sw.WriteLine($"{DateTime.Now} : {message}"); }
        }
    }
}

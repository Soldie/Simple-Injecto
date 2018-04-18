namespace Simple_Injector
{
    public static class Logger
    {
        public interface IStatusLogger
        {
            void LogStatus(string status);
        }
    }
}

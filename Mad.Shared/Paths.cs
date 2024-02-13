using System.Reflection;

namespace Mad.Shared
{
    public class Paths
    {
        public static string AppName { get; private set; }
        public static string WorkingDirectory { get; private set; }
        public static string DocsFile { get; private set; }
        public static string Logs { get; private set; }
        public static string Db { get; private set; }

        public static void Init()
        {
            AppName = "MadNotes";
            WorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new NullReferenceException();
            DocsFile = Path.Combine(WorkingDirectory, $"{AppName}.xml");
            Logs = Path.Combine(WorkingDirectory, "Logs");
            Db = WorkingDirectory;
        }
    }
}
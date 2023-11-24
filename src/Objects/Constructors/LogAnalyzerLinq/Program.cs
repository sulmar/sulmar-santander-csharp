namespace LogAnalyzerLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "ip_traffic_log.csv";

            Console.WriteLine("Wybierz port: ");
            int selectedPort = int.Parse(Console.ReadLine());

            CsvFileLogEntryService logEntryService = new CsvFileLogEntryService();

            var logEntries = logEntryService.GetLogEntries(path);
            
            var filteredLogEntries = logEntries
                .Where(logEntry => logEntry.Port == selectedPort);

            var uniqueIpAddresses = filteredLogEntries
                .DistinctBy(logEntry => logEntry.Ip);



        }
    }
}

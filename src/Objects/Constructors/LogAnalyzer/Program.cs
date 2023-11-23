using LogAnalyzer.Model;

namespace LogAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string path = "ip_traffic_log.csv";

            string[] protocols = ["TCP", "UDP", "HTTP"];


            CsvFileLogEntryService logEntryService = new CsvFileLogEntryService();
            List<LogEntry> logEntries = logEntryService.GetLogEntries(path);

            // Zbiór
            HashSet<string> uniqueIpAddresses = new HashSet<string>();

            // Linq
            List<string> uniqueIpAddressesLinq = logEntries // SQL: SELECT * FROM logEntries
                                                .Select(p=>p.Source_IP) // SQL: SELECT Source_IP FROM logEntries
                                                .Distinct() // SQL: SELECT DISTINCT Source_IP FROM logEntries
                                                .ToList();         

            string selectedProtocol;

            do
            {
                Console.WriteLine("Podaj protokół: ");
                Console.WriteLine(string.Join(',', protocols));

                selectedProtocol = Console.ReadLine();
            }
            while (!protocols.Contains(selectedProtocol));


            foreach (LogEntry logEntry in logEntries)
            {
                uniqueIpAddresses.Add(logEntry.Source_IP);
            }


            foreach(string ipAddress in uniqueIpAddresses)
            {
                Console.WriteLine(ipAddress);
            }

        }
    }
}

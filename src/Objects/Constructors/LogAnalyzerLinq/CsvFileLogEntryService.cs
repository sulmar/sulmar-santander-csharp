using LogAnalyzerLinq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAnalyzerLinq
{
    internal class CsvFileLogEntryService
    {
        char separator = ',';

        public IEnumerable<LogEntry> GetLogEntries(string path)
        {
            string[] lines = File.ReadAllLines(path);

            var header = lines[0];
            var rows = lines.Skip(1);

            var columns = rows.Select(row => row.Split(separator));

            var logEntries = columns.Select(column => new LogEntry
            {
                Ip = column[1],
                Port = int.Parse(column[4]),
            });

            return logEntries;

        }
    }
}

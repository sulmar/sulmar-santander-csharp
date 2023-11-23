using LogAnalyzer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAnalyzer
{
    internal class CsvFileLogEntryService
    {
        public List<LogEntry> GetLogEntries(string path, char separator = ',')
        {
            // Tworzymy pustą listę
            List<LogEntry> logEntries = new List<LogEntry>();

            // Tworzymy czytnik strumienia z pliku
            StreamReader reader = new StreamReader(path);

            // Odczytujemy nagłówek
            string header = reader.ReadLine();

            // Czytamy strumień tak długo zanim się nie skończy
            while (!reader.EndOfStream)
            {
                // Odczytujemy linię
                string line = reader.ReadLine();

                // Tniemy linię na kolumny i przypisujemy do tablicy stringów
                string[] columns = line.Split(separator);

                // Odczytujemy wartości w poszczególnych kolumnach
                string sourceAddressIp = columns[1];
                string protocol = columns[3];
                int bytesTransferred = int.Parse(columns[5]);

                // Mapujemy kolumny na obiekt LogEntry
                LogEntry logEntry = new LogEntry(sourceAddressIp, protocol, bytesTransferred);

                // Dodajemy wpis do listy
                logEntries.Add(logEntry);
            }

            // Zwracamy wynik
            return logEntries;
        }
    }
}

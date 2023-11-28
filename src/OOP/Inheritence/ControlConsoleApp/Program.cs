using ControlConsoleApp.Model;

namespace ControlConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Window window = new Window();

            window.Render();
        }
    }
}

namespace PhoneConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Marcin", "Sulecki");
            Phone phone1 = new Phone("555-111-222", person1)
            {
                BateryLevel = 0.7f
            };

            Person person2 = new Person("John", "Smith");
            Phone phone2 = new Phone("555-222-111", person2)
            { 
                BateryLevel = 0.8f 
            };

            Call call = new Call(phone1, phone2);

            if (call.CanMakeCall())
                call.MakeCall();
        }
    }
}
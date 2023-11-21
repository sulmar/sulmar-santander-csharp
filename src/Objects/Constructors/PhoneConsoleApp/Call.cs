namespace PhoneConsoleApp
{
    class Sender
    {
        public void Process()
        {
            Prepare();
            Calculate();
            Send();
        }

        public void Prepare()
        {
            Console.WriteLine("Preparing...");
        }

        public void Calculate()
        {
            Console.WriteLine("Calculating...");
        }

        public void Send()
        {
            Console.WriteLine("Sending...");
        }
    }

    class Call
    {
        public Phone Caller;
        public Phone Recipient;


        public const float MinimalBateryLevelForCalling = 0.05f;

        public Call(Phone caller, Phone recipient)
        {
            this.Caller = caller;
            this.Recipient = recipient; 
        }

        public void MakeCall()
        {
            Console.WriteLine($"Calling from {Caller.Owner.GetFullName()} ({Caller.Number}) to {Recipient.Owner.GetFullName()} ({Recipient.Number}) ");

            Console.WriteLine($"Batery level: {Caller.BateryLevel:P0}");
        }

        public bool CanMakeCall()
        {
            return Caller.BateryLevel > MinimalBateryLevelForCalling && Recipient.BateryLevel > MinimalBateryLevelForCalling;
        }
    }
}

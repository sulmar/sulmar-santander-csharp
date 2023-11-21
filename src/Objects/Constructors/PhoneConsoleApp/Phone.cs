namespace PhoneConsoleApp
{

    class Phone
    {
        public string Number;
        public float BateryLevel;
        public Person Owner;

        public Phone(string number, Person owner)
        {
            Number = number;
            Owner = owner;
        }
    }
}

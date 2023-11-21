namespace PhoneConsoleApp
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

    }
}

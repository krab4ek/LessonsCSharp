namespace FunWithCollectionInitialization
{
    class Person
    {
        string? FirstName { get; set; }
        string? LastName { get; set; }
        int? Age { get; set; }
        public Person()
        {

        }
        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }
}

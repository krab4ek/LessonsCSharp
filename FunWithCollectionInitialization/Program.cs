using FunWithCollectionInitialization;

static void UseGenericsList()
{
    List<Person> people = new List<Person>()
    {
    new Person ("Gomer","Simpson",45),
    new Person ("Marge","Simpson",42),
    new Person ("Bart", "Simpson", 17),
    new Person ("Lilu","Simpson",9)

    };
    Console.WriteLine("Items in list: {0}", people.Count);

    foreach (Person person in people)
        Console.WriteLine(person);

    Console.WriteLine("\n-> Inserting new person.");
    people.Insert(2, new Person("Maggie", "Simpson", 3));

    Console.WriteLine("Items in list: {0}", people.Count);
    foreach (Person person in people)
        Console.WriteLine(person);

    Person[] arrayofPeople = people.ToArray();
    foreach (Person person in arrayofPeople)
        Console.WriteLine(person);
};

UseGenericsList();
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


}

UseGenericsList();
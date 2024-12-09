public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class PersonsCollection : IItertableCollection
{
    public List<Person> Persons { get; set; }

    public PersonsCollection()
    {
        Persons = new List<Person> 
        {
            new Person { Id = 1, Name = "Mohammed" },
            new Person { Id = 2, Name = "Ahmed" },
            new Person { Id = 3, Name = "Saif" },
        };
    }

    public IPersonIterator CreateFamilyMemberIterator()
    {
        return new Friend(this);
    }

    public IPersonIterator CreateFriendIterator()
    {
        return new FamilyMember(this);
    }
}

public interface IItertableCollection
{
    IPersonIterator CreateFriendIterator();
    IPersonIterator CreateFamilyMemberIterator();
}

public interface IPersonIterator
{
    bool HasNext();
    Person GetNext();
}

public class Friend : IPersonIterator
{
    public List<Person> Persons { get; set; }
    private int CurrentPosition = 0;

    public Friend(PersonsCollection persons)
    {
        Persons = persons.Persons;
    }

    public Person? GetNext()
    {
        if(!HasNext())
            return null;

        Console.WriteLine("iteratre through friend: " + Persons[CurrentPosition].Name);

        return Persons[CurrentPosition++];
    }

    public bool HasNext()
    {
        if(CurrentPosition < Persons.Count)
            return true;
        return false;
    }
}

public class FamilyMember : IPersonIterator
{
    public List<Person> Persons { get; set; }
    private int CurrentPosition = 0;

    public FamilyMember(PersonsCollection persons)
    {
        Persons = persons.Persons;
    }

    public Person? GetNext()
    {
        if(!HasNext())
            return null;

        Console.WriteLine("iteratre through family member: " + Persons[CurrentPosition].Name);

        return Persons[CurrentPosition++];
    }

    public bool HasNext()
    {
        if(CurrentPosition < Persons.Count)
            return true;
        return false;
    }
}

public class Program
{
    public static void Main()
    {
        var personsCollection = new PersonsCollection();

        var friendIterator = personsCollection.CreateFriendIterator();

        while(friendIterator.HasNext()) 
        {
            friendIterator.GetNext();
        }

        var familyMemeberIterator = personsCollection.CreateFamilyMemberIterator();

        while(familyMemeberIterator.HasNext()) 
        {
            familyMemeberIterator.GetNext();
        }
    }
}
namespace Generics_with_Delegates_sortingAlgorithem;

public delegate int Comparison<T>(T x, T y);

public class Person
{
    public int Age { get; set; }

    public required string Name { get; set; }
}

public class PersonSorter
{
    public void Sort(Person[] people, Comparison<Person> comparison)
    {
        for (int i = 0; i < people.Length - 1; i++)
        {
            for (int j = i + 1; j < people.Length; j++)
            {
                // Compare people[i] and people[j] using the provided comparison delegate
                if (comparison(people[i], people[j]) > 0)
                {
                    // Swap people[i] and people[j] if they are in the wrong order
                    Person temp = people[i];
                    people[i] = people[j];
                    people[j] = temp;


                }
            }
        }

    }
}

class Program
{
    static void Main(string[] args)
    {
        Person[] people =
        {
            new Person {Name = "Gamos", Age = 26},
            new Person {Name = "Behzad", Age = 57},
            new Person {Name = "Bahar", Age = 25},
            new Person {Name = "Amir", Age = 22},
            new Person {Name = "Batool", Age = 53}
        };

        PersonSorter sorter = new PersonSorter();

        System.Console.WriteLine("\t compare by age:");
        sorter.Sort(people, CompareByAge);

        foreach (Person person in people)
        {
            System.Console.WriteLine($"{person.Name}, {person.Age}");
        }

        System.Console.WriteLine("\t compare by name:");
        sorter.Sort(people, CompareByName);

        foreach (Person person in people)
        {
            System.Console.WriteLine($"{person.Name}, {person.Age}");
        }

    }

    static int CompareByAge(Person x, Person y)
    {
        return x.Age.CompareTo(y.Age);
    }

    static int CompareByName(Person x, Person y)
    {
        return x.Name.CompareTo(y.Name);
    }
}

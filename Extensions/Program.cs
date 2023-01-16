// See https://aka.ms/new-console-template for more information

using Extensions;


Console.WriteLine("Karol".InsertSpaces());
Console.WriteLine(6.SumWith(3));

// var person = new Person("Karol", "Rogowski");
//
// Console.WriteLine(person.GetIntroduction());
// Console.WriteLine(person.GetIntroductionPublic());
// Console.WriteLine(person.GetIntroductionPrivate());




var people = new List<Person>();
people.Add(new Person("Karol","Rogowski"));
people.Add(new Person("Adam","Korcz"));
people.Add(new Person("Kamil","Tuk"));

//LINQ
Console.WriteLine(people.FirstOrDefault(new Person("Empty","Empty")).GetIntroduction());

foreach (var person in people.Search(p =>p.FirstName[0] == 'K'))
{
    Console.WriteLine(person.GetIntroduction());
}


Console.ReadKey();

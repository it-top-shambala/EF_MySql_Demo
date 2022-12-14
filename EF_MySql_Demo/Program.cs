using EF_MySql_Demo;

var db = new DB();
/*db.TablePersons.Add(new Person
{
    FirstName = "Andrey",
    LastName = "Starinin",
    Age = 36
});
db.SaveChanges();

foreach (var p in db.TablePersons)
{
    Console.WriteLine($"{p.Id}: {p.LastName} {p.FirstName}, {p.Age}");
}
Console.WriteLine("--- --- ---");

var person = db.TablePersons.Find(2);
Console.WriteLine($"{person.Id}: {person.LastName} {person.FirstName}, {person.Age}");
person.LastName = "Anonimus";
person.FirstName = "Anonim";
db.SaveChanges();
Console.WriteLine($"{person.Id}: {person.LastName} {person.FirstName}, {person.Age}");
Console.WriteLine("--- --- ---");*/

var person_2 = db.TablePersons
    .Where(per => per.LastName == "Starinin")
    .Select(per => new {per.LastName, per.Id})
    .OrderBy(per => per.LastName)
    .ToList();

foreach (var per in person_2)
{
    Console.WriteLine($"{per.Id}: {per.LastName}");
}
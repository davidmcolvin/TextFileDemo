// See https://aka.ms/new-console-template for more information
using ConsoleUI;

string filePath = @"C:\Demos\Test.txt";

//List<string> lines = File.ReadAllLines(filePath).ToList();

//foreach (string line in lines)
//{
//  Console.WriteLine(line);
//}

//lines.Add("Sue,Storm,www.stormy.com");

//File.WriteAllLines(filePath, lines);

List<Person> people = new List<Person>();

List<string> lines = File.ReadAllLines(filePath).ToList();

foreach (var line in lines)
{
  string[] entries = line.Split(',');
  Person newPerson = new Person();

  newPerson.FirstName = entries[0];
  newPerson.LastName = entries[1];
  newPerson.Url = entries[2];

  people.Add(newPerson);
}

foreach (var person in people)
{
  Console.WriteLine($"{person.FirstName} {person.LastName} : {person.Url}");
}
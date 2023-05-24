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

Console.WriteLine("Read from text file");

foreach (var person in people)
{
  Console.WriteLine($"{person.FirstName} {person.LastName} : {person.Url}");
}

people.Add(new Person { FirstName = "Greg", LastName = "Jones", Url = "www.test.com" });

List<string> output = new List<string>();

foreach (var person in people)
{
  output.Add($"{person.FirstName},{person.LastName},{person.Url}");
}

Console.WriteLine("Writing to text file");

File.WriteAllLines(filePath, output);

Console.WriteLine("All entries written");

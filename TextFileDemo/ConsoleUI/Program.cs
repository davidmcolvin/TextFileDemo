// See https://aka.ms/new-console-template for more information
string filePath = @"C:\Demos\Test.txt";

List<string> lines = File.ReadAllLines(filePath).ToList();

foreach (string line in lines)
{
  Console.WriteLine(line);
}

lines.Add("Sue,Storm,www.stormy.com");

File.WriteAllLines(filePath, lines);

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
Console.WriteLine("Even Numbers: ");


string str = "Hello, World!";

string str1 = "22";

if (int.TryParse(str1, out int num))
{
    Console.WriteLine($"Parsed number: {num}");
}
else
{
    Console.WriteLine("Failed to parse the string as an.");
}
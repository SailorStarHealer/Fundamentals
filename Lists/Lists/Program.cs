// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var summed = new List<int> { };
for (int i = 0; i < 7; i++)
{
    var random = new Random();
    int roll1 = random.Next(1, 7);
    int roll2 = random.Next(1, 7);
    int roll3 = random.Next(1, 7);
    int roll4 = random.Next(1, 7);
    Console.Write($"You roll {roll1}, {roll2}, {roll3} {roll4}. ");
    var rolls = new List<int> { roll1, roll2, roll3, roll4 };
    rolls.Sort();
    foreach (var roll in rolls) ;
    rolls.Remove(rolls[0]);

    Console.WriteLine($"The ability score is {rolls[0] + rolls[1] + rolls[2]}");
    int sum = rolls[0] + rolls[1] + rolls[2];
summed.Add(sum);
}

Console.WriteLine($"Your available ability scores are");
foreach (var sum in summed) {
    Console.Write($"{sum}, "); }
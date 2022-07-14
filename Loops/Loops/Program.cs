// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//WorkWithString();

  //  void WorkWithString()
//{
  //  var names = new List<string> { "Yuka>", "Anna", "Felipe" };
    //foreach (var name in names)
   // {
    //    Console.WriteLine($"Hello{name.ToUpper()}!");
   // }

  //  Console.WriteLine();
  //  names.Add("Maria");
  //  names.Add("Bill");
  //  names.Remove("Anna");
  //  foreach (var name in names)
  //  {
 //       Console.WriteLine($"Hello{name.ToUpper()}!");
  //  }

 //   Console.WriteLine($"My name is {names[0]}");
//    Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");
  //  Console.WriteLine($"The list has {names.Count} people in it");

  //  var index = names.IndexOf("Felipe");
  //  if (index == -1)
  //  {
  //      Console.WriteLine($"When an item is not found, IndexOf returns{index}");
 //   }
 //   else
 //   {
  //      Console.WriteLine($"The name {names[index]} is at index {index}");
//    }
  //  index = names.IndexOf("Not Found");
//    if (index == -1)
  //  {
    //    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
  //  }
  //  else
//    {
    //    Console.WriteLine($"The name {names[index]} is at index {index}");
//    }
  //  names.Sort();
   // foreach (var name in names)
    //{
//        Console.WriteLine($"Hello {name.ToUpper()}!");
  //  }
//}

List <int> fibonacciNumbers = new List<int> { 1, 1 };

for (int index = 0; index < 18; index++)
{
    int previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    int previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
}
foreach (var item in fibonacciNumbers)
    Console.WriteLine(item);
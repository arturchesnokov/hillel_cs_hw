// See https://aka.ms/new-console-template for more information

using HW3;

var myList = new CustomClass<int> { 22, 3, 0 };

myList.OnExpandedEvent += Console.WriteLine;


myList.Add(12);
myList.Add(-2);
myList.Add(5);
myList.Add(-30);

Console.WriteLine("\nMy list:");
foreach (var item in myList)
{
    Console.WriteLine(item);
}

var sortedArray = myList.OrderBy(x => x);

Console.WriteLine("\nAfter sorting:");
foreach (var item in sortedArray)
{
    Console.WriteLine(item);
}

var filteredArray = myList.Where(x => x > 3);

Console.WriteLine("\nOnly element more then 3:");
foreach (var item in filteredArray)
{
    Console.WriteLine(item);
}
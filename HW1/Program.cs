using HW1;

var parrot1 = new Parrot();
Console.WriteLine($"Name: {parrot1.Name}, Owner: {parrot1.OwnerName}, Age: {parrot1.Age}");
//parrot1.SayHello(); Can use with default implementation only if parrot1 is IAnimal??
//but if it's IAnimal cant use Age


var parrot2 = new Parrot("Igor", "Irina", 2);
Console.WriteLine($"Name: {parrot2.Name}, Owner: {parrot2.OwnerName}, Age: {parrot2.Age}");

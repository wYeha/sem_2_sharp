int a = new Random().Next(10, 201);
Console.WriteLine(a);
if (a == a % 100) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine(a % 10);
int day = Convert.ToInt32(Console.ReadLine());
if (day >=1 && day<=5) Console.WriteLine("Нет");
else if (day>5 && day<=7) Console.WriteLine("Да");
else Console.WriteLine("Нет такого дня недели");
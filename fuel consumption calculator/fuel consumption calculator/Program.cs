using System.Xml;

Console.WriteLine("Простой калькулятор расхода топлива.");
Console.Write("Введите расстояние (км): ");
Double dist = Convert.ToDouble(Console.ReadLine());
Console.Write("Потрачено топлива (л): ");
Double vol = Convert.ToDouble(Console.ReadLine());
Double cons = (100 * vol) / dist;
string output = string.Format("Автомобиль прошел {0:F} км, потратил {1:F} литров топлива. Средний расход - {2:F} л/100 км", dist, vol, cons);
Console.WriteLine(output);
//Console.WriteLine($"Автомобиль прошел {dist} км, потратил {vol} литров топлива. Средний расход - {cons} л/100 км");

Console.ReadKey();
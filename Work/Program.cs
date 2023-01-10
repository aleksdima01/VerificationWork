Console.Clear();
Console.Write("Введите элементы строки через пробел:");
string[] array = Console.ReadLine().Split(" ");
Console.WriteLine($"[{string.Join(", ", array)}]");
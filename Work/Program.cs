Console.Clear();
Console.Write("Введите элементы строки через пробел:");
string[] array = Console.ReadLine().Split(" ");
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
void Search(string[] array)
{
    int l = 0, j = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length <= 3)
        {
            if (String.IsNullOrEmpty(array[i]))
                continue;
            l++;
        }
    }

    string[] resultArray = new string[l];
    for (int i = 0; i < array.Length; i++)
    {


        if (array[i].Length <= 3)
        {
            if (String.IsNullOrEmpty(array[i]))
                continue;
            resultArray[j] = array[i];
            j++;
        }

    }
    Console.WriteLine($"[{string.Join(", ", resultArray)}]");
}
Search(array);
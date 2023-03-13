Console.Write("Введите длину массива: ");
int numberOfDigits = int.Parse(Console.ReadLine());
int numOfLinesLessThen3 = 0;
string[] mainArray(int size)
{
    string data;
    string[] firstStrings = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите значение элемента №{i} в массиве: ");
        data = Console.ReadLine();
        firstStrings[i] = data;
        numOfLinesLessThen3 = data.Length <= 3 ? numOfLinesLessThen3 + 1 : numOfLinesLessThen3 + 0;
    }
    return firstStrings;
}
string[] result(string[] set, int size)
{
    int item = 0;
    string[] secondStrings = new string[size];
    for (int i = 0; i < set.Length; i++)
    {
        if (set[i].Length <= 3)
        {
            secondStrings[item] = set[i];
            item++;
        }
    }
    return secondStrings;
}
string[] array = mainArray(numberOfDigits);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.Write("] - > ");
Console.Write("[");
Console.Write(String.Join(", ", result(array, numOfLinesLessThen3)));
Console.Write("]");
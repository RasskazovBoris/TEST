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

// 1. Метод CreateStringArray создает массив путём ввода каждого элемента пользователем с клавиатуры.
string[] CreateStringArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        string arrayElement = Console.ReadLine()!;
        array[i] = arrayElement;
    }
    return array;
}

// 2. Метод PrintArray отображает заданный массив.
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"\"{array[i]}\", ");
        else Console.Write($"\"{array[i]}\"");
    }
    Console.Write("]");
}

// 3. Метод GetNewArrayLength возвращающий количество элементов массива, которые не превышают заданное максимальное допустимое количество символов.
int GetNewArrayLength(string[] array, int maxElementsLength)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxElementsLength) count++;
    }
    return count;
}

// 4. Метод GetNewArray возвращает новый массив с элементами, не превышающими максимальное допустимое количество символов. 
string[] GetNewArray(string[] array, int maxElementsLength, int count)
{
    string[] newArray = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxElementsLength)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

// 5. Решение
Console.WriteLine("Введите количество элементов массива: ");
int firstArrLength = Convert.ToInt32(Console.ReadLine());

string[] firstArray = CreateStringArray(firstArrLength);
Console.WriteLine($"Преобразование исходного массива строк в новый массив из строк, длина которых меньше либо равна трём символам: ");
PrintArray(firstArray);

int maxElemLength = 3;
int newArrayLength = GetNewArrayLength(firstArray, maxElemLength);
string[] newArr = GetNewArray(firstArray, maxElemLength, newArrayLength);
Console.Write($" -> ");
PrintArray(newArr);
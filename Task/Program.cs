Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());

Console.WriteLine("Заполните массив: ");
string[] array = CreateArr(size);
Console.WriteLine();
Console.WriteLine("Исходный массив: ");
PrintArr(array);

string[] result = FilterArr(array);
Console.WriteLine();
Console.WriteLine("Отфильтрованный массив: ");
PrintArr(result);

string[] FilterArr(string[] array)
{
    string[] filteredArr = new string [array.Length];
    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            filteredArr[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref filteredArr, j);
    return filteredArr;
}



string[] CreateArr(int size)
{
    string[] array = new string [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array; 
}

void PrintArr(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
} 
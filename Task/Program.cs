int size = int.Parse(Console.ReadLine());


string[] array = CreateArr(size);
PrintArr(array);

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
} 
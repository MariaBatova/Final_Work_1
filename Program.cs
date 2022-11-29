string[] CreateArray(int size)
{
    string[] array = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент массива: ");
        string? value = Console.ReadLine();
        while(value == String.Empty)
        {
            Console.Write("Ошибка. Введите элемент массива: ");
            value = Console.ReadLine();
        }
        if(value != null) array[i] = value;
    }
    return array;
}

string[] StringArray(string[] array, int symbol = 3)
{
    int NewArray = 0;
    for(int i = 0; i < array.Length;i++)
        if(array[i].Length <= symbol) NewArray++;

    string[] newArray = new string[NewArray];

    for(int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length <= symbol)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("Созданный массив: [");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("'" + array[i] + "'");
        if(i < array.Length -1) Console.Write(",");
    }
    Console.Write("]");
    Console.WriteLine();
}

try
{
    Console.Write("Введите размер массива: ");
    int sizeArray = Convert.ToInt32(Console.ReadLine());
    while(sizeArray < 0)
    {
        Console.WriteLine("Размер массива - это целое положительное число.");
        Console.Write("Введите новое значение: ");
        sizeArray = Convert.ToInt32(Console.ReadLine());
    }
    if(sizeArray == 0) 
        Console.WriteLine("Размер массива = 0. Массив пустой: []");
    else 
    {
        string[] stringArray = CreateArray(sizeArray);
        PrintArray(stringArray);
        string[] newStringArray = StringArray(stringArray);
        PrintArray(newStringArray);
    }
}
catch(Exception)
{
    Console.WriteLine("Недопустимый ввод!");
}

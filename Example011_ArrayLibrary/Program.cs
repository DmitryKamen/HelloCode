// Работа с функциями и массивами
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        // index = index + 1
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если тут int pos = IndexOf(array, 4); будет вместо 4, число не от 1 до 10, вывод -1
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; // нужно чтобы не искать остальные индексы значения в которых будет 4, а найти самый первый и прервать
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);



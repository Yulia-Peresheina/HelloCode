// 

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] massive, int found)
{
    int numbers = massive.Length;
    int ind = 0;
    int position = -1;
    while (ind < numbers)
    {
        if (massive[ind] == found)
        {
            position = ind;
            break;
        } 
        ind++;

    }
    return position;
}

int[] array = new int[10];

FillArray(array);
//строки 48 и 49 для проверки кода
array[4] = 4;
array[7] = 4;
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);
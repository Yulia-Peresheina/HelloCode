// Сортировка массива по возрастанию

int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();

}
PrintArray(array);

void Selection(int[] arr)
{

    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPos = i;

        for (int j = i + 1; j < arr.Length; j++)
        {

            if (arr[j] < arr[minPos])
            {
                minPos = j;

            }

        }
        int temp = arr[i];
        arr[i] = arr[minPos];
        arr[minPos] = temp;

    }
}

Selection(array);
PrintArray(array);

void Selection2(int[] arr)
{

    for (int i = 0; i < arr.Length - 1; i++)
    {
        int maxPos = i;

        for (int j = i + 1; j < arr.Length; j++)
        {

            if (arr[j] > arr[maxPos])
            {
                maxPos = j;

            }

        }
        int temp = arr[i];
        arr[i] = arr[maxPos];
        arr[maxPos] = temp;

    }
}

Selection2(array);
PrintArray(array);

// Найти в массиве индекс числа

int[] array = {1, 3, 56, 2, 87, 69, 56, 90, 10};

int N = 56;
//int n = array.Length;
int index = 0;

 while (index < array.Length)
 {
    if (array[index] == N)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
 }


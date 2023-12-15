int[,] InitArray(int x, int y, int min, int max)
{
    int[,] array = new int[x, y];
    Random rand = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            array[i, j] = rand.Next(min, max);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j]);
            System.Console.Write(' ');

        }
    }
}
int FindLineWithMinSumOfElements(int[,] array)
{
    int lineNumber = 0;
    int minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];

        }
        if (i == 0)
        {
            minsum = sum;

            lineNumber = i;
        }
        if (sum < minsum)
        {
            minsum = sum;

            lineNumber = i;
        }
        System.Console.WriteLine("\n сумма " + i + " строки равна " + sum);
    }
    return lineNumber;
}

int[,] matrix = InitArray(15, 13, 0, 11);
PrintArray(matrix);
System.Console.WriteLine("\n строка с минимальной суммой элементов имеет индекс " + FindLineWithMinSumOfElements(matrix));
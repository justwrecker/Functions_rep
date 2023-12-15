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
void ChangeLines(int[,] array)
{
    int[] tempLine = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        tempLine[i] = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = tempLine[i];
    }

}

int[,] theArray = InitArray(2, 4, 5, 10);
PrintArray(theArray);
ChangeLines(theArray);
System.Console.WriteLine("\n");
PrintArray(theArray);

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
int[] FindMinElement(int[,] array )
{   int[] indexes = new  int[2];
    int min=array[0,0];
for(int i=0;i<array.GetLength(0);i++){
    for(int j=0;j<array.GetLength(1);j++){
        if (array[i,j]<min)
        {
            min = array [i,j];
            indexes[0]=i;
            indexes[1]=j;
        } 
    }
}

return indexes;
}
 int[,] DowngradeTheMassive(int[] indexes, int[,] array)
 {int[,] smallerArray = new int[array.GetLength(0)-1,array.GetLength(1)-1];
 int row=0;
 
 for(int i=0;i<smallerArray.GetLength(0);i++){
    if(i== indexes[0]) row++;
    int col=0;
    for(int j=0;j<smallerArray.GetLength(1);j++)
    {
        if (j== indexes[1]){
            col++;
        }
         smallerArray[i,j]= array[row,col]; 
         col++;
    }
    row++;
 }

return smallerArray;
 }
int[,] theMatrix = InitArray(3, 4, 0, 10);
PrintArray(theMatrix);
int[] coordinate = FindMinElement(theMatrix);
int [,] newMass = DowngradeTheMassive(coordinate,theMatrix);
System.Console.WriteLine();
PrintArray(newMass);

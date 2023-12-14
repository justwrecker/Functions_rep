using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

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

string GetValue(int[,] array,int i, int j)
{ string answer="";
if((i>=0 && i< array.GetLength(0)) && (j>=0 && j< array.GetLength(1)) )
{
    answer = "\nThe Element you are looking for is on the line " + (i+1) + " and the column " + (j+1) +" of the printed array" + "\n It's value is  " + System.Convert.ToString(array[i,j]);
}
else answer = "\nNo element with such parameters (line " + (i+1)+ " and column "+ (j+1) +  ") found";

    return answer;
}

int[,] myArray = InitArray(5, 5, 0, 101);
PrintArray(myArray);
System.Console.WriteLine(GetValue(myArray,0,-1));
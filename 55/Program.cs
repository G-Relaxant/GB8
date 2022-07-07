Console.WriteLine();
int [,] array = new int[10, 10];
int [,] arraySwap = new int[10, 10];
FillArray(array);
PrintArray(array);
if(array.GetLength(0) == array.GetLength(1))
{
    SwapStringsToColumnsArray(array, arraySwap);
    Console.WriteLine();
    PrintArray(arraySwap);
    Console.WriteLine();
}
else
{
    Console.WriteLine("В данном массиве невозможно поменять строки на столбцы");
    Console.WriteLine();
}


void FillArray(int [,] a)
{
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(-9, 10);
        }
    }
}
void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)          
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            if(a[i, j] < 0)
            {
                Console.Write(a[i, j] + " ");
            }
            if(a[i, j] < 10 && a[i, j] >= 0)
            {
                Console.Write(" " + a[i, j] + " ");
            }
            if(a[i, j] > 10)
            {
                Console.Write(a[i, j] + " ");
            }
            
        }
    Console.WriteLine("");
    }
}
void SwapStringsToColumnsArray(int [,] a, int [,] b)
{
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            b[i, j] = a[j, i];
        }
    }
}
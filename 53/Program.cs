Console.WriteLine();
int [,] array = new int[10, 10];
FillArray(array);
PrintArray(array);
SwapUpDownStringsArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();

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
void SwapUpDownStringsArray(int [,] a)
{
    int j = a.GetLength(0) - 1;
    int bufer = 0;
    for(int i = 0; i < a.GetLength(1); i++)
    {
        bufer = a[0, i];
        a[0, i] = a[j, i];
        a[j, i] = bufer;
    }
}
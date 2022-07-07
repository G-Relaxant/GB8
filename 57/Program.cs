int[] oneDimArray = new int[24];
FillOneDimensionalArray(oneDimArray);
Console.WriteLine();
PrintOneDimArray(oneDimArray);
Console.WriteLine();
int [,] twoDimArray = new int[10, 10];
FillTwoDimensionalArray(twoDimArray);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();
OneDimArrayValuesFrequenceCounter(oneDimArray);
Console.WriteLine();
TwoDimArrayValuesFrequenceCounter(twoDimArray);
Console.WriteLine();


void FillOneDimensionalArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0, 10);
    }
}
void PrintOneDimArray(int[] b)
{
    Console.Write("[");
    for(int i = 0; i < b.Length; i++)
    {
        Console.Write(b[i]);
        if(i < b.Length - 1)
            Console.Write(", ");
        else
            Console.WriteLine("]");
    }
}
void FillTwoDimensionalArray(int [,] a)
{
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintTwoDimArray(int[,] a)
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
void OneDimArrayValuesFrequenceCounter(int[] a)
{
    int[] b = new int[10];
    int buf = 0;
    for(int i = 0; i < a.Length; i++)
    {
        buf = a[i];
        b[buf]++;
    }
    for(int i = 0; i < b.Length; i++)
    {
        if(b[i] > 0)
        {
            Console.WriteLine("Количество ячеек со значением " + i + " в одномерном массиве: " + b[i]);
        }
    }
}
void TwoDimArrayValuesFrequenceCounter(int[,] a)
{
    int[] b = new int[10];
    int buf = 0;
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            buf = a[i, j];
            b[buf]++;
        }
    }
    for(int i = 0; i < b.Length; i++)
    {
        if(b[i] > 0)
        {
            Console.WriteLine("Количество ячеек со значением " + i + " в двухмерном массиве: " + b[i]);
        }
    }
}
Console.WriteLine();
int [,] twoDimArray = new int[10, 10];
int [,] twoDimArraySecond = new int[twoDimArray.GetLength(0) - 1, twoDimArray.GetLength(1) - 1];
FillTwoDimensionalArray(twoDimArray);
Console.Write("Введите индекс строки, которую хотите исключить: ");
int stringException = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца, который хотите исключить: ");
int columnException = Convert.ToInt32(Console.ReadLine());
twoDimArray[stringException, columnException] = 0;
Console.WriteLine();
PrintTwoDimArray(twoDimArray);
Console.WriteLine();
FillSecondArrayWithoutIntersectionLines(twoDimArray, twoDimArraySecond);
PrintTwoDimArray(twoDimArraySecond);
Console.WriteLine();


void FillTwoDimensionalArray(int [,] a)
{
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(1, 10);
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
void FillSecondArrayWithoutIntersectionLines(int [,] a, int [,] b)
{
    int minValueCellVertical = 0;
    int minValueCellGorizontal = 0;
    for (int i = 0; i < a.GetLength(0); i++)          
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            if(a[i, j] < 1)
            {
                minValueCellVertical = i;
                minValueCellGorizontal = j;
            }
        }
    }
    int y = 0;
    int x = 0;
    for(int i = 0; i < a.GetLength(0); i++)
    {
        if(i != minValueCellVertical)
        {
            x = 0;
            for(int j = 0; j < a.GetLength(1); j++)
            {
                if(j != minValueCellGorizontal)
                {
                    //Console.WriteLine("y= " + y);
                    //Console.WriteLine(x);
                    //Console.WriteLine(i);
                    //Console.WriteLine(j);
                    b[y, x] = a[i, j];
                    x++;
                }
            }
            y++;
        }
    }
}
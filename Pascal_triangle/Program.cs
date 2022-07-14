
// Равнобедренный треугольник Паскаля от Сергея Камянецкого

int row = 9;
const int cellWidth = 3;
int[,] triangle = new int[row, row];
FillTriangle();
PrintTriangle();
void FillTriangle()
{
    for(int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for(int i = 2; i < row; i++)
    {
        for(int j = 1; j <= i; j++)
        {
            triangle[i, j] = 
                triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}
void PrintTriangle()
{
    int col = cellWidth * row;
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if(triangle[i, j] != 0)
                Console.Write($"{triangle[i, j],cellWidth}");
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}



// Вариант из семинара, корректно отображает первые 5 строк
/*
int y = 5;
int x = 2 * y - 1;
int [,] triangle = new int[y, x];
FillTriangle(triangle);
Console.WriteLine();
PrintTriangle(triangle);
Console.WriteLine();


void FillTriangle(int [,] a)
{
    int middle = y - 1;
    int left = middle;
    int right = middle;
    for(int i = 0; i < y; i++)
    {
        for(int j = 0; j < x; j++)
        {
            if(left == j && right == j)
            {
                a[i,j] = 1;
                left--;
                right++;
                break;
            }
            else
            {
                if(left == j)
                {
                    a[i,j] = 1;
                    left--;
                }
                else
                {
                    if(right == j)
                    {
                        a[i,j] = 1;
                        right++;
                        break;
                    }
                    else
                    {
                        a[i,j] = 0;
                    }
                }
            }
        }
    }
    for(int i = 2; i < y; i++)
    {
        for(int j = 0; j < x; j++)
        {
            if(j != 0 && j < x - 1 && a[i,j] == 0)
            {
                a[i,j] = a[i - 1, j - 1] + a[i - 1, j + 1];
            }
        }
    }
}
void PrintTriangle(int [,] a)
{
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            if(a[i,j] != 0)
            {
                if(a[i,j] < 10)
                {
                    Console.Write($"{a[i,j]}  ");
                }
                else
                {
                    if(a[i,j] < 100)
                    {
                        Console.WriteLine($"{a[i,j]} ");
                    }
                }
            }
            else
            {
                Console.Write("    ");
            }
        }
        Console.WriteLine();
    }
}
*/

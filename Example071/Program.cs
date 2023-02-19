// 71. Показать числа от N до 1, N задано
int N = 10;
PrintDigit(N);



void PrintDigit(int N)
{
    if(N>0)
    {
        System.Console.WriteLine(N);
        PrintDigit(N-1);
    }
}

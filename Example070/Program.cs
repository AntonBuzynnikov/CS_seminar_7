// 70. Показать натуральные числа от 1 до N, N задано
int N = 10;
int i = 1;
PrintDigit(i,N);

void PrintDigit(int i, int N)
{
    System.Console.WriteLine(i);
    if(i<N) PrintDigit(i+1,N);
}




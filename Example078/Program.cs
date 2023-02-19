// 78. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1. Использовать рекурсию.
System.Console.WriteLine("Введите число");
int N = Int32.Parse(Console.ReadLine());
PrintFibDigit(N,0);





int FibDigit(int N)
{
    if(N==0) return 0;
    else
        if (N == 1) return 1;
        else
            return FibDigit(N-1) + FibDigit(N-2);
}
void PrintFibDigit(int N,int i)
{
    if(i<N)
    {
        System.Console.Write($"{FibDigit(i),5}");
        PrintFibDigit(N,i+1);
    }
}
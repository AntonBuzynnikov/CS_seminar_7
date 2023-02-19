// 75.Показать фунцию Аккермана
int n = 4;
int m = 4;

int AckermanFunction(int n, int m)
{
    if (n == 0) return m+1;
    else
        if(m == 0) return AckermanFunction(n-1,1);
            else 
                return AckermanFunction(n-1,AckermanFunction(n,m-1));
}

for(int i = 0; i < n;i++)
{
    for(int j = 0;j<m;j++)
    {
        System.Console.Write($"{AckermanFunction(j,i),4}");
    }
    System.Console.WriteLine();
}

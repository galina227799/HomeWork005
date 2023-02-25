Console.Clear();
Console.Write("Введите число M:");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите число N:");
int N = int.Parse(Console.ReadLine());
int summa = 0;
Console.WriteLine(SumNum(M,N,summa));

int SumNum(int M, int N, int Sum)
{

    if(M <= N) 
    {

    Sum = Sum+M+SumNum(M+1,N,Sum);
    }
    
    
    return Sum;
}
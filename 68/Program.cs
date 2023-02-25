Console.Clear();
Console.Write("Введите значение n:");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите значение m:");
int m = int.Parse(Console.ReadLine());
int res = 0;
Console.WriteLine(FuncAkkerman(n,m,res));


int FuncAkkerman(int n, int m, int res)
{


    if((n+m)!= 0) 

    {
        if(n==0) res=m+1;
        else if(m==0) res = FuncAkkerman(n-1,1,res);
        
        else res = FuncAkkerman(n-1,FuncAkkerman(n,m-1,res),res);
    
    }
    
    
    return res;
}
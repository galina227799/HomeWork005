Console.Clear();
Console.Write("Введите число N:");
int Number = int.Parse(Console.ReadLine());
Console.WriteLine(PrintNum(Number));

string PrintNum(int end)
{

    if(end == 1)  return "1";

    string s = end.ToString()+" "+PrintNum(end-1);

    
    return s;
}
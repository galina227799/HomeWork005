double[] GetArrayFromString(string Str)
{
   string[] num = Str.Split(" ",StringSplitOptions.RemoveEmptyEntries);
   double[] res = new double[num.Length];
   for(int i = 0; i<num.Length; i++)
   {
     res[i] = double.Parse(num[i]);
   }
   return res;
}
double[] TochkaPeresecheniya(double[] arr)
{ 
    double[] res = new double[2];
    res[0]=((arr[3]-arr[1])/(arr[0]-arr[2]));
    res[1]=res[0]*arr[0]+arr[1];
    return res;
}

Console.Clear();
Console.Write("Введите Коэффициенты к1, в1 к2, в2 через пробел: ");
String Str = Console.ReadLine();
double[] arr = GetArrayFromString(Str); 
Console.WriteLine($"Точка пересечения: ({String.Join(";",TochkaPeresecheniya(arr))})");



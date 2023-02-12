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
double Raznica(double[] arr)

{ 
    double max = arr[0];
    double min = arr[0];
    foreach(double el in arr)
    {
        max = el > max ? el : max;
        min = el < min ? el : min;
    }
    
return max-min;
}

Console.Clear();
Console.Write("Введите массив вещественных чисел через пробел: ");
String Str = Console.ReadLine();
double[] arr = GetArrayFromString(Str); 
Console.WriteLine($"Разница между максимальныи и минимальным значением -> {Raznica(arr)}");

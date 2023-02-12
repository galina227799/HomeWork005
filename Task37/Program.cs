int[] GetArrayFromString(string Str)
{
   string[] num = Str.Split(" ",StringSplitOptions.RemoveEmptyEntries);
   int[] res = new int[num.Length];
   for(int i = 0; i<num.Length; i++)
   {
     res[i] = int.Parse(num[i]);
   }
   return res;
}
int[] GetArrayAdd(int[] arr)

{ 
    int[] arr1 = new int[arr.Length/2+arr.Length%2];
    int j = arr.Length-1;
    for(int i=0; i < arr1.Length; i++)
    {
        if(i==j) arr1[i] = arr[i];
        else arr1[i] = arr[i]*arr[j];
        j=j-1;
    }
return arr1;
}


Console.Clear();
Console.Write("Введите массив чисел через пробел: ");
String Str = Console.ReadLine();
int[] arr = GetArrayFromString(Str); 
Console.WriteLine($"[{String.Join(" ",GetArrayAdd(arr))}]");

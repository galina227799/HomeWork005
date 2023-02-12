int[] GetArray(int size, int minValue, int maxValue) // Получение массива случайных элементов
{
int[] res = new int[size];

for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

int ColVProm(int[] arr, int minValue, int maxValue)
{
    int res=0;
    foreach(int el in arr)
    {
        if(el>= minValue && el<= maxValue) res +=1; 
    }
    return res;
}
Console.Clear();
int[] arr = GetArray(123,0,1001);
Console.WriteLine($"[{String.Join(",", arr)}]");
Console.Write($"Количество  элементов в промежутке от 10 до 99: {ColVProm(arr, 10, 99)}");

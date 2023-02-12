int[] GetArray(int size, int minValue, int maxValue) // Получение массива случайных элементов
{
int[] res = new int[size];

for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

int ColNechIndex(int[] arr)
{
    int res=0;
    for(int i=1; i<arr.Length; i+=2) res += arr[i];
    return res;
}
Console.Clear();
int[] arr = GetArray(5,-50,50);
Console.WriteLine($"[{String.Join(",", arr)}]");
Console.Write($"Сумма элементов стоящих на нечетной позиции: {ColNechIndex(arr)}");
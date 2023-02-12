int[] GetArray(int size, int minValue, int maxValue) // Получение массива случайных элементов
{
int[] res = new int[size];

for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

int ColChet(int[] arr)
{
    int res=0;
    foreach(int el in arr)
    {
        if(el%2 == 0) res +=1; 
    }
    return res;
}
Console.Clear();
int[] arr = GetArray(5,100,1000);
Console.WriteLine($"[{String.Join(",", arr)}]");
Console.Write($"Количество четных элементов: {ColChet(arr)}");
﻿using System.Diagnostics;

bool Check(int[] array) // Метод - ЮнитТест, проверяет что все эл упорядочены
{
    int size = array.Length;
    
    for (int i = 0; i < size - 1; i++)
    {
        if (array[i] > array[i + 1]) return false;
    }
    return true;
}

bool show = !true;

int n = 50000;
int max = 100;
int[] array = new int[n];

for (int i = 0; i < n; i++) array[i] = Random.Shared.Next(max);
if (show) Console.WriteLine($"[{String.Join(',' ,array)}]");
int[] arr1 = new int[n]; // Делаем копии, чтобы тесты делали для того же массива
int[] arr2 = new int[n];
int[] arr3 = new int[n];

Array.Copy(array, arr1, n);
Array.Copy(array, arr2, n);
Array.Copy(array, arr3, n);
// Console.WriteLine(Check(array)); // Вызов юнит теста

if (show) Console.WriteLine($"arr1: [{String.Join(',' ,arr1)}]");

Stopwatch sw = new Stopwatch(); // Алгоритм таймера 
sw.Start();

for (int k = 0; k < n - 1; k++) // медленный алгоритм
{
    for (int i = 0; i < n - 1; i++)
    {
        if(arr1[i] > arr1[i + 1])
        {
            int temp = arr1[i];
            arr1[i] = arr1[i + 1];
            arr1[i + 1] = temp;
        }
    }
}
sw.Stop();
Console.WriteLine($"arr1 - {Check(arr1)} {sw.ElapsedMilliseconds}ms");

if (show) Console.WriteLine($"arr1: [{String.Join(',' ,arr1)}]");
if (show) Console.WriteLine($"arr2: [{String.Join(',' ,arr2)}]");
// Console.ReadLine(); // ИСкуственная пауза
sw.Reset();
sw.Start();


for (int k = 0; k < n - 1; k++)
{
    for (int i = 0; i < n - 1 - k; i++) // -k так как нет смысла делать проверку эл который в ходе сортировли поставили на место
    {
        if(arr2[i] > arr2[i + 1])
        {
            int temp = arr2[i];
            arr2[i] = arr2[i + 1];
            arr2[i + 1] = temp;
        }
    }
}
sw.Stop();
Console.WriteLine($"arr2 - {Check(arr2)} {sw.ElapsedMilliseconds}ms");

if (show) Console.WriteLine($"arr2: [{String.Join(',' ,arr2)}]");



sw.Reset();
sw.Start();

for (int k = 0; k < n; k++) // визуально код хуже хоть и дает время быстрее
{
    bool check = true;
    for (int i = 0; i < n - 1 - k; i++)
    {
        if (arr3[i] > arr3[i + 1])
        {
            check = false;
            int temp = arr3[i];
            arr3[i] = arr3[i + 1];
            arr3[i + 1] = temp;
        }
    }
    if (check) break;
}
sw.Stop();
Console.WriteLine($"arr3 - {Check(arr3)} {sw.ElapsedMilliseconds}ms");

if (show) Console.WriteLine($"arr3: [{String.Join(',' ,arr3)}]");

// Console.WriteLine(Check(array));



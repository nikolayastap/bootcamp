// int n = 5;
// int[] array = new int[n]; // Создали массив 
// for (int i = 0; i < n; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine()); // Пользователь заполняет массив
// Console.WriteLine("[" + string.Join(", ", array) + "]"); // Выводит массив, Join соиденяет эл массива
//     // Console.WriteLine(array[3]); // Находит эл под индексом 3
//     // Сложность алгоритма - (О натация) О(1) - для поиска запроса потребовалось 1но действие
//         // [4, 5, 3, 1, 2]
//         // O(n)
//         // [1, 2, 3, 4, 5] = O(n * log n) время быстрой сортировки
//         // ((5 + 1)/2) * 5 = O(1) - сумма арефметической прогрессии

//         // n < n * log(n) + 1
//         // Не всегда использование сложн алгоритмов приведет к быстрому решению
// int summa = 0;
// for (int i = 0; i < n; i++)
//     summa += array[i]; // Сумма эл массива
// Console.WriteLine(summa);




// int n = Convert.ToInt32(Console.ReadLine()); // Таблица умножения BadCode
// for (int i = 1; i <= n; i++)
// {
//     for (int j = 1; j <= n; j++)
//     {
//         Console.Write(i * j);
//         Console.Write("\t");
//     }
//     Console.WriteLine();
// }

int n = Convert.ToInt32(Console.ReadLine()); // Таблица умножения GoodCode с помощю матрицы
int[, ] matrix = new int[n, n];
for(int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1); // Матрица заполняется углом, при каждом переходе счетчика сдвикается +1 вправо и вниз
        matrix[j, i] = (i + 1) * (j + 1);
    }
    Console.WriteLine();
}
for(int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
// O(n^2)


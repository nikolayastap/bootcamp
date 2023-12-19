// Задача с последовательным нахождением суммы элементов массива
// (найти максимальную сумму трех подряд стоящих чисел)
// 0 1 2 3 4 5 6 7 8 9
// 4 6 1 4 7 9 2 4 6 1

int[] array = 20.Create() // Создаем массив
                .Fill(1, 10); // Заполняем
array.ConvertToStringAndPrintToTerminal();

Console.WriteLine($"BadGetSum: {array.BadGetSum()}"); // В скобки можно поставить число, на которое изменится число m
Console.WriteLine($"GoodGetSum: {array.GoodGetSum()}"); // В скобки можно поставить число, на которое изменится число m
// Console.WriteLine(array.ConvertToString());



// using System.Diagnostics; // Для вычесления и сравнения время двух алгоритмов

// int[] array =100000.Create()
//                 .Fill(1, 10);
// // array.ConvertToStringAndPrintToTerminal();


// int m = 10000;
// Stopwatch sw = new Stopwatch();
// sw.Start();

// int max = array.BadGetSum(m);
// sw.Stop();

// Console.WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds}");

// sw.Reset();
// sw.Start();
// max = array.GoodGetSum(m);
// sw.Stop();
// Console.WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");
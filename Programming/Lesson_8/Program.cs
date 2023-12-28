// Быстрая Сортировка O(n * log2(n))
// Напишите программу, которая принимает на вход два числа(a и b) и выполняет сложения
// без оператора a + b

                // int summNumbers(int a, int b){
                //     if (b == 0)
                //         return a;
                //     return summNumbers(a + 1, b - 1);
                // }   


                // Console.Clear();
                // Console.Write("Введите 1-ое число: ");
                // int a = int.Parse(Console.ReadLine()!);
                // Console.Write("Введите 2-ое число: ");
                // int b = int.Parse(Console.ReadLine()!);
                // Console.WriteLine($"{a} + {b} = {summNumbers(a, b)}");
                /*
                summNumbers = S
                S(2, 3) = S(3, 2) = S(4, 1) = S(5, 0) = 5
                */

    /*
    [3, -10, 0, 2, -1, 9, 4, 5, 3]
    pivot = 3 // Первый эл.
    [-10, 0, 2, -1] + [3, 3] + [9, 4, 5] // Делим массив на 3и массива. 1 меньше опорного, 2 равен, 3 больше

    [-10, 0, 2, -1]
    pivot = -10
    [] + [-10] + [0, 2, -1]

    [0, 2, -1]
    pivot = 0
    [-1] + [0] + [2]


    [9, 4, 5]
    pivot = 9
    [4, 5] + [9] + []


    [4, 5]
    pivot = 4
    [] + [4] + [5]



    [-10] + [-1] + [0] + [2] + [3, 3] + [4] + [5] + [9] // Сборка отсортированного массива
    */


int[] quickSort(int[] array, int leftIndex, int rightIndex){
    Console.WriteLine($"[{string.Join(", ", array)}]\nleftIndex={leftIndex}\nrightIndex={rightIndex}\n");
    int i = leftIndex, j = rightIndex, pivot = array[leftIndex];
    while (i <= j){
        while (array[i] < pivot){
            i++;
        }
        while (array[j] > pivot){
            j--;
        }
        if (i <= j){
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
    }
    if (leftIndex < j)
        quickSort(array, leftIndex, j);
    if (i < rightIndex)
        quickSort(array, i, rightIndex);

    return array;
}




Console.Clear();
int[] array = {3, -10, 0, 2, -1, 9, 4, 5, 3};
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", quickSort(array, 0, array.Length - 1))}]");
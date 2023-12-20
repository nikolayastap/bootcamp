// Сортировка Выбором

/*
2 7 0 3 -5 12 8  min определяется эл [0] и сравнивается со всеми, при нахождении меньшего значения присваивается min
^
-5 7 0 3 2 12 8  min определяется эл [1] ...... и тд
   ^
-5 0 7 3 2 12 8
     ^
-5 0 2 3 7 12 8
       ^
-5 0 2 3 7 12 8
         ^
-5 0 2 3 7 12 8
           ^
-5 0 2 3 7 8 12
*/
        // char f() // , int f(), string f() -> функция возвращает тип данных 
        // {
        //     return '1';
        // }

        // void v() // -> процедура ни когда ни чего не возращает
        // {
        //     Console.WriteLine("Hello, world!");
        // }


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11); // функция Next не включает последний эл [-10, 10]
}

int[] SortVibor(int[] array) // [2 7 0 3 -5 12 8]
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i; // i = [0] -> 2
        for (int j = i + 1; j < array.Length; j++) // j = [1]++
        {
            if (array[j] < array[min])
            {
                min = j; // min = [4]
            }
        }
        int temp = array[min]; // Делаем замену с помощи временной переменной
        array[min] = array[i];
        array[i] = temp;
    }
    return array;
}



Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n]; // после этого создастся массив и заполнится 0 n штук
InputArray(array); // Заполняет массив
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]"); // выводит массив через запятую и пробел
Console.WriteLine($"Конечный массив: [{string.Join(", ", SortVibor(array))}]");


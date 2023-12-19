// // Способ 1 (посдедоавтельно сумируются 3 эл, затем смехается на 1 вперед и вновь сумируютя 3 эл)
public static class ArrayMath
{
    public static int BadGetSum(this int[] array, int m = 3)
    {
        int max = 0;
        int size = array.Length;

        for (int i = 0; i <= size - m; i++)
        {
            int t = 0;
            for (int j = i; j < i + m; j++)
            {
               t += array[j];
            }
            if (t > max) max = t;
        }
        return max;
    }

// Способ 2 (Принудительно сумируются первые 3 эл, записываем как max, прибавляем слуд эл, а первый вычетаем и тд, если больше max то записываем)
    public static int GoodGetSum(this int[] array, int m = 3)
    {
        int max = 0;
        int size = array.Length;
        for (int i = 0; i < m; i++) max += array[i]; //Находим сумму первых 3х m элементов
        int t = max; // Временная сумма
        // Console.WriteLine($"i:{0} t:{t}"); // Показывает промежуточеную сумму

        for (int i = 1; i <= size -m; i++)
        {
            t = t - array[i - 1] + array[i + m - 1];
            // Console.WriteLine($"i:{i} t:{t}"); // Показывает промежуточеную сумму
            if (t > max) max = t;
        }
       

        return max;
    }
}
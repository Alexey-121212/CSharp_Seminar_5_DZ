// Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.

// Программа должна иметь метод SumOddElements, который принимает массив целых чисел и возвращает сумму элементов с нечетными индексами в массиве.

// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

// Аргументы, передаваемые в метод/функцию:


// '18, 76, 11'
// На выходе:


// 18  76  11  
// Сумма нечетных элементов: 76


int[] arr = {9,	53,	25,	87,	6};


Console.Clear();
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Сумма нечетных элементов {SumOddElements(arr)}");

// Methods

static int SumOddElements(int[] array)
{
    // Введите свое решение ниже
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
            sum += array[i];
    }
    return sum;

}

static void PrintArray(int[] array)
{
    // Введите свое решение ниже
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();

}
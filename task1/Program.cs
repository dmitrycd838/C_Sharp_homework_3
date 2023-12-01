
// // // Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// // // Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// int N = 10;
// int[] array = new int[N];

// Random rand = new Random();


// for (int i = 0; i < array.Length; i++)
//     array[i] = rand.Next(1, 101);
// for (int i = 0; i < array.Length; i++)
//     System.Console.Write("[" + array[i] + "]");

// int count = 0;
// for (var i = 0; i < array.Length; i++)
// {
//     if (array[i] > 20 && array[i] < 90)
//         count++;
// }
// System.Console.WriteLine();
// System.Console.WriteLine(count);

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// // Создаём функцию, которая возвращает массив, внутрь принимает следующие значения: 
// 1. размер массива
// 2. Граница генерации - от какого и до какого значения мы генерируем массив 

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    // Внутри функции объявляем массив размером size. 
    int[] tempArray = new int[size];
    // Задаём объект класса Random для генерации случайных чисел. 
    Random rand = new Random();
    // Используем цикл for
    for (int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }
    // Вернуть значение массива
    return tempArray;
}

// Выводим вывод массива в отдельную функцию
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int size = ReadInt("Введите размер массива: ");
// Объявим массив, который равен работе метода GenerateArray, внутрь метода мы отправим
// 1. размер генерируемого массива
// 2. левую границу генерации.
// 3. правую границу генерации. 
int[] myArray = GenerateArray(size, 1, 100); 
PrintArray(myArray);

int count = 0;

foreach ( int number in myArray)
    if (number > 20 && number < 90)
    {
        count++;
    }
System.Console.Write($"Количество элементов массива значение которых лежит в отрезке [20, 90] = {count} ");
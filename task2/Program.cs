// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве


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
    if (number % 2 == 0)
    {
        count++;
    }
System.Console.Write($"Чётных чисел в массиве: {count} ");
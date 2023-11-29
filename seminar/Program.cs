// УСЛОВИЕ ЗАДАЧИ:
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// ПРИМЕРЫ:
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 

// РЕШЕНИЕ:


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
    System.Console.Write("[" + string.Join(", ", array) + "]");
}

// Объявим функцию для поиска числа в массиве

void FindNumber(int[] array, int N)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == N)
        {
            System.Console.Write("Да");
            return;
        }
    }

    System.Console.Write("Нет");
}


int size = ReadInt("Введите размер массива: ");
// Объявим массив, который равен работе метода GenerateArray, внутрь метода мы отправим
// 1. размер генерируемого массива
// 2. левую границу генерации.
// 3. правую границу генерации. 
int[] myArray = GenerateArray(size, -10, 10); 
PrintArray(myArray);

int number = ReadInt("Введите искомое число: ");
FindNumber(myArray, number);

// // Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// // Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int N = 10;
int[] array = new int[N];

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(1, 101);
for (int i = 0; i < array.Length; i++)
    System.Console.Write("[" + array[i] + "]");

int count = 0;
for (var i = 0; i < array.Length; i++)
{
    if (array[i] > 20 && array[i] < 90)
        count++;
}
System.Console.WriteLine();
System.Console.WriteLine(count);
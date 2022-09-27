// /* Задача 3. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел (размер массива не более 50 элементов). 
// Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34 */

Console.WriteLine("Введите размеры массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(10,50));  
}

for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
// Задача 1: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Номер строки с наименьшей суммой элементов: 1 строка
// (допускается указывать индекс строки в массиве, в данном примере - 0)

Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
int[] arraySum = new int[m];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
 for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++) 
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++){
        sum += array[i,j];
}
arraySum[i] = sum;
    
}

var lowest = arraySum[0];
int index = 0;
for (int i = 0; i < arraySum.GetLength(0); i++) 
{
    var num = arraySum[i];
        if(num < lowest){
            lowest = num;
            index = i;
        }
}
 
 Console.Write("Номер строки с наименьшей суммой элементов: " + index);
Console.WriteLine();
/* Произведением двух матриц А и В называется матрица С, элемент которой, находящийся на пересечении i -й строки и j -го столбца,
 равен сумме произведений элементов i -й строки матрицы А на соответствующие (по порядку) элементы j -го столбца матрицы В. 
 Из этого определения следует формула элемента матрицы C: Произведение матрицы А на матрицу В обозначается АВ.

Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.WriteLine("Введите размеры массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] firstArray = new int[n, n];
int[,] secondArray = new int[n, n];

 int[,] arrayMultiple = new int[n, n];

 
for (int i = 0; i < firstArray.GetLength(0); i++) 
{
    for (int j = 0; j < firstArray.GetLength(1); j++)
        firstArray [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}

Console.WriteLine("Первый массив");
for (int i = 0; i < firstArray.GetLength(0); i++) 
{
    for (int j = 0; j < firstArray.GetLength(1); j++)
        Console.Write(firstArray[i,j] + "\t  ");
        Console.WriteLine();
}

for (int i = 0; i < secondArray.GetLength(0); i++) 
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
        secondArray [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}


Console.WriteLine("Второй массив");
for (int i = 0; i < secondArray.GetLength(0); i++) 
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
        Console.Write(secondArray[i,j] + "\t  ");
        Console.WriteLine();
}

Console.WriteLine("произведение двух матриц");
 for (int i = 0; i < firstArray.GetLength(0); ++i)
                for (int j = 0; j < secondArray.GetLength(0); ++j)
                    for (int k = 0; k < secondArray.GetLength(1); ++k)
                        arrayMultiple[i, k] += firstArray[i, j] * secondArray[j, k];

 for (int i = 0; i < arrayMultiple.GetLength(0); i++) 
{
    for (int j = 0; j < arrayMultiple.GetLength(1); j++)
        Console.Write(arrayMultiple[i,j] + "\t  ");
        Console.WriteLine();
}
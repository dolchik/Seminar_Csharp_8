// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
        int temp = array[i,j];
        array[i,j] = array[j,i];
        array[j,i] = temp; 
        }
        
    }
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//запраштваем у пользователя кол-во строк и столбцов
int rows = EnterNumber("Введите количество строк массива: ");
int columns = EnterNumber("Введите количество столбцов массива: ");
//создаем массив с помощью рандома
int[,] matrix = CreateRandomArray(rows, columns, 1, 10);
if(rows == columns)
{
//выводим массив
PrintArray(matrix);
//меняем местами первую и последню строки массива
ChangeArray(matrix);
//выводим новый массив
Console.WriteLine();
PrintArray(matrix);
}
else Console.WriteLine("Количество строк и столбцов должно быть одинаковое!");


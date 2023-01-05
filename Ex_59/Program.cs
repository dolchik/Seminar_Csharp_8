// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

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

void NewArrayMethod(int[,] array, int minRow, int minColumn)
{
    int newLengthI = array.GetLength(0) - 1;
    int newLengthJ = array.GetLength(1) - 1;
    int[,] newArray = new int[newLengthI, newLengthJ];
    int m = 0;
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == minRow)
        {
            continue;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
          if (j == minColumn)
            {
                continue;
            }
            newArray[m,n] = array[i,j];
            n++;
        }
        m++;
        n = 0;
    }
    Console.WriteLine();
    PrintArray(newArray);
}

void FindMin(int[,] array)
{
    int min = array[0,0];
    int minRow = 0;
    int minColumn = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < min)
            {
                min = array[i,j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine(min + " " + minRow + " " + minColumn);
    NewArrayMethod(array, minRow, minColumn);
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
//выводим массив
PrintArray(matrix);
//находим минимальный элемент в массиве
FindMin(matrix);
//выводим новый массив


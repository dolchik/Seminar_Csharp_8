// Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, 
//сколько раз встречается элемент входных данных.

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

void CountDigits(int[,] array)
{
    for (int digit = 0; digit < 10; digit++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(digit == array[i,j])
            {
                count++;
            }
        }
        }
        if(count > 0) Console.WriteLine($"Array has {digit} elemment {count} times");
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
Console.WriteLine();
int[,] matrix = CreateRandomArray(rows, columns, 1, 10);
//выводим массив
PrintArray(matrix);
//просмотраваем массив, подсичтываем кол-во повторяющихся элементов + выводит инф
CountDigits(matrix);

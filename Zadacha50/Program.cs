// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void Zadacha50()
{
    Console.WriteLine("Введите количество строк и нажмите Enter");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов и нажмите Enter");
    int colums = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, colums];

    Console.WriteLine();
    FillArray(array);
    PrintArray(array);

    Console.WriteLine("Введите номер строки");
    int rowsAddress = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца");
    int columsAddress = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if (rowsAddress > rows || columsAddress > colums)
        Console.WriteLine("Данной ячейки не существует");
    else
        Console.WriteLine("В данной ячейке лежит число " + array[rowsAddress - 1, columsAddress - 1]);


}
void FillArray(int[,] array, int startNum = 0, int finishNum = 10)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = random.Next(startNum, finishNum);
        }
    }
}
void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Zadacha50();
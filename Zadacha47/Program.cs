// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами,
// округлёнными до одного знака.
void Zadacha47()
{
    Console.WriteLine("Введите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int colums = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, colums];

    FillArray(array);
    PrintArray(array);

}
void FillArray(double[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * 100, 2);
        }
    }
}
void PrintArray(double[,] array)
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
Zadacha47();
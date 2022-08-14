// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
void Zadacha52()
{
    Console.WriteLine("Введите количество строк и нажмите Enter");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов и нажмите Enter");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int[,] array = new int[rows, colums];

    FillArray(array);
    PrintArray(array);
    Console.WriteLine("Среднее арифметическое каждого столбца:");
    ArithColums(array);



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
void ArithColums(int[,] array)
{
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    float[] sum = new float[colums];

    for (int i = 0; i < colums; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            sum[i] += array[j, i];
        }
        Console.Write(Math.Round(sum[i] / rows, 2) + "\t");
    }
}
Zadacha52();
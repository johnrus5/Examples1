int rows = ReadInt ("Введите количество строк матрицы");
int columns = ReadInt ("Введите количество столбцов матрицы");

int [,] numbers = new int[rows,columns];

int firstRowToChange = 0;
int anotherRowToChange = numbers.GetLength(0) -1;

FillMatrixRandomNumbers (numbers);
WriteMatrix(numbers);
for (int j = 0; j < numbers.GetLength(1); j++)
{
    int temp = numbers [anotherRowToChange,j];
    numbers [anotherRowToChange,j] = numbers [firstRowToChange,j];
    numbers [firstRowToChange,j] = temp;
}
WriteMatrix(numbers);

int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrixRandomNumbers(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// Console.WriteLine("Введите размерность массива ");
// Console.WriteLine("Количество строк -  ");
// int lines = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Количество столбцов -  ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double [,] array = new double[lines,columns];
// Random rnd = new Random();
// for (int i = 0; i < lines; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         array[i,j] = (rnd.NextDouble()*100); 
//     }
// }
// for (int i = 0; i < lines; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         Console.Write("{0,3} ",(float)array[i,j]); 
//     }
//     Console.WriteLine();
// }


int columns = InputNumbers("Введите количество столбцов: ");
int lines = InputNumbers("Введите количество строк: ");
int range = InputNumbers("Введите диапозон от 1 до: ");
int[,] Array = new int[lines, columns];
CreateArray(Array);
PrintArray(Array);
Console.WriteLine();
SortArray(Array);
PrintArray(Array);

void SortArray(int[,] array)
{
    for (int z = 0; z <= (columns * lines); z++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(0) - 1; j++)
            {
                for (int k = i; k < array.GetLength(0); k++)
                {
                    if (array[i, j] > array[k, j])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[k, j];
                        array[k, j] = temp;
                    }
                }
            }
        }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                for (int k = j; k < array.GetLength(1); k++)
                {
                    if (array[i, j] > array[i, k])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }
    }
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

int InputNumbers(string input)
{
    Console.WriteLine(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
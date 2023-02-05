// string[,] table = new string[2,5];
// // String.Empty
// // table [0,0] table [0,1] table [0,2] ... table [0,4]
// // table [1,0] table [1,1] table [1,2] ... table [1,4]
// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//  for (int columns = 0; columns < 5; columns++)
//  {
//  Console.WriteLine($"-{table[rows, columns]}-");
//  }
// }



// int[,] matrix = new int[3, 4];
// for (int i = 0; i < 3; i++)
// {
//  for (int j = 0; j < 4; j++)
//  {
//  Console.WriteLine($"{matrix[i, j]} ");
//  }
// }


// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)   // Get.Length(0) - количсетво строк 
// {
//  for (int j = 0; j < matrix.GetLength(1); j++)  // Get.Length(1) - количсетво столбцов
//  {
//  Console.Write($"{matrix[i, j]} ");
// }
// Console.WriteLine();
// }



void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArrayWithRandoms(int rows, int columns, int leftrange, int rightrange)
{
    int[,] matr = new int[rows, columns];
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(leftrange, rightrange);//[1; 10)
            }
        }
    }
    return matr;
}

    // int[,] matrix = new int[3, 4];
    // PrintArray(matrix);
    int [,] matrix = FillArray(3, 4, 50, 200);
    Console.WriteLine();
    PrintArray(matrix);

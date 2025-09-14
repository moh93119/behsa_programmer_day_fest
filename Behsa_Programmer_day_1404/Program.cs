using Behsa_Programmer_Day_1404;

//sample
string data = "1,2,3,4;5,6,7,8;9,10,11,12;13,14,15,16;";
int[,] matrix = MatrixHelper.StringToMatrix(data);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }

    Console.WriteLine();
}
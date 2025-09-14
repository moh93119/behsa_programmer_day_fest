namespace Behsa_Programmer_Day_1404;

public class MatrixHelper
{
    /// <summary>
    /// Converts a string into a 2D integer matrix.
    /// Example input: "1,2,3;4,5,6;7,8,9"
    /// Row separator = ';', Column separator = ','
    /// </summary>
    public static int[,] StringToMatrix(string input, char rowSep = ';', char colSep = ',')
    {
        // Split rows
        var rows = input.Split(rowSep, StringSplitOptions.RemoveEmptyEntries);

        // Determine row & column counts
        int rowCount = rows.Length;
        int colCount = rows[0].Split(colSep, StringSplitOptions.RemoveEmptyEntries).Length;

        int[,] matrix = new int[rowCount, colCount];

        for (int i = 0; i < rowCount; i++)
        {
            var cols = rows[i].Split(colSep, StringSplitOptions.RemoveEmptyEntries);

            if (cols.Length != colCount)
                throw new FormatException("Matrix is not rectangular (rows have different lengths).");

            for (int j = 0; j < colCount; j++)
            {
                matrix[i, j] = int.Parse(cols[j].Trim());
            }
        }

        return matrix;
    }
}
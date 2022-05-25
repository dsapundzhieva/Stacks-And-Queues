int[,] matrix = new int[4, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = i + j;
       
    }
}

var printMatrix = Enumerable.Range(0, matrix.GetLength(1)).Select(row => Enumerable.Range(row, matrix.GetLength(0))).Select(x => string.Join(" ", x)).ToList();

Console.WriteLine(string.Join("\n", printMatrix));
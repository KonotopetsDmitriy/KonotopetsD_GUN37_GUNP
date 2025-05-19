//A
//1
int[] fibonacci = { 0, 1, 1,  2, 3, 5, 8, 13 };
//2
string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
//3
int[,] matrix = new int[3,3];
matrix[0,0] = 2;
matrix[0,1] = 3;
matrix[0,2] = 4;
matrix[1,0] = Convert.ToInt32(Math.Pow(matrix[0,0], 2));
matrix[1,1] = Convert.ToInt32(Math.Pow(matrix[0,1], 2));
matrix[1,2] = Convert.ToInt32(Math.Pow(matrix[0,2], 2));
matrix[2,0] = Convert.ToInt32(Math.Pow(matrix[1,0], 3));
matrix[2,1] = Convert.ToInt32(Math.Pow(matrix[1,1], 3));
matrix[2,2] = Convert.ToInt32(Math.Pow(matrix[1,2], 3));
//4
double[][] stairsMatrix = new double[3][];
stairsMatrix[0] = new double[] { 1, 2, 3, 4, 5 };
stairsMatrix[1] = new double[] { Math.E, Math.PI};
stairsMatrix[2] = new double[] { Math.Log(1,10), Math.Log(10,10), Math.Log(100,10),  Math.Log(1000,10)};

//B
int[] array = {1,2,3,4,5};
int[] array2 = {7,8,9,10,11,12,13};
//5
Array.Copy(array,array2,3);
//6
Array.Resize(ref array,array.Length*2);

//Output
Console.WriteLine("Task 1:\n" + string.Join(", ",fibonacci) + "\n\nTask2:\n" + string.Join(", ",months) + "\n\nTask 3:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\nTask 4:");
for (int i = 0; i < stairsMatrix.Length; i++)
{
    Console.Write(string.Join(", ", stairsMatrix[i]) + "\n");
}

Console.WriteLine("\nTask 5:\n" + string.Join(", ",array2) + "\n\nTask 6:\n" +  string.Join(", ",array));
Console.Clear();
Console.WriteLine("Введите размер трехмерного массива (от 2 до 4)");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
int k = int.Parse(Console.ReadLine()!);
int[,,] arr = GetArray(m, n, k);
PrintArray(arr);

int[,,] GetArray(int m, int n, int k) 
{
     int[,,] result = new int[m, n, k];
     Random r = new Random();
     for (int x = 0; x < m; x++)      
     {
        for(int y = 0; y < n; y++)
        {
            for(int z = 0; z < k; z++)
            {
                result[x, y, z] = r.Next(10, 99);
            }  
        }              
     }
     return result;
}
void PrintArray(int[,,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            for(int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        
    }
}
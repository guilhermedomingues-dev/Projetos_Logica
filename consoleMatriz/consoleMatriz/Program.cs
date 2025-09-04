// See https://aka.ms/new-console-template for more information
char[,] mat1 = new char[5, 10];
for (int i = 0; i < mat1.GetLength(0); i++)
{
    for (int j = 0; j < mat1.GetLength(1); j++)
    {
        if (i + j == 4 || j - i == 5)
        {
            mat1[i, j] = '8';
        }
       else if ((i + j >= 5) && (j-i<=4))
        {
            mat1[i, j] = '8';
        }
        else
        {
            mat1[i, j] = ' ';
        }
    }
}

for (int i = 0; i < mat1.GetLength(0); i++)
{
    for (int j = 0; j < mat1.GetLength(1); j++)
    {
        Console.Write(mat1[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("\n");

char[,] mat2 = new char[10, 10];
for (int i=0; i<mat2.GetLength(0); i++)
{
   for (int j = 0; j < mat2.GetLength(1); j++)
   {
      if ((i + j >= 4 && i + j <= 14) && (i - j >= -5 && i - j <= 5))
      {
        mat2[i, j] = '8';
      }
      else
      {
        mat2[i, j] = ' ';
      }
   }
}
for (int i = 0; i < mat2.GetLength(0); i++)
{
    for (int j = 0; j < mat2.GetLength(1); j++)
    {
        Console.Write(mat2[i, j] + " ");  // Write - sem quebra de linha
    }
    Console.WriteLine();  // Quebra linha só no final de cada linha
}

Console.WriteLine("\n");

char[,] mat3 = new char[10, 10];
for (int i = 0; i < mat3.GetLength(0); i++)
{
    for(int j = 0;j < mat3.GetLength(1); j++)
    {
        if((i==0) || (j % 2 == 0))
        {
            mat3[i, j] = '8';
        }
        else
        {
            mat3[i, j] = ' ';
        }
    }
}

for (int i = 0; i < mat3.GetLength(0); i++)
{
    for (int j = 0; j < mat3.GetLength(1); j++)
    {
        Console.Write(mat3[i, j] + " ");  // Write - sem quebra de linha
    }
    Console.WriteLine();  // Quebra linha só no final de cada linha
}
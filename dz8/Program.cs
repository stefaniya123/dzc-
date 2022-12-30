//Задача 1

// Console.WriteLine("введите количество сток");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columns=Convert.ToInt32(Console.ReadLine());
// int [,] matrix= new int [rows,columns];

// int [,] GetArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         array[i,j]=new Random().Next(10);
//     }
//     return array;
// }

// void PrintArray(int [,] array)
// {
//      for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i,j]+" ");
//     }
//     Console.WriteLine(" ");
  
// }
// }

// int [,] ChangeArray(int [,] array)
// {
// int temp=0;
//     for (int i = 0; i <array.GetLength(0); i++)
// {
//     for (int j = 0; j <array.GetLength(1);j++)
//     {
//         for (int m = 0; m <array.GetLength(1)-1;m++)
//     if (array[i,m]<array[i,m+1])
//     {
//          temp=array[i,m+1];
//        array[i,m+1]=array[i,m];
//        array[i,m]=temp;
//     }
// }
// }
// return array;
// }


// GetArray(matrix);
// PrintArray(matrix);

// Console.WriteLine("");
// ChangeArray(matrix);
// Console.WriteLine("отсортированный массив ");
// PrintArray(matrix);

//Задача 2

// Console.WriteLine("введите количество сток");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columns=Convert.ToInt32(Console.ReadLine());
// int [,] matrix= new int [rows,columns];

// int [,] GetArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         array[i,j]=new Random().Next(10);
//     }
//     return array;
// }

// void PrintArray(int [,] array)
// {
//      for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i,j]+" ");
//     }
//     Console.WriteLine(" ");
  
// }
// }

// int GetSum(int [,] array)
// {
//    int sum=0;
//    int temp=0;
//    int sumMax=0;
//    int num=0;
//    for (int i = 0; i < array.GetLength(0); i++)
//  {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sum=sum+array[i,j];
//     }
// Console.WriteLine($"Сумма {i+1} строки= {sum}");
// temp=sum;
// if (temp>sumMax)
// {
//     sumMax=temp;
//     num=i+1;
// }
// sum=0;
//   }
//     return num;
// }


// GetArray(matrix);
// PrintArray(matrix);
// Console.WriteLine("");
// int num=GetSum(matrix);
// Console.WriteLine("Номер строчки c максимальной суммой= "+num);

//Задача 3

// Console.WriteLine("введите количество сток первой матрицы");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов первой матрицы");
// int columns=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество сток второй матрицы");
// int rows_2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов второй матрицы");
// int columns_2=Convert.ToInt32(Console.ReadLine());
// int [,] matrix= new int [rows,columns];
// int [,] matrix_2= new int [rows_2,columns_2];
// if (rows!=rows_2|columns!=columns_2){
//     Console.WriteLine("Перемножить матрицы с указанными размерами невозможно");
// }

// int [,] GetArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         array[i,j]=new Random().Next(10);
//     }
//     return array;
// }

// void PrintArray(int [,] array)
// {
//      for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i,j]+" ");
//     }
//     Console.WriteLine(" ");
  
// }
// }

// int [,] GetProizved(int [,] array, int[,]array2)
// {
//     int [,] array_rez = new int [rows,columns];
   
//      for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int sum=0;
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//            sum+=array[i,k]*array2[k,j];
        
//         }
//        array_rez[i,j]=sum;
//        Console.Write($"{array_rez[i,j]} ");
//     }
   
//   Console.WriteLine("");
// }

//     return array_rez;
// }

// GetArray(matrix);
// PrintArray(matrix);
// Console.WriteLine("");
// GetArray(matrix_2);
// PrintArray(matrix_2);
// Console.WriteLine("Результат умножения 1й матрицы на 2-ую");
// GetProizved(matrix,matrix_2);

//Задача 4


// Console.WriteLine("введите количество сток");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columns=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество страниц");
// int kol=Convert.ToInt32(Console.ReadLine());

// int [,,] matrix= new int [rows,columns,kol];

// int [,,] GetArray(int [,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k< array.GetLength(2); k++)
//             {
//                 int s=new Random().Next(100);
//                 array[i,j,k]=(new Random().Next(10))+s;
//             }
//         }
        
//     }
//     return array;
// }

// void PrintArray(int [,,] array)
// {
//      for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int k = 0; k < array.GetLength(2); k++)
//         {
//                     Console.Write($"{array[i,j,k]} ({i},{j},{k})");
//         }
//     }
//     Console.WriteLine(" ");
//   }
// }
// GetArray(matrix);
// PrintArray(matrix);
// Console.WriteLine("");

//Задача 5

// Console.WriteLine("введите количество сток");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columns=Convert.ToInt32(Console.ReadLine());
// int [,] matrix= new int [rows,columns];
// int count=1;
// int n=rows;
// int [,] Func(int [,]array)
// {
   

//  for (int i = 0; i < rows/2; i++)
//  { 
//     for (int j=i;j<rows-i;j++)
//     {
//     array[i,j]=count++;
//     }
//     for (int k = i+1; k < rows-i;k++)
//     {
//     array[k,rows-i-1]=count++;
//     }
//     for (int j = rows-i-2; j >=i; j--)   
//     {
//         array[rows-i-1,j]=count++;
//     }
//     for (int k = rows-2-i; k >i; k--)
//     {
//         array[k,i]=count++;
//     }
//     }
//     return array;
//  }
     

// void PrintArray(int [,] array)
// {
//      for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i,j]+" ");
//     }
//     Console.WriteLine(" ");
  
// }
// }
// Func(matrix);
// PrintArray(matrix);
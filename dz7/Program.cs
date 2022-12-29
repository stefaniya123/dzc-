// Задача 1


// Console.WriteLine("введите количество сток");
// int row=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество сток");
// int columns=Convert.ToInt32(Console.ReadLine());
// double [,] matrix= new double [row,columns]; 
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j= 0; j < matrix.GetLength(1); j++)
//   {
//     double ost=new Random().NextDouble();
//     matrix[i,j]=new Random().Next(-10,10)+Math.Round(ost,1);
    
//     Console.Write(matrix[i,j]+" ");
//   } 
//   Console.WriteLine("");
// } 

// Задача 2
// int row=4;
// int columns=4;
// int [,] matrix = new int[row,columns];

// Console.WriteLine("введите номер строки i");
// int numi=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца j");
// int numj=Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]= new Random().Next(0,10);
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine(" ");
// } 
//     if (numi>row|numj>columns)
//     Console.WriteLine("элемента на заданной позиции нет");
//     else
//     Console.Write($"на позиции {numi},{numj} находится элемент {matrix[numi,numj]}"); 



// 

// Задача 3

int row=4;
int columns=4;
int [,] matrix = new int[row,columns];
double sum=0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j]= new Random().Next(0,10);
     
        Console.Write($"{matrix[i,j]} ");
         
    }   
    Console.WriteLine(" ");
}
int count=1;
for (int j = 0; j< matrix.GetLength(1); j++)
{  
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum=sum+matrix[i,j];
    }
    Console.WriteLine("среднее арифметическое по столбцу "+count+"="+sum/columns);
    sum=0;
    count++;
}


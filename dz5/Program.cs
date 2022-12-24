// Задача 1

// int [] array= new int[5];
// int count=0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(100,1000);
// }

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i]%2==0)
//     {
//         count++;
//     }
// }
// Console.WriteLine(string.Join(",", array));
// Console.WriteLine("количество четных элементов "+count);

// Задача 2
// int [] array= new int[6];
// int sum=0;
// 
// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(10,100);
//     if (i%2!=0)
//     {
//         sum=sum+array[i];
//     }
// }
// Console.WriteLine(string.Join(",", array));
// Console.WriteLine("сумма элементов на нечетных позициях "+sum);

//Задача 3

double [] array= new double[5];
double max=0;
double min=0;

for (int i = 0; i < array.Length; i++)
{
    array[i]=(new Random().Next(10, 100));
}
Console.WriteLine(string.Join(",", array));

max=array[0];
min=array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i]>max)
    {
    max=array[i];
    }
    if (array[i]<min)
    {
    min=array[i];
    } 
}
Console.WriteLine("Разница между максимальным и минимальным="+(max-min));


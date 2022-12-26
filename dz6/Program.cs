// // Задача 1


// Console.WriteLine("введите количесто элементов массива");

// int a=Convert.ToInt32(Console.ReadLine());
// int [] array=new int[a];
// int count=0;
// Console.WriteLine("введите элементы массива");

//  int [] Func()
//  {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i]=Convert.ToInt32(Console.ReadLine());
//         if (array[i]>0)
//         count++;

//     }
//     return array;
//  }
// Console.WriteLine(string.Join(",", Func()));
// Console.WriteLine("количество элементов больше нуля "+count);

// Задача 2

Console.WriteLine("введите значение k1");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите значение b1");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите значение k2");
double k2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2=Convert.ToDouble(Console.ReadLine());
// из условия y=k1*x+b1 - y=k2*x-b2 можно выразить х;
if (k1==k2)
    Console.WriteLine("Прямые параллельны");
else {

double x=(b2-b1)/(k1-k2);
double y1=k1*x+b1;
double y2=k2*x+b2;
y1=Math.Round(y1,2);
y2=Math.Round(y2,2);
if (y1==y2)

    Console.WriteLine($"Точка пересечения М имеет координаты M ({x} , {y1})");
else
    Console.WriteLine("прямые заданные данными уравнениями не пересекаются");
}



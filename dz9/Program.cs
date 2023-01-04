//Задача 1


// Console.WriteLine("введите значение m");
// double m=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("введите значение n");
// double n=Convert.ToDouble(Console.ReadLine());

// string Print(double a,double b)
// {
//        if (a==b)
//     {
//         a=Math.Round(a,2);
//         return(a.ToString());
//     }
//      if (b<a)
//     {
//         return ("введите число n>m");

//     }
// a=Math.Round(a,2);
// return (a +" "+ Print(a+0.2,b));
// }

// Console.WriteLine(Print(m,n));

//Задача 2

// Console.WriteLine("введите значение m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение n");
// int n = Convert.ToInt32(Console.ReadLine()); ;

// int SumMN(int m, int n)
// {

//     if (m == n)
//     {
//         return n;
//     }
//     return (m + SumMN(m + 1, n));
// }

// if (n < m)

//     Console.WriteLine("введите значение n>m");
// else
//     Console.WriteLine("Сумма элементов от m до n=" + SumMN(m, n));

//Задача 3

Console.WriteLine("введите значение m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение n");
int n = Convert.ToInt32(Console.ReadLine());

int FuncAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return FuncAkkerman(m - 1, 1);
    else return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
}

if (m > 0 && n > 0)
    Console.WriteLine("значение функции Аккермана=" + FuncAkkerman(m, n));
else
    Console.WriteLine("введите значения m и n больше нуля");
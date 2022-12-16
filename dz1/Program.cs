// ПЕРВАЯ ЗАДАЧА

// Console.WriteLine("Введите первое число");
// int m=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int n=Convert.ToInt32(Console.ReadLine());

// if (m>n) {
//     Console.WriteLine("Первое число больше второго");
// }
// else {
//     Console.WriteLine("Второе число больше первого");
// }


// ВТОРАЯ ЗАДАЧА

//  Console.WriteLine("Введите первое число");
//  int a=Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите второе число");
//  int b=Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine("Введите третье число");
//  int c=Convert.ToInt32(Console.ReadLine());
// int max =a;
// if (b>max){
//     max=b;
// }
// if (c>max)
// {
//     max=c;
// }
// Console.WriteLine($"Максимальное число= {max}"); 

// ТРЕТЬЯ ЗАДАЧА

// Console.WriteLine("Введите число");
// int a=Convert.ToInt32(Console.ReadLine());
// if (a%2==0)
// {
//     Console.WriteLine($"Число {a} четное");
// }
// else
// {
// Console.WriteLine($"Число {a} нечетное");
// }

//ЧЕТВЕРТАЯ ЗАДАЧА

Console.Write("Введите число ");
int a =Convert.ToInt32(Console.ReadLine());
int i=1;
Console.WriteLine("Четный массив до заданного числа");
while(i<=a)

if (i%2==0)
{
    Console.WriteLine(i);
    i+=1;
}
else 
{
    i+=1;
}
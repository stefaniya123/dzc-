//ПЕРВАЯ ЗАДАЧА

// int n=new Random().Next(100,1000);
// Console.WriteLine(n);
// int num1=n%100;
// int result=num1/10;
// Console.WriteLine(result);


//ВТОРАЯ ЗАДАЧА

// Console.Write("Введи число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string count = Convert.ToString(num);
// int len=count.Length;
// if (len>2) 
// {
//     Console.WriteLine(count[2]);
// }
// else{
//     Console.WriteLine("третьей цифры нет");
// }


//ТРЕТЬЯ ЗАДАЧА

Console.WriteLine("введите число дня недели");
int N = Convert.ToInt32 (Console.ReadLine());
if (N==1)
{
Console.WriteLine("понедельник");
}
if (N==2)
{
Console.WriteLine("вторник");
}
if (N==3)
{
Console.WriteLine("среда");
}
if (N==4)
{
Console.WriteLine("четверг");
}
if (N==5)
{
Console.WriteLine("пятница");
}
if (N==6)
{
Console.WriteLine("суббота");
}
if (N==7)
{
Console.WriteLine("восскресенье");
}
if (N>7)
{
    Console.WriteLine("введите число от 1 до 7");
}

if (N==6||N==7)
{
     Console.WriteLine("это выходной");
}
else
{
    Console.WriteLine("это не выходной");
}
// Задача 1

// Console.WriteLine("Введи число для проверки: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string count = Convert.ToString(num);
// int len=(count.Length)-1;
// int i=0;

// while (i<len)
// {
//     if ((count[i])==(count[len]))
//     {
//     i++;
//     len--;
//          if (i==len)
//          { 
    
//            Console.WriteLine("число палиндром");
            
//          }
//     }
//     else
//     {
//          Console.WriteLine("число непалиндром");
//          break;
         
//     }
// }

// Задача 2
// int i=0;
// int[] a = new int[3];
// int [] b= new int [3];
// Console.WriteLine("Ввeдитe последовательно координаты точки А: ");
// for (i=0;i < a.Length; i++)
// {
//    a[i]=Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine("Ввeдитe последовательно координаты точки В: ");

// for (i=0;i < a.Length; i++)
// {
//    b[i]=Convert.ToInt32(Console.ReadLine());
// }

// double d=(Math.Sqrt(Math.Pow((b[0])-(a[0]),2)+Math.Pow((b[1])-(a[1]),2)+Math.Pow((b[2])-(a[2]),2)));
// Console.WriteLine("Расстояние между точками А и В =" + d);


// Задача 3

Console.WriteLine("Ввeдитe число N ");
int n=Convert.ToInt32(Console.ReadLine());
int i;
for (i=1;i<=n;i++)
{
Console.WriteLine(Math.Pow(i,3));
}
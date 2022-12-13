//int 
//double
//string
//bool
                             // Найти число являющееся квадратом 

//Console.WriteLine("Введите первое число");
//int a = Convert.ToInt32(Console.ReadLine("Введите второе  число));
//Console.WriteLine();
//int b = Convert.ToInt32(Console.ReadLine());
//    if (b * b == a);
//        {Console.WriteLine($" Число {a} является квадратом {b} ")
//        }
//    else
//{
//         Console.WriteLine("Не является");

//}   

                          //Определение дня недели по водимому числу


//Console.WriteLine("Введите номер дня недели");
//int num = Convert.ToInt32(Console.ReadLine("Введите второе  число")); 

//if (num == 1);
//  {Console.WriteLine("Понедельник")};
//if (num == 2);
//  {Console.WriteLine("Вторник")};
//if (num == 3 );
//  {Console.WriteLine("Среда")};
//if (num == 4);
//  {Console.WriteLine("Четверг")};
//if (num == 5);
//  {Console.WriteLine("Пятница")};
//if (num == 6);
//  {Console.WriteLine("Суббота")};
//if (num == 7);
//  {Console.WriteLine("Воскресенье")};
//else 
//  {Console.WriteLine("Error")};


// Напишите программу , которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа

/*Console.WriteLine("Введите трехзначное число: ");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb>99 && numb<1000)
    {
        Console.WriteLine(numb%10);

    }
else
{
    Console.WriteLine("Error");
}

//                                  Напишите программу, которая на вход принимает число N , а навыходе показывает все целые цисла в промежутке от -N до N

Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int t = n *(-1);
while (t<=n)
    {Console.Write(t+" ");
    }
*/


//                                    ДОМАШНЕЕ ЗАДАНИЕ
                                    // Задача 2 

/* int a, b;
 
        Console.WriteLine("Введите два числа : ");
 
        a = Convert.ToInt32(Console.ReadLine());
 
        b = Convert.ToInt32(Console.ReadLine());
 
        if (a > b)
 
        {
 
            Console.WriteLine("{a} больше {b}");
 
        }
 
        else
 
        {
 
            Console.WriteLine($"{b} больше {a} ");
 
        }
 
        Console.ReadLine();
        */



 
    //                                    ДОМАШНЕЕ ЗАДАНИЕ
                                    // Задача 4

 /*                                   
int a, b, c;
    Console.WriteLine("Введите три числа : ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine()); 
if ((b < a) && (a > c))
    {
    Console.WriteLine($"Максимальное из этих чисел {a} ");
    }
else if ((a < b) && (b > c))
    {
    Console.WriteLine($"Максимальное из этих чисел {b} ");
    }
else
    {
    Console.WriteLine($"Максимальное из этих чисел {c} ");
    }
*/
 
        
 
                                  //ДОМАШНЕЕ ЗАДАНИЕ
                                    // Задача 6
/*
int i;
     Console.WriteLine("Введите число : ");
        i = Convert.ToInt32(Console.ReadLine());
    if (i % 2 == 0)
         {
            Console.Write("Введенное число является четным");  
 }
    else
        {
            Console.Write("Введенное число является нечетным");
        }                            
        */


                                //ДОМАШНЕЕ ЗАДАНИЕ
                                    // Задача 8


 /*int num = Convert.ToInt32(Console.ReadLine());
    int res = 1;
    while (res < num)
       {
        Console.WriteLine(res+1);
        res+= 2;
       }
    */

                                //ДОМАШНЕЕ ЗАДАНИЕ
                                    // Задача 15
/*
  Console.Write("Введите число от 1 до 7:");
    int num;
    num = Convert.ToInt32(Console.ReadLine());
    if (num >= 1 && num <= 7)
    {
    if (num == 6 | num == 7) Console.WriteLine("Выходной день");
    else Console.WriteLine("Рабочий день");
    }
    else Console.WriteLine("Error!");
    */
                                 //ДОМАШНЕЕ ЗАДАНИЕ
                                    // Задача 13

/* Console.Write("Введите любое число: ");
    int num, numDigit;
    num = Convert.ToInt32(Console.ReadLine());
        string numStr = Convert.ToString(num);
        numDigit = numStr.Length;
            if (numDigit > 2) Console.WriteLine($"Третья цифра введённого числа: {numStr[2]}");
            else Console.WriteLine("третьей цифры нет");
*/

                                 //ДОМАШНЕЕ ЗАДАНИЕ
                                    // Задача 10
/*Console.Write("Введите трёхзначное число: ");
int num;
num = Convert.ToInt32(Console.ReadLine());
num = num / 10 % 10;
Console.WriteLine($"Ответ: {num}");*/
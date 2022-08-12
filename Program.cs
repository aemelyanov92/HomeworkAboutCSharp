// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // Нужно сделать через числа, без индексов строк.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1
// int number = new Random().Next (100,1000);
// Console.WriteLine(number);
// int secondDigit = ((number % 100) / 10);
// Console.WriteLine($"{secondDigit}");

// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string txtnum = Convert.ToString(number);
// if (txtnum.Length>2) 
// {
//     Console.WriteLine(txtnum[2]);
// }
// else 
// {
//     Console.WriteLine("Нет третьей цифры, введите другое число");
// }    


// // Напишите программу, которая будет выдавать название дня недели
// //  по заданному номеру!
// // 3 -> Среда 
// // 5 -> Пятница

// int dayNumber = Convert.ToInt32(Console.ReadLine());

// if (dayNumber == 1)
// {
//     System.Console.WriteLine("Понедельник");
// }
// if (dayNumber == 2)
// {
//     System.Console.WriteLine("Вторник");
// }
// else
// {
//    System.Console.WriteLine("error 404");     
// }



// // Задача 15: Напишите программу, которая принимает на вход цифру, 
// // обозначающую день недели, и проверяет, является ли этот день выходным.
// // 6 -> да
// // 7 -> да
// // 1 -> нет
// // Console.WriteLine("Введите число: ");

// // int day = Convert.ToInt32(Console.ReadLine());

// // if (day<6)
// // {
// //     Console.WriteLine("Это будний день");
// // }

// // else
// // {
// //     Console.WriteLine("Это выходной");
// // }


// // Но я думаю что надо лучше так:

// // Version 2.1 Modified

// // Console.WriteLine("Введите число: ");

// // int day = Convert.ToInt32(Console.ReadLine());

// // if (day<6)
// // {
// //     Console.WriteLine("Это будний день");
// // }
// // else if(day>7)
// // {
// //     Console.WriteLine("Error 404, так не бывает");
// // }
// // else
// // {
// //     Console.WriteLine("Это выходной");
// // }
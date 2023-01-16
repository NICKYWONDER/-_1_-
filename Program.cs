// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Решение :

// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.Clear();
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.Clear();

// if(num1 < num2){
//     Console.Write($"ДА! Число {num2} = max");    
// }
// if(num1 > num2){
//     Console.Write($"НЕТ! Число {num1} < max");
// }




// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Решение:


// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.Clear();
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.Clear();
// Console.Write("Введите третье число: ");
// int num3 = int.Parse(Console.ReadLine()!);
// Console.Clear();

// int max = Math.Max(num1, Math.Max(num2, num3));

// Console.Write($"Максимальное число = {max} ");




// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
// Решение:

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// if (num % 2 == 0) {
//     Console.WriteLine("ДА! Делиться на два");
// } 
// else {
//    Console.WriteLine("НЕТ! Не делиться на два");
// }



// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// Решение:


// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
    
// for (int i = 1; i <= n; i++)
//     if (i % 2 == 0)
//         Console.WriteLine(i);


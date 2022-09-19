// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
//-----------------------------------------

//request user data
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "");
    return num;
}
// output results
void PrintData(string prefix, string num)
{
    Console.Write(prefix + num);
}
//проходим по числам от меньшего к большему.
string NumMtoN(int m, int n)
{
    if (m >= n)
    {
        return n.ToString();
    }
    else
    {
        return m.ToString() + ", " + NumMtoN(m + 1, n);
    }
}

Console.Clear();
int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
string res = (m < n) ? (NumMtoN(m, n)) : (NumMtoN(n, m));
PrintData("Все натуральные числа в диапазоне: ", res);



//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "");
//     return num;
// }
// // output results
// void PrintData(string prefix, string num)
// {
//     Console.Write(prefix + num);
// }
// //проходим по числам от меньшего к большему и суммируем их.
// int SumMton(int m, int n)
// {
//     if (m >= n)
//     {
//         return n;
//     }
//     else
//     {
//         return m + SumMton(m + 1, n);
//     }
// }

// Console.Clear();
// int m = ReadData("Введите число M: ");
// int n = ReadData("Введите число N: ");
// // int sum = (m < n) ? (SumMton(m, n)) : (SumMton(n, m));
// int sum = 0;
// if (m < n)
// {
//     sum = SumMton(m, n);
//     PrintData("Сумма всех натуральных чисел от " + m + " до " + n + " равна: ", sum.ToString());
// }
// else
// {
//     sum = SumMton(n, m);
//     PrintData("Сумма всех натуральных чисел от " + n + " до " + m + " равна: ", sum.ToString());
// }



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29



// //request user data
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "");
//     return num;
// }
// // output results
// void PrintData(string prefix, int num)
// {
//     Console.Write(prefix + num);
// }
// //нахождение функции Аккермана
// int Akkerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else
//       if ((m != 0) && (n == 0))
//         return Akkerman(m - 1, 1);
//     else
//         return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// Console.Clear();
// int m = ReadData("Введите число M: ");
// int n = ReadData("Введите число N: ");
// PrintData("Значение функции Аккремана: ", Akkerman(m, n));






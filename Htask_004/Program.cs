// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя
// 3, 5 -> 243 (3⁵)
//2, 4 -> 16

// int numberA = ReadInt("Введите число A: ");
// int numberB = ReadInt("Введите число B: ");
// ToDegree(numberA, numberB);

// void ToDegree(int a, int b)
{
    // int result = 1;
    // for (int i = 1; i <= b; i++)
    {
       // result = result * a;
    }
    // Console.WriteLine(result);
}

// int ReadInt(string msg)
{
    //Console.WriteLine(msg);
    //return Convert.ToInt32(Console.ReadLine());
}





// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}



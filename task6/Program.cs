using System;
using System.Collections.Generic;
using task6;

public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var evenNumbers = numbers.CustomWhere(n => n % 2 == 0);
        Console.WriteLine("ლუწი რიცხვები: " + string.Join(", ", evenNumbers));

        var greaterThanThree = numbers.CustomFirstOrDefault(n => n > 3);
        Console.WriteLine("3-ზე დიდი პირველი რიცხვი: " + greaterThanThree);

        var greaterThanTen = numbers.CustomFirstOrDefault(n => n > 10);
        Console.WriteLine("10-ზე დიდი პირველი რიცხვი (ვერ იპოვა): " + greaterThanTen);

        bool hasFives = numbers.CustomAny(n => n == 5);
        Console.WriteLine("არის თუ არა 5-იანი კოლექციაში? " + hasFives);

        bool allPositive = numbers.CustomAll(n => n > 0);
        Console.WriteLine("ყველა რიცხვი დადებითია? " + allPositive);

        int total = numbers.CustomCount();
        Console.WriteLine("საერთო რაოდენობა: " + total);

        int oddCount = numbers.CustomCount(n => n % 2 != 0);
        Console.WriteLine("კენტი რიცხვების რაოდენობა: " + oddCount);
    }
}
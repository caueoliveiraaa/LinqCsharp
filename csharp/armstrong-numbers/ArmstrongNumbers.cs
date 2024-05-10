using System;
using System.Collections.Generic;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        string digits = number.ToString();
        List<int> armstrongNumbers = GetArmstrongNumbers(digits);
        int result = CalculateArmstrongNumbers(armstrongNumbers);
        return result == number;
    }

    public static List<int> GetArmstrongNumbers(string digits) 
    {
        List<int> digitsList = new List<int>();
        foreach (char digit in digits)
            digitsList.Add(int.Parse(digit.ToString()));
        return digitsList;
    }

    public static int CalculateArmstrongNumbers(List<int> armstrongNumbers)
    {
        int sum = 0;
        foreach (var number in armstrongNumbers)
        {
            int powerOf = number;
            for (int i = 1; i < armstrongNumbers.Count; i++)
                powerOf *= number;
            sum += powerOf;
        }
        return sum;
    }
}

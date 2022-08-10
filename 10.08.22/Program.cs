using System;

public class Kata
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        GetMiddle(s);
    }

    public static string GetMiddle(string s)
    {
        char[] arr;
        arr = s.ToCharArray();
        if (arr.Length % 2 == 0)
        {
            s = Convert.ToString(arr[(arr.Length - 1) / 2]) + Convert.ToString(arr[((arr.Length - 1) / 2) + 1]);
            return s;
        }
        else
        {
            s = Convert.ToString(arr[arr.Length / 2]);
            return s;
        }
    }
}
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace lab11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шестизначное число");
            string a = Console.ReadLine();
            string result=Logic.Compare(a);
            Console.WriteLine(result);
        }

    }
}
public class Logic
{
    public static string Compare (string a)
    {
        string outMessage = "";
        if (a.Length != 6)
        {
           outMessage=("число не шестизначное");
        }
        else
        {
            int first = 0;
            int last = 0;
            for (int i = 0; i < 3; i++)
            {
                first += int.Parse(a[i].ToString());
                last += int.Parse(a[i + 3].ToString());
            }
            if (first == last)
            {
                outMessage=("число счастливое");
            }
            else outMessage=("число несчастливое");
        }
        return outMessage;
    }
}


